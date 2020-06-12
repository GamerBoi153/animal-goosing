using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goosesimulatotr {
    public partial class Form1 : Form {

        public int GooseTalkCount = 0;
        Random random = new Random();
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(GooseTalkCount < 5) {
                GooseTalkCount = GooseTalkCount + 1;
                messageLabel.Text = $"the goose will annoy you now. click again for new msg";
                MessageBox.Show(messageGenerator(), "the goose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                messageLabel.Text = "the goose has asked you a question! click button 2 send";
                mainBtn.Visible = false;
                sendBtn.Visible = true;
                inputBox.Visible = true;
            } else {
                MessageBox.Show(goodbyeGenerator(), "the goose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("A critical error has occurred. animal goosing will now exit.\nERR_GOOSE_BROKE", "animal goosing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void sendBtn_Click(object sender, EventArgs e) {
            mainBtn.Visible = true;
            sendBtn.Visible = false;
            inputBox.Visible = false;
            MessageBox.Show(responseGenerator(), "the goose", MessageBoxButtons.OK, MessageBoxIcon.Information);
            messageLabel.Text = "the goose has stopped sadly. click again for new msg";
        }

        private string messageGenerator() {
            string[] messages = { "honk! how are you feeling right now?" };
            return messages[random.Next(messages.Length)];
        }

        private string responseGenerator() {
            string[] responses = { $"you feel like {inputBox.Text}? hm.", "that's great! see you laters", $"i've heard feeling like {inputBox.Text} is a sign of playing too much animal goosing" };
            return responses[random.Next(responses.Length)];
        }

        private string goodbyeGenerator() {
            string[] messages = { "sorry!! we've talked too much, see you later :)", "oh no! i don't know what to say now... help?", "i was gonna say something, but suddenly i forgot everything. who am i? uuuh", "mmmmpphhh!! mppphphphpp..." };
            return messages[random.Next(messages.Length)];
        }
    }
}
