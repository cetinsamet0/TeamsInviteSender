namespace teamsinvitesender
{
    partial class mainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Microsoft_Teams_Emblem;
            pictureBox1.Location = new Point(21, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 98);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 2;
            label1.Text = "Gönderen Mail Adresi:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 23);
            comboBox1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 159);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(210, 125);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 141);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 5;
            label2.Text = "Teams Linki:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(261, 115);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(217, 23);
            comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 97);
            label3.Name = "label3";
            label3.Size = new Size(141, 15);
            label3.TabIndex = 8;
            label3.Text = "Gönderilecek Mail Adresi:";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_send_96;
            button1.Location = new Point(261, 159);
            button1.Name = "button1";
            button1.Size = new Size(217, 125);
            button1.TabIndex = 9;
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.settingicon;
            pictureBox2.Location = new Point(416, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(492, 305);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "mainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeamsInviteSender";
            Load += mainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox2;
    }
}
