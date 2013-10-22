using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace EmailSender
{
    public partial class frmEmailSender : Form
    {
        private const string CCAddressName = "txtCC";

        public frmEmailSender()
        {
            InitializeComponent();

            BindTextBoxValidating(this.Controls);
            BindTextBoxValidating(this.groupBox1.Controls);
            this.txtTo.GotFocus += new EventHandler(EmailAddressGotFocus);
            this.txtTo.LostFocus += new EventHandler(EmailAddressLostFocus);
            this.txtCC.GotFocus += new EventHandler(EmailAddressGotFocus);
            this.txtCC.LostFocus += new EventHandler(EmailAddressLostFocus);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                try
                {
                    SmtpClient client = new SmtpClient();
                    MailMessage mailMessage = new MailMessage();
                    
                    // Set sender server.
                    client.Host = txtServerName.Text.Trim();
                    client.Port = int.Parse(txtPort.Text.Trim());

                    // Set sender Credential
                    NetworkCredential credential = new NetworkCredential();
                    credential.UserName = txtUserName.Text.Trim();
                    credential.Password = txtPassword.Text.Trim();
                    client.Credentials = credential;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    
                    // SSL check
                    if (rbSSLYes.Checked)
                    {
                        client.EnableSsl = true;
                    }
                    else 
                    {
                        client.EnableSsl = false;
                    }

                    // Mail box setting.
                    mailMessage.From = new MailAddress(txtUserName.Text.Trim());

                    string addressTo = txtTo.Text.Trim();
                    if (!string.IsNullOrEmpty(addressTo))
                    {
                        string[] tos = addressTo.Split(';');
                        foreach (string toAddress in tos)
                        {
                            mailMessage.To.Add(toAddress.Trim());
                        }
                    }

                    string addressCC = txtCC.Text.Trim();
                    if (!string.IsNullOrEmpty(addressCC))
                    {
                        string[] ccs = addressCC.Split(';');
                        foreach (string cc in ccs)
                        {
                            mailMessage.CC.Add(cc.Trim());
                        }
                    }

                    mailMessage.Subject = txtSubject.Text.Trim();
                    mailMessage.Body = rtbBody.Text;
                    if (rbHtml.Checked)
                    {
                        mailMessage.IsBodyHtml = true;
                    }
                    else
                    {
                        mailMessage.IsBodyHtml = false;
                    }

                    mailMessage.SubjectEncoding = Encoding.UTF8;
                    mailMessage.BodyEncoding = Encoding.UTF8;

                    client.Send(mailMessage);
                    MessageBox.Show("Send email successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool isValid = true;
            if (textBox != null)
            {
                ValidateTextBoxRequired(textBox, ref isValid);
            }
        }

        private void EmailAddressGotFocus(object sender, EventArgs e) 
        {
            TextBox textBox = sender as TextBox;
            toolTip.SetToolTip(textBox, "Separate multiple email with semicolons.");
        }

        private void EmailAddressLostFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            toolTip.Hide(textBox);
        }

        private bool ValidateControls() 
        {
            bool isValid = ValidateControls(this.Controls);
            bool isValidGroupControls = ValidateControls(this.groupBox1.Controls);
            return isValid && isValidGroupControls;
        }

        private bool ValidateControls(Control.ControlCollection controls) 
        {
            bool isValid = true;

            foreach (Control c in controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    ValidateTextBoxRequired(textBox, ref isValid);
                }
            }

            return isValid;
        }

        private void ValidateTextBoxRequired(TextBox textBox, ref bool isValid) 
        {
            if (!textBox.Multiline && textBox.Name != CCAddressName)
            {
                if (string.IsNullOrEmpty(textBox.Text.Trim()))
                {
                    // Remove TextBox prefix 'txt'
                    string fieldName = textBox.Name.Substring(3);

                    errorProvider.SetError(textBox, fieldName + " is required.");
                    isValid = false;
                }
                else
                {
                    errorProvider.SetError(textBox, string.Empty);
                }
            }
        }

        private void BindTextBoxValidating(Control.ControlCollection controls) 
        {
            foreach (Control c in controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (!textBox.Multiline && textBox.Name != CCAddressName)
                    {
                        textBox.Validating += new CancelEventHandler(textBox_Validating);
                    }
                }
            }
        }
    }
}
