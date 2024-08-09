using System.Diagnostics;

namespace Cryptologist1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string Encrypt(string Message1, int ScrollAmount)
        {
            string Result = "";

            foreach (char Character1 in Message1)
            {
                if (char.IsLetter(Character1))
                {
                    char offset = char.IsUpper(Character1) ? 'A' : 'a';

                    char EncryptedCharacter = (char)(((Character1 + ScrollAmount - offset) % 26) + offset);

                    Result += EncryptedCharacter;
                }
                else
                {
                    Result += Character1;
                }
            }

            return Result;
        }

        static string Decrypt(string Message1, int ScrollAmount)
        {
            return Encrypt(Message1, 26 - ScrollAmount);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No text or number entered.","Error");
            }
            
            string Message1 = textBox1.Text;
            int ScrollAmount = int.Parse(textBox2.Text);
            string EncryptedMessage = Encrypt(Message1, ScrollAmount);
            richTextBox1.Text = EncryptedMessage;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No text or number entered.", "Error");
            }

            string Message1 = textBox1.Text;
            int ScrollAmount = int.Parse(textBox2.Text);
            string EncryptedMessage = Decrypt(Message1, ScrollAmount);
            richTextBox1.Text = EncryptedMessage;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.linkedin.com/in/feritbulut/",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/feritbulut",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.instagram.com/fertbult/",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
       
        private void richTextBox1_ContextMenuStripChanged(object sender, EventArgs e)
        {
            

        }
    }
}
