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

        private void MainBtn_Click(object sender, EventArgs e) {
            mainBtn.Visible = false;
            if(GooseTalkCount < 5) {
                GooseTalkCount += 1;
                messageLabel.Text = $"the goose will annoy you now. click again for new msg";
                MessageBox.Show(MessageGenerator(), "the goose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                messageLabel.Text = "the goose has asked you a question! click button 2 send";
                mainBtn.Visible = false;
                sendBtn.Visible = true;
                inputBox.Visible = true;
            } else {
                MessageBox.Show(GoodbyeGenerator(), "the goose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                messageLabel.Text = "uh oh. looks like the goose got tired. let's wait for now...";
                waitBtn.Visible = true;
            }
        }

        private void SendBtn_Click(object sender, EventArgs e) {
            inputBox.Text = "";
            mainBtn.Visible = true;
            sendBtn.Visible = false;
            inputBox.Visible = false;
            MessageBox.Show(ResponseGenerator(), "the goose", MessageBoxButtons.OK, MessageBoxIcon.Information);
            messageLabel.Text = "the goose has stopped sadly. click again for new msg";
        }


        //$ $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ $
        //$ $$$" ... "$...  ...$" ... "$$$  ... "$$$ $
        //$ $$$u `"$$$$$$$  $$$  $$$$$  $$  $$$  $$$ $
        //$ $$$$$$uu "$$$$  $$$  $$$$$  $$  """ u$$$ $
        //$ $$$""$$$  $$$$  $$$u "$$$" u$$  $$$$$$$$ $
        //$ $$$$....,$$$$$..$$$$$....,$$$$..$$$$$$$$ $
        //$ $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ $
        //  Spoilers ahead! Only continue if you want 0_0


        private string MessageGenerator() {
            string[] messages = { "honk! how are you feeling right now?" };
            return messages[random.Next(messages.Length)];
        }

        private string ResponseGenerator() {
             // add responses here and remeber to add a $ at the begining
            string[] responses = { $"you feel like {inputBox.Text}? hm.", "that's great! see you laters", $"i've heard feeling like {inputBox.Text} is a sign of playing too much animal goosing :)", $"{inputBox.Text}? holy hjonk thats great!" }; 
            return responses[random.Next(responses.Length)];
        }
        
        private string GoodbyeGenerator() {
            // add goodbyes here
            string[] messages = { "sorry!! we've talked too much, see you later :)", "oh no! i don't know what to say now... help?", "i was gonna say something, but suddenly i forgot everything. who am i? uuuh", "mmmmpphhh!! mppphphphpp..." };
            return messages[random.Next(messages.Length)];
        }

        private void WaitBtn_Click(object sender, EventArgs e) {
            GooseTalkCount -= 1;
            messageLabel.Text = $"good work! wait {GooseTalkCount} more times.";
            if(GooseTalkCount == 0) {
                messageLabel.Text = "goose is no longer tired! let's talk to le goose now :)";
                waitBtn.Visible = false;
                mainBtn.Visible = true;
            }
        }
    }
}
