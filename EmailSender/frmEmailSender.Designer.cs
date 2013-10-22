using System;
using System.ComponentModel;

namespace EmailSender
{
    partial class frmEmailSender
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
            this.components = new System.ComponentModel.Container();
            this.lblEmailServer = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlFormat = new System.Windows.Forms.Panel();
            this.rbHtml = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.lblEmailFormat = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblSSL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSSLNo = new System.Windows.Forms.RadioButton();
            this.rbSSLYes = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.pnlFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmailServer
            // 
            this.lblEmailServer.AutoSize = true;
            this.lblEmailServer.Location = new System.Drawing.Point(24, 23);
            this.lblEmailServer.Name = "lblEmailServer";
            this.lblEmailServer.Size = new System.Drawing.Size(66, 13);
            this.lblEmailServer.TabIndex = 0;
            this.lblEmailServer.Text = "Email Server";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(100, 20);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(215, 20);
            this.txtServerName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbBody);
            this.groupBox1.Controls.Add(this.txtCC);
            this.groupBox1.Controls.Add(this.lblCC);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.pnlFormat);
            this.groupBox1.Controls.Add(this.lblEmailFormat);
            this.groupBox1.Controls.Add(this.lblBody);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.lblSubject);
            this.groupBox1.Controls.Add(this.txtTo);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Location = new System.Drawing.Point(27, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 507);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email Box";
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(28, 174);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(555, 282);
            this.rtbBody.TabIndex = 13;
            this.rtbBody.Text = "";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(86, 57);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(497, 20);
            this.txtCC.TabIndex = 9;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(25, 60);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(21, 13);
            this.lblCC.TabIndex = 22;
            this.lblCC.Text = "CC";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(508, 467);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pnlFormat
            // 
            this.pnlFormat.Controls.Add(this.rbHtml);
            this.pnlFormat.Controls.Add(this.rbText);
            this.pnlFormat.Location = new System.Drawing.Point(85, 113);
            this.pnlFormat.Name = "pnlFormat";
            this.pnlFormat.Size = new System.Drawing.Size(173, 22);
            this.pnlFormat.TabIndex = 21;
            // 
            // rbHtml
            // 
            this.rbHtml.AutoSize = true;
            this.rbHtml.Checked = true;
            this.rbHtml.Location = new System.Drawing.Point(1, 3);
            this.rbHtml.Name = "rbHtml";
            this.rbHtml.Size = new System.Drawing.Size(46, 17);
            this.rbHtml.TabIndex = 11;
            this.rbHtml.TabStop = true;
            this.rbHtml.Text = "Html";
            this.rbHtml.UseVisualStyleBackColor = true;
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(53, 3);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 17);
            this.rbText.TabIndex = 12;
            this.rbText.Text = "Text";
            this.rbText.UseVisualStyleBackColor = true;
            // 
            // lblEmailFormat
            // 
            this.lblEmailFormat.AutoSize = true;
            this.lblEmailFormat.Location = new System.Drawing.Point(25, 119);
            this.lblEmailFormat.Name = "lblEmailFormat";
            this.lblEmailFormat.Size = new System.Drawing.Size(39, 13);
            this.lblEmailFormat.TabIndex = 18;
            this.lblEmailFormat.Text = "Format";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(25, 147);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(31, 13);
            this.lblBody.TabIndex = 15;
            this.lblBody.Text = "Body";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(85, 85);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(498, 20);
            this.txtSubject.TabIndex = 10;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(25, 88);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 13;
            this.lblSubject.Tag = "t";
            this.lblSubject.Text = "Subject";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(85, 26);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(498, 20);
            this.txtTo.TabIndex = 8;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(25, 29);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 11;
            this.lblTo.Text = "To";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(341, 23);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 12;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(373, 20);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(54, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "25";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(24, 52);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(100, 49);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(215, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(341, 52);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(400, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // lblSSL
            // 
            this.lblSSL.AutoSize = true;
            this.lblSSL.Location = new System.Drawing.Point(451, 23);
            this.lblSSL.Name = "lblSSL";
            this.lblSSL.Size = new System.Drawing.Size(27, 13);
            this.lblSSL.TabIndex = 18;
            this.lblSSL.Text = "SSL";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSSLNo);
            this.panel1.Controls.Add(this.rbSSLYes);
            this.panel1.Location = new System.Drawing.Point(486, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 23);
            this.panel1.TabIndex = 19;
            // 
            // rbSSLNo
            // 
            this.rbSSLNo.AutoSize = true;
            this.rbSSLNo.Checked = true;
            this.rbSSLNo.Location = new System.Drawing.Point(50, 3);
            this.rbSSLNo.Name = "rbSSLNo";
            this.rbSSLNo.Size = new System.Drawing.Size(39, 17);
            this.rbSSLNo.TabIndex = 4;
            this.rbSSLNo.TabStop = true;
            this.rbSSLNo.Text = "No";
            this.rbSSLNo.UseVisualStyleBackColor = true;
            // 
            // rbSSLYes
            // 
            this.rbSSLYes.AutoSize = true;
            this.rbSSLYes.Location = new System.Drawing.Point(3, 3);
            this.rbSSLYes.Name = "rbSSLYes";
            this.rbSSLYes.Size = new System.Drawing.Size(43, 17);
            this.rbSSLYes.TabIndex = 3;
            this.rbSSLYes.Text = "Yes";
            this.rbSSLYes.UseVisualStyleBackColor = true;
            // 
            // frmEmailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSSL);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblEmailServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEmailSender";
            this.Text = "Email Sender";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlFormat.ResumeLayout(false);
            this.pnlFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailServer;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmailFormat;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlFormat;
        private System.Windows.Forms.RadioButton rbHtml;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbSSLYes;
        private System.Windows.Forms.Label lblSSL;
        private System.Windows.Forms.RadioButton rbSSLNo;
        private System.Windows.Forms.RichTextBox rtbBody;

    }
}

