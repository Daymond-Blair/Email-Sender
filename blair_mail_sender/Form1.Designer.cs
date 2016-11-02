namespace blair_mail_sender
{
    partial class form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.smtp = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(133, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(36, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "From :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "To :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Smtp Server :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Subject :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Message :";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(175, 24);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(148, 20);
            this.from.TabIndex = 8;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(495, 21);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(132, 20);
            this.username.TabIndex = 9;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(175, 81);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(148, 20);
            this.to.TabIndex = 10;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(495, 74);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(132, 20);
            this.password.TabIndex = 11;
            this.password.UseSystemPasswordChar = true;
            // 
            // smtp
            // 
            this.smtp.Location = new System.Drawing.Point(196, 140);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(127, 20);
            this.smtp.TabIndex = 12;
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(495, 137);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(132, 20);
            this.subject.TabIndex = 13;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(128, 280);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(499, 176);
            this.message.TabIndex = 14;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 497);
            this.Controls.Add(this.message);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.smtp);
            this.Controls.Add(this.password);
            this.Controls.Add(this.to);
            this.Controls.Add(this.username);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.button1);
            this.Name = "form1";
            this.Text = "SimpleMail";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox smtp;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox message;
    }
}

