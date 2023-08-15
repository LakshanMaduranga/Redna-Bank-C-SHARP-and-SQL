
namespace REDNA_BANK
{
    partial class Email
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_attach = new Guna.UI2.WinForms.Guna2Button();
            this.file_location = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_send = new Guna.UI2.WinForms.Guna2Button();
            this.body = new Guna.UI2.WinForms.Guna2TextBox();
            this.subject = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.email_msg_ok = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.cc = new Guna.UI2.WinForms.Guna2TextBox();
            this.bcc = new Guna.UI2.WinForms.Guna2TextBox();
            this.email_msg_error = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.to = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.DragForm = false;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // btn_attach
            // 
            this.btn_attach.Animated = true;
            this.btn_attach.AutoRoundedCorners = true;
            this.btn_attach.BorderRadius = 21;
            this.btn_attach.CheckedState.Parent = this.btn_attach;
            this.btn_attach.CustomImages.Parent = this.btn_attach;
            this.btn_attach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_attach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_attach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_attach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_attach.DisabledState.Parent = this.btn_attach;
            this.btn_attach.FillColor = System.Drawing.Color.Silver;
            this.btn_attach.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btn_attach.ForeColor = System.Drawing.Color.White;
            this.btn_attach.HoverState.Parent = this.btn_attach;
            this.btn_attach.Image = global::REDNA_BANK.Properties.Resources.attach;
            this.btn_attach.Location = new System.Drawing.Point(377, 488);
            this.btn_attach.Name = "btn_attach";
            this.btn_attach.ShadowDecoration.Parent = this.btn_attach;
            this.btn_attach.Size = new System.Drawing.Size(180, 45);
            this.btn_attach.TabIndex = 38;
            this.btn_attach.Click += new System.EventHandler(this.btn_attach_Click);
            // 
            // file_location
            // 
            this.file_location.Animated = true;
            this.file_location.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.file_location.DefaultText = "";
            this.file_location.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.file_location.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.file_location.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.file_location.DisabledState.Parent = this.file_location;
            this.file_location.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.file_location.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.file_location.FocusedState.Parent = this.file_location;
            this.file_location.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.file_location.ForeColor = System.Drawing.Color.DimGray;
            this.file_location.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.file_location.HoverState.Parent = this.file_location;
            this.file_location.Location = new System.Drawing.Point(11, 488);
            this.file_location.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.file_location.Name = "file_location";
            this.file_location.PasswordChar = '\0';
            this.file_location.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.file_location.PlaceholderText = "";
            this.file_location.SelectedText = "";
            this.file_location.ShadowDecoration.Parent = this.file_location;
            this.file_location.Size = new System.Drawing.Size(354, 36);
            this.file_location.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.file_location.TabIndex = 37;
            this.file_location.Visible = false;
            // 
            // btn_send
            // 
            this.btn_send.Animated = true;
            this.btn_send.AutoRoundedCorners = true;
            this.btn_send.BorderRadius = 21;
            this.btn_send.CheckedState.Parent = this.btn_send;
            this.btn_send.CustomImages.Parent = this.btn_send;
            this.btn_send.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_send.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_send.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_send.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_send.DisabledState.Parent = this.btn_send;
            this.btn_send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_send.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.HoverState.Parent = this.btn_send;
            this.btn_send.Location = new System.Drawing.Point(563, 488);
            this.btn_send.Name = "btn_send";
            this.btn_send.ShadowDecoration.Parent = this.btn_send;
            this.btn_send.Size = new System.Drawing.Size(180, 45);
            this.btn_send.TabIndex = 36;
            this.btn_send.Text = "SEND";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // body
            // 
            this.body.Animated = true;
            this.body.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.body.DefaultText = "";
            this.body.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.body.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.body.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.body.DisabledState.Parent = this.body;
            this.body.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.body.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.body.FocusedState.Parent = this.body;
            this.body.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.body.ForeColor = System.Drawing.Color.DimGray;
            this.body.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.body.HoverState.Parent = this.body;
            this.body.Location = new System.Drawing.Point(11, 261);
            this.body.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.PasswordChar = '\0';
            this.body.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.body.PlaceholderText = "";
            this.body.SelectedText = "";
            this.body.ShadowDecoration.Parent = this.body;
            this.body.Size = new System.Drawing.Size(732, 215);
            this.body.TabIndex = 35;
            // 
            // subject
            // 
            this.subject.Animated = true;
            this.subject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subject.DefaultText = "";
            this.subject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.subject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.subject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subject.DisabledState.Parent = this.subject;
            this.subject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subject.FocusedState.Parent = this.subject;
            this.subject.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.subject.ForeColor = System.Drawing.Color.DimGray;
            this.subject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subject.HoverState.Parent = this.subject;
            this.subject.Location = new System.Drawing.Point(11, 215);
            this.subject.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.subject.Name = "subject";
            this.subject.PasswordChar = '\0';
            this.subject.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.subject.PlaceholderText = "Subject";
            this.subject.SelectedText = "";
            this.subject.ShadowDecoration.Parent = this.subject;
            this.subject.Size = new System.Drawing.Size(728, 36);
            this.subject.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.subject.TabIndex = 34;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(11, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(182, 31);
            this.guna2HtmlLabel1.TabIndex = 33;
            this.guna2HtmlLabel1.Text = "SEND E-MAILS";
            // 
            // email_msg_ok
            // 
            this.email_msg_ok.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.email_msg_ok.Caption = null;
            this.email_msg_ok.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.email_msg_ok.Parent = null;
            this.email_msg_ok.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.email_msg_ok.Text = null;
            // 
            // cc
            // 
            this.cc.Animated = true;
            this.cc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cc.DefaultText = "";
            this.cc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cc.DisabledState.Parent = this.cc;
            this.cc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cc.FocusedState.Parent = this.cc;
            this.cc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cc.ForeColor = System.Drawing.Color.DimGray;
            this.cc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cc.HoverState.Parent = this.cc;
            this.cc.Location = new System.Drawing.Point(11, 119);
            this.cc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cc.Name = "cc";
            this.cc.PasswordChar = '\0';
            this.cc.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cc.PlaceholderText = "CC";
            this.cc.SelectedText = "";
            this.cc.ShadowDecoration.Parent = this.cc;
            this.cc.Size = new System.Drawing.Size(307, 36);
            this.cc.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cc.TabIndex = 40;
            // 
            // bcc
            // 
            this.bcc.Animated = true;
            this.bcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bcc.DefaultText = "";
            this.bcc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bcc.DisabledState.Parent = this.bcc;
            this.bcc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bcc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bcc.FocusedState.Parent = this.bcc;
            this.bcc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bcc.ForeColor = System.Drawing.Color.DimGray;
            this.bcc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bcc.HoverState.Parent = this.bcc;
            this.bcc.Location = new System.Drawing.Point(11, 167);
            this.bcc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bcc.Name = "bcc";
            this.bcc.PasswordChar = '\0';
            this.bcc.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bcc.PlaceholderText = "BCC";
            this.bcc.SelectedText = "";
            this.bcc.ShadowDecoration.Parent = this.bcc;
            this.bcc.Size = new System.Drawing.Size(307, 36);
            this.bcc.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.bcc.TabIndex = 39;
            // 
            // email_msg_error
            // 
            this.email_msg_error.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.email_msg_error.Caption = null;
            this.email_msg_error.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.email_msg_error.Parent = null;
            this.email_msg_error.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.email_msg_error.Text = null;
            // 
            // to
            // 
            this.to.Animated = true;
            this.to.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.to.DefaultText = "";
            this.to.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.to.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.to.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.to.DisabledState.Parent = this.to;
            this.to.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.to.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.to.FocusedState.Parent = this.to;
            this.to.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.to.ForeColor = System.Drawing.Color.DimGray;
            this.to.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.to.HoverState.Parent = this.to;
            this.to.Location = new System.Drawing.Point(11, 71);
            this.to.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.to.Name = "to";
            this.to.PasswordChar = '\0';
            this.to.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.to.PlaceholderText = "TO";
            this.to.SelectedText = "";
            this.to.ShadowDecoration.Parent = this.to;
            this.to.Size = new System.Drawing.Size(307, 36);
            this.to.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.to.TabIndex = 41;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 545);
            this.Controls.Add(this.btn_attach);
            this.Controls.Add(this.file_location);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.body);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.bcc);
            this.Controls.Add(this.to);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Email";
            this.Text = "Email";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_attach;
        private Guna.UI2.WinForms.Guna2TextBox file_location;
        private Guna.UI2.WinForms.Guna2Button btn_send;
        private Guna.UI2.WinForms.Guna2TextBox body;
        private Guna.UI2.WinForms.Guna2TextBox subject;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox cc;
        private Guna.UI2.WinForms.Guna2TextBox bcc;
        private Guna.UI2.WinForms.Guna2TextBox to;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Guna.UI2.WinForms.Guna2MessageDialog email_msg_ok;
        private Guna.UI2.WinForms.Guna2MessageDialog email_msg_error;
    }
}