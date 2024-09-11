using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TL;
using Microsoft.VisualBasic;
using System.Configuration;
using System.IO;

namespace UserBotSender
{

    public partial class UserBotSender : Form
    {
        private WTelegram.Client client;
        private Messages_Chats chats;
        private string selectedImagePath;

        public UserBotSender()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Load settings from app.config
            apiIdTextBot.Text = ConfigurationManager.AppSettings["API_ID"];
            apiHashTextBox.Text = ConfigurationManager.AppSettings["API_HASH"];
            numberTextBox.Text = ConfigurationManager.AppSettings["PhoneNumber"];
            twoFATextBox.Text = ConfigurationManager.AppSettings["TwoFA"];
        }

        private void SaveSettings()
        {
            // Save settings to app.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["API_ID"].Value = apiIdTextBot.Text;
            config.AppSettings.Settings["API_HASH"].Value = apiHashTextBox.Text;
            config.AppSettings.Settings["PhoneNumber"].Value = numberTextBox.Text;
            config.AppSettings.Settings["TwoFA"].Value = twoFATextBox.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private async Task DoLogin(string loginInfo)
        {
            if (string.IsNullOrWhiteSpace(apiHashTextBox.Text))
            {
                MessageBox.Show("API HASH is empty");
                return;
            }

            if (string.IsNullOrWhiteSpace(apiIdTextBot.Text))
            {
                MessageBox.Show("API ID is empty");
                return;
            }

            if (!int.TryParse(apiIdTextBot.Text, out int API_ID))
            {
                MessageBox.Show("API ID must be digit");
                return;
            }

            string API_HASH = apiHashTextBox.Text;

            if (client == null)
            {
                client = new WTelegram.Client(API_ID, API_HASH);
            }

            // Логинимся
            var loginState = await client.Login(loginInfo);

            if (client.User != null)
            {
                MessageBox.Show($"Успех, вход {client.User} (id {client.User.id})");

                await set_user_data(client);

                SaveSettings();

                return;
            }

            // Проверяем состояние логина и запрашиваем код верификации
            if (loginState == "verification_code")
            {
                MessageBox.Show("Введите код подтверждения, который был отправлен вам в Telegram");
                await client.Login(Interaction.InputBox("Enter verification code"));
                await client.Login(twoFATextBox.Text);

                MessageBox.Show($"Успех, вход {client.User} (id {client.User.id})");

                await set_user_data(client);

                SaveSettings();

                return;
            }
        }

        private async void send_code_Click(object sender, EventArgs e)
        {
            await DoLogin(numberTextBox.Text);
        }

        private async Task set_user_data(WTelegram.Client client)
        {
            if (client.User == null)
            {
                return;
            }

            userDataLabel.Text = (
                $"User: {client.User}" + "\n" +
                $"ID: {client.User.id}"
            );

            await LoadUserProfilePhoto();
            await LoadUserChats();
        }

        private async Task LoadUserProfilePhoto()
        {
            if (client.User.photo != null)
            {
                var profilePhoto = client.User.photo as UserProfilePhoto;
                if (profilePhoto != null)
                {
                    var fileStream = new MemoryStream();
                    await client.DownloadProfilePhotoAsync(client.User, fileStream);

                    fileStream.Position = 0;

                    Image userImage = Image.FromStream(fileStream);

                    avatarImageBox.Image = userImage;
                }
                else
                {
                    MessageBox.Show("No profile photo available.");
                }
            }
            else
            {
                MessageBox.Show("No profile photo available.");
            }
        }

        private async Task LoadUserChats()
        {
            if (client == null)
            {
                return;
            }

            var result = await client.Messages_GetAllChats();
            chats = result;
            var finalChatMessage = "";

            finalChatMessage += "Chats and channels:\r\n";

            foreach (var chat in result.chats.Values)
            {
                string chatType = "";
                string chatName = "";

                switch (chat)
                {
                    case TL.Channel channel:
                        chatType = "Channel";
                        chatName = channel.title;
                        break;
                }

                finalChatMessage += $"{chatType} - {chat.ID} - {chatName}\r\n";
            }

            chatsTextBox.Text = finalChatMessage;

            start_send.Enabled = true;
            openPhoto.Enabled = true;
        }

        private void SpamMessage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(htmlFormatedMessage.Text))
            {
                webBrowserPreview.DocumentText = "<html><body><p>Preview</p></body></html>";
            }
            else
            {
                webBrowserPreview.DocumentText = $"<html><body>{htmlFormatedMessage.Text}</body></html>";
            }
        }

        private void setLogs(string Log)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logEntry = $"{date} - {Log}\r\n";

            outputTextBox.Text += logEntry;

            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs.txt");

            try
            {
                File.AppendAllText(logFilePath, logEntry); // Дописываем текст в файл
            }
            catch (Exception ex)
            {
                // Обработка ошибок при записи в файл
                outputTextBox.Text += $"Ошибка записи в лог файл: {ex.Message}\r\n";
            }
        }

        private void ClearLogs()
        {
            outputTextBox.Text = string.Empty;
        }

        private async void start_send_Click(object sender, EventArgs e)
        {
            var chats_list = groupsTextBox.Text.Split('\n');

            InputFileBase fileUploaded = await client.UploadFileAsync(selectedImagePath);
            InputMediaUploadedPhoto inputMedia = new InputMediaUploadedPhoto();
            inputMedia.file = fileUploaded;

            foreach (var chat_str in chats_list)
            {
                long chat_id = 0;
                int topic_id = 0;

                if (string.IsNullOrEmpty(chat_str))
                {
                    continue;
                }

                // Parse chat ID and topic ID (if present)
                if (chat_str.Contains("|"))
                {
                    chat_id = long.Parse(chat_str.Split('|')[0]);
                    topic_id = int.Parse(chat_str.Split('|')[1]);
                }
                else
                {
                    chat_id = long.Parse(chat_str);
                }

                var text_to_send = htmlFormatedMessage.Text;
                var entities = client.HtmlToEntities(ref text_to_send);

                // Ensure chat exists or join if not already in the chat list
                InputPeer inputPeer = null;
                if (chats.chats.ContainsKey(chat_id))
                {
                    inputPeer = chats.chats[chat_id];

                    try
                    {
                        await client.SendMessageAsync(inputPeer, text_to_send, entities: entities, reply_to_msg_id: topic_id, media: inputMedia);
                    }
                    catch (Exception ex)
                    {
                        // Запись ошибки в лог с сообщением об исключении
                        setLogs($"Ошибка отправки сообщения: {ex.Message}\n{ex.StackTrace}");
                        continue;
                    }

                    setLogs($"Сообщение отправлено в чат {chat_id} | {topic_id}");
                }
                else
                {
                    setLogs($"Вы не состоите в группе {chat_id} | {topic_id}");
                }

                await Task.Delay(1 * 1000);
            }
        }

        private void openPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                openFileDialog.Title = "Выберите изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    pictureBoxImagePreview.Image = new Bitmap(selectedImagePath); // Отображение изображения
                }
            }
        }
    }
}
