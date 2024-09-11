namespace UserBotSender
{
    partial class UserBotSender
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            apiIdTextBot = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            apiHashTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            numberTextBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            twoFATextBox = new System.Windows.Forms.TextBox();
            send_code = new System.Windows.Forms.Button();
            htmlFormatedMessage = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            webBrowserPreview = new System.Windows.Forms.WebBrowser();
            label8 = new System.Windows.Forms.Label();
            groupsTextBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            outputTextBox = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            userDataLabel = new System.Windows.Forms.Label();
            avatarImageBox = new System.Windows.Forms.PictureBox();
            start_send = new System.Windows.Forms.Button();
            label13 = new System.Windows.Forms.Label();
            chatsTextBox = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            openPhoto = new System.Windows.Forms.Button();
            pictureBoxImagePreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)avatarImageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagePreview).BeginInit();
            SuspendLayout();
            // 
            // apiIdTextBot
            // 
            apiIdTextBot.Location = new System.Drawing.Point(14, 65);
            apiIdTextBot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            apiIdTextBot.Name = "apiIdTextBot";
            apiIdTextBot.Size = new System.Drawing.Size(284, 23);
            apiIdTextBot.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(14, 44);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "API ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(14, 91);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "API HASH";
            // 
            // apiHashTextBox
            // 
            apiHashTextBox.Location = new System.Drawing.Point(14, 112);
            apiHashTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            apiHashTextBox.Name = "apiHashTextBox";
            apiHashTextBox.Size = new System.Drawing.Size(284, 23);
            apiHashTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(14, 138);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 15);
            label3.TabIndex = 6;
            label3.Text = "Номер(+1202...)";
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new System.Drawing.Point(14, 159);
            numberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new System.Drawing.Size(284, 23);
            numberTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(10, 186);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 15);
            label5.TabIndex = 10;
            label5.Text = "2FA пароль";
            // 
            // twoFATextBox
            // 
            twoFATextBox.Location = new System.Drawing.Point(10, 207);
            twoFATextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            twoFATextBox.Name = "twoFATextBox";
            twoFATextBox.Size = new System.Drawing.Size(284, 23);
            twoFATextBox.TabIndex = 9;
            // 
            // send_code
            // 
            send_code.BackColor = System.Drawing.SystemColors.Highlight;
            send_code.ForeColor = System.Drawing.Color.WhiteSmoke;
            send_code.Location = new System.Drawing.Point(10, 237);
            send_code.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            send_code.Name = "send_code";
            send_code.Size = new System.Drawing.Size(288, 27);
            send_code.TabIndex = 11;
            send_code.Text = "Войти";
            send_code.UseVisualStyleBackColor = false;
            send_code.Click += send_code_Click;
            // 
            // htmlFormatedMessage
            // 
            htmlFormatedMessage.Location = new System.Drawing.Point(322, 65);
            htmlFormatedMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            htmlFormatedMessage.Multiline = true;
            htmlFormatedMessage.Name = "htmlFormatedMessage";
            htmlFormatedMessage.Size = new System.Drawing.Size(284, 277);
            htmlFormatedMessage.TabIndex = 12;
            htmlFormatedMessage.TextChanged += SpamMessage_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label4.ForeColor = System.Drawing.SystemColors.Highlight;
            label4.Location = new System.Drawing.Point(14, 10);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(190, 21);
            label4.TabIndex = 13;
            label4.Text = "Регистрация аккаунта";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label6.ForeColor = System.Drawing.SystemColors.Highlight;
            label6.Location = new System.Drawing.Point(318, 10);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(208, 21);
            label6.TabIndex = 14;
            label6.Text = "Сообщение для рассылки";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(321, 47);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(61, 15);
            label7.TabIndex = 16;
            label7.Text = "Сообщение";
            // 
            // webBrowserPreview
            // 
            webBrowserPreview.Location = new System.Drawing.Point(322, 375);
            webBrowserPreview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            webBrowserPreview.MinimumSize = new System.Drawing.Size(23, 23);
            webBrowserPreview.Name = "webBrowserPreview";
            webBrowserPreview.Size = new System.Drawing.Size(285, 194);
            webBrowserPreview.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label8.ForeColor = System.Drawing.SystemColors.Highlight;
            label8.Location = new System.Drawing.Point(624, 10);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(181, 21);
            label8.TabIndex = 18;
            label8.Text = "Группы/Каналы/Лички";
            // 
            // groupsTextBox
            // 
            groupsTextBox.Location = new System.Drawing.Point(629, 65);
            groupsTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupsTextBox.Multiline = true;
            groupsTextBox.Name = "groupsTextBox";
            groupsTextBox.Size = new System.Drawing.Size(284, 778);
            groupsTextBox.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label9.ForeColor = System.Drawing.SystemColors.Highlight;
            label9.Location = new System.Drawing.Point(929, 10);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(55, 21);
            label9.TabIndex = 20;
            label9.Text = "Вывод";
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new System.Drawing.Point(933, 65);
            outputTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.Size = new System.Drawing.Size(422, 811);
            outputTextBox.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(318, 357);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(157, 15);
            label10.TabIndex = 22;
            label10.Text = "Форматированное сообщение";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(629, 47);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(187, 15);
            label11.TabIndex = 23;
            label11.Text = "Через абзац ID|topic_if_needed";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.Location = new System.Drawing.Point(933, 47);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(31, 15);
            label12.TabIndex = 24;
            label12.Text = "Логи";
            // 
            // userDataLabel
            // 
            userDataLabel.AutoSize = true;
            userDataLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            userDataLabel.Location = new System.Drawing.Point(12, 278);
            userDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userDataLabel.Name = "userDataLabel";
            userDataLabel.Size = new System.Drawing.Size(0, 11);
            userDataLabel.TabIndex = 25;
            // 
            // avatarImageBox
            // 
            avatarImageBox.Location = new System.Drawing.Point(9, 615);
            avatarImageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            avatarImageBox.Name = "avatarImageBox";
            avatarImageBox.Size = new System.Drawing.Size(285, 261);
            avatarImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            avatarImageBox.TabIndex = 26;
            avatarImageBox.TabStop = false;
            // 
            // start_send
            // 
            start_send.BackColor = System.Drawing.SystemColors.Highlight;
            start_send.Enabled = false;
            start_send.ForeColor = System.Drawing.Color.WhiteSmoke;
            start_send.Location = new System.Drawing.Point(624, 849);
            start_send.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            start_send.Name = "start_send";
            start_send.Size = new System.Drawing.Size(289, 27);
            start_send.TabIndex = 27;
            start_send.Text = "Начать";
            start_send.UseVisualStyleBackColor = false;
            start_send.Click += start_send_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label13.ForeColor = System.Drawing.SystemColors.Highlight;
            label13.Location = new System.Drawing.Point(1372, 10);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(82, 21);
            label13.TabIndex = 28;
            label13.Text = "Мои чаты";
            // 
            // chatsTextBox
            // 
            chatsTextBox.Location = new System.Drawing.Point(1373, 68);
            chatsTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chatsTextBox.Multiline = true;
            chatsTextBox.Name = "chatsTextBox";
            chatsTextBox.ReadOnly = true;
            chatsTextBox.Size = new System.Drawing.Size(325, 808);
            chatsTextBox.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label14.Location = new System.Drawing.Point(1373, 50);
            label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(31, 15);
            label14.TabIndex = 30;
            label14.Text = "Чаты";
            // 
            // openPhoto
            // 
            openPhoto.BackColor = System.Drawing.SystemColors.Highlight;
            openPhoto.Enabled = false;
            openPhoto.ForeColor = System.Drawing.Color.WhiteSmoke;
            openPhoto.Location = new System.Drawing.Point(321, 582);
            openPhoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            openPhoto.Name = "openPhoto";
            openPhoto.Size = new System.Drawing.Size(286, 27);
            openPhoto.TabIndex = 31;
            openPhoto.Text = "Выбрать фото";
            openPhoto.UseVisualStyleBackColor = false;
            openPhoto.Click += openPhoto_Click;
            // 
            // pictureBoxImagePreview
            // 
            pictureBoxImagePreview.Location = new System.Drawing.Point(321, 615);
            pictureBoxImagePreview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBoxImagePreview.Name = "pictureBoxImagePreview";
            pictureBoxImagePreview.Size = new System.Drawing.Size(285, 261);
            pictureBoxImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxImagePreview.TabIndex = 32;
            pictureBoxImagePreview.TabStop = false;
            // 
            // UserBotSender
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1729, 888);
            Controls.Add(pictureBoxImagePreview);
            Controls.Add(openPhoto);
            Controls.Add(label14);
            Controls.Add(chatsTextBox);
            Controls.Add(label13);
            Controls.Add(start_send);
            Controls.Add(avatarImageBox);
            Controls.Add(userDataLabel);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(outputTextBox);
            Controls.Add(label9);
            Controls.Add(groupsTextBox);
            Controls.Add(label8);
            Controls.Add(webBrowserPreview);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(htmlFormatedMessage);
            Controls.Add(send_code);
            Controls.Add(label5);
            Controls.Add(twoFATextBox);
            Controls.Add(label3);
            Controls.Add(numberTextBox);
            Controls.Add(label2);
            Controls.Add(apiHashTextBox);
            Controls.Add(label1);
            Controls.Add(apiIdTextBot);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "UserBotSender";
            Text = "UserSpamSender";
            ((System.ComponentModel.ISupportInitialize)avatarImageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagePreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox apiIdTextBot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apiHashTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox twoFATextBox;
        private System.Windows.Forms.Button send_code;
        private System.Windows.Forms.TextBox htmlFormatedMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.WebBrowser webBrowserPreview;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox groupsTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label userDataLabel;
        private System.Windows.Forms.PictureBox avatarImageBox;
        private System.Windows.Forms.Button start_send;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox chatsTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button openPhoto;
        private System.Windows.Forms.PictureBox pictureBoxImagePreview;
    }
}

