using System.IO;
using System.Text.Json;
using System.Net;
using System.Net.Mail;

namespace teamsinvitesender
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            configMenu config = new configMenu();
            config.Show();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var ayar = JsonSerializer.Deserialize<AyarDosyasi>(json, options);
                if (ayar != null && ayar.SmtpSettings != null)
                {
                    comboBox1.Items.Add(ayar.SmtpSettings.Email);
                }
                if (ayar != null && ayar.GonderilecekMailler != null)
                {
                    foreach (var mail in ayar.GonderilecekMailler)
                    {
                        comboBox2.Items.Add(mail);
                    }
                }
                else
                {
                    MessageBox.Show("GonderilecekMailler listesi JSON'da tan�ml� de�il veya bo�.");
                }
            }
            else
            {
                MessageBox.Show("Config Dosyas� Bulunamad�!!");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("L�tfen hem g�nderen hem al�c� mail adresini se�in.");
                return;
            }
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            if (!File.Exists(filePath))
            {
                MessageBox.Show("appsettings.json bulunamad�.");
                return;
            }
            string json = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var ayar = JsonSerializer.Deserialize<AyarDosyasi>(json, options);

            if (ayar == null || ayar.SmtpSettings == null)
            {
                MessageBox.Show("SMTP ayarlar� bulunamad�.");
                return;
            }
           
            string aliciMail = comboBox2.SelectedItem.ToString();
            string mesajIcerigi = richTextBox1.Text;
            try
            {
                var smtp = new SmtpClient
                {
                    Host = ayar.SmtpSettings.Host,
                    Port = ayar.SmtpSettings.Port,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(ayar.SmtpSettings.Email, ayar.SmtpSettings.Password)
                };

                var mail = new MailMessage
                {
                    From = new MailAddress(ayar.SmtpSettings.Email),
                    Subject = "Toplant� Linki",
                    Body = mesajIcerigi,
                    IsBodyHtml = false
                };

                mail.To.Add(aliciMail);
                smtp.Send(mail);

                MessageBox.Show("Mail ba�ar�yla g�nderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olu�tu: " + ex.Message);
            }
        }
    }
}
