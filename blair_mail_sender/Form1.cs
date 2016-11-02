using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace blair_mail_sender
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, message.Text);
            SmtpClient client = new SmtpClient(smtp.Text);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(username.Text, password.Text);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Mail Sent!", "Success", MessageBoxButtons.OK);
        }

        private void form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Moccasin;
            message.BackColor = System.Drawing.Color.Ivory;

        }
    }
}
