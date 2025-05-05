namespace teamsinvitesender
{
    partial class configMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configMenu));
            label1 = new Label();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            label2 = new Label();
            txtPort = new TextBox();
            label3 = new Label();
            txtHost = new TextBox();
            label4 = new Label();
            button1 = new Button();
            txtYeniMail = new TextBox();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Gönderici Mail Adresi";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(25, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(25, 90);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(251, 23);
            txtSifre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 72);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 2;
            label2.Text = "Gönderici Mail Şifresi";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(25, 196);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(251, 23);
            txtPort.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 178);
            label3.Name = "label3";
            label3.Size = new Size(162, 15);
            label3.TabIndex = 6;
            label3.Text = "Gönderici Mail Sunucu Portu:";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(25, 143);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(251, 23);
            txtHost.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 125);
            label4.Name = "label4";
            label4.Size = new Size(166, 15);
            label4.TabIndex = 4;
            label4.Text = "Gönderici Mail Sunucu Adresi:";
            // 
            // button1
            // 
            button1.Location = new Point(25, 225);
            button1.Name = "button1";
            button1.Size = new Size(251, 33);
            button1.TabIndex = 8;
            button1.Text = "Gönderici Mail Ayarlarını Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtYeniMail
            // 
            txtYeniMail.Location = new Point(320, 37);
            txtYeniMail.Name = "txtYeniMail";
            txtYeniMail.Size = new Size(251, 23);
            txtYeniMail.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 19);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 9;
            label5.Text = "Alıcı Mail Adresi:";
            // 
            // button2
            // 
            button2.Location = new Point(320, 66);
            button2.Name = "button2";
            button2.Size = new Size(251, 33);
            button2.TabIndex = 11;
            button2.Text = "Alıcı Mail Adresini Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // configMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 287);
            Controls.Add(button2);
            Controls.Add(txtYeniMail);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtPort);
            Controls.Add(label3);
            Controls.Add(txtHost);
            Controls.Add(label4);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "configMenu";
            Text = "Ayarlar";
            Load += configMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Label label2;
        private TextBox txtPort;
        private Label label3;
        private TextBox txtHost;
        private Label label4;
        private Button button1;
        private TextBox txtYeniMail;
        private Label label5;
        private Button button2;
    }
}