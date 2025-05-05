using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Nodes;
using static teamsinvitesender.SmtpSettings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teamsinvitesender
{
    public partial class configMenu : Form
    {
        public configMenu()
        {
            InitializeComponent();
        }


        public void UpdateSmtpSettings(SmtpSettings newSettings)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            string json = File.ReadAllText(filePath);
            var root = JsonNode.Parse(json);

            // Ayarları güncelle
            root["SmtpSettings"]["Host"] = newSettings.Host;
            root["SmtpSettings"]["Port"] = newSettings.Port;
            root["SmtpSettings"]["Email"] = newSettings.Email;
            root["SmtpSettings"]["Password"] = newSettings.Password;

            // JSON'u yeniden yaz
            File.WriteAllText(filePath, root.ToJsonString(new JsonSerializerOptions { WriteIndented = true }));
        }
        private void configMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text.Trim();
            string portStr = txtPort.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(portStr) ||
               string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Tüm alanları doldurmalısınız!");
                return;
            }

            // Port sayıya çevrilmeli
            if (!int.TryParse(portStr, out int port))
            {
                MessageBox.Show("Port sayısal olmalı!");
                return;
            }

            // SmtpSettings nesnesine aktar
            var yeniAyar = new SmtpSettings
            {
                Host = host,
                Port = port,
                Email = email,
                Password = sifre
            };

            // JSON dosyasına yaz
            UpdateSmtpSettings(yeniAyar);
            MessageBox.Show("Ayarlar başarıyla kaydedildi!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string yeniMail = txtYeniMail.Text.Trim();
            if (string.IsNullOrEmpty(yeniMail)){
                MessageBox.Show("Mail Adresi Boş Olamaz!!!");
                return;
            }
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var ayar = JsonSerializer.Deserialize<AyarDosyasi>(json, options);
                if (ayar.GonderilecekMailler == null)
                    ayar.GonderilecekMailler = new List<string>();
                if (!ayar.GonderilecekMailler.Contains(yeniMail))
                {
                    ayar.GonderilecekMailler.Add(yeniMail);
                    string yeniJson = JsonSerializer.Serialize(ayar, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, yeniJson);

                    
                    MessageBox.Show("Mail başarıyla eklendi.");
                }
                else
                {
                    MessageBox.Show("Bu mail zaten listede var.");
                }
            }
        }
    }
}
