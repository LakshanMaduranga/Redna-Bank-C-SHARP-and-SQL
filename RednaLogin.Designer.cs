
namespace REDNA_BANK
{
    partial class RednaLogin
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
            this.btn_minimize = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.r_admin = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.databaseerroor = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.exceptionmessageform = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.r_staff = new Guna.UI2.WinForms.Guna2RadioButton();
            this.incorrect = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.selecttypeerror = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
            // btn_minimize
            // 
            this.btn_minimize.Animated = true;
            this.btn_minimize.AutoRoundedCorners = true;
            this.btn_minimize.BorderRadius = 21;
            this.btn_minimize.CheckedState.Parent = this.btn_minimize;
            this.btn_minimize.CustomImages.Parent = this.btn_minimize;
            this.btn_minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minimize.DisabledState.Parent = this.btn_minimize;
            this.btn_minimize.FillColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.HoverState.Parent = this.btn_minimize;
            this.btn_minimize.Image = global::REDNA_BANK.Properties.Resources.minimize;
            this.btn_minimize.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_minimize.Location = new System.Drawing.Point(1443, 12);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.ShadowDecoration.Parent = this.btn_minimize;
            this.btn_minimize.Size = new System.Drawing.Size(45, 46);
            this.btn_minimize.TabIndex = 27;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Animated = true;
            this.btn_close.AutoRoundedCorners = true;
            this.btn_close.BorderRadius = 21;
            this.btn_close.CheckedState.Parent = this.btn_close;
            this.btn_close.CustomImages.Parent = this.btn_close;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.DisabledState.Parent = this.btn_close;
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.Image = global::REDNA_BANK.Properties.Resources.shutdown_26px;
            this.btn_close.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_close.Location = new System.Drawing.Point(1493, 12);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(45, 46);
            this.btn_close.TabIndex = 26;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(1227, 121);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(127, 43);
            this.guna2HtmlLabel1.TabIndex = 25;
            this.guna2HtmlLabel1.Text = "Together";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(1153, 162);
            this.label.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(306, 56);
            this.label.TabIndex = 24;
            this.label.Text = " We Are Stronger";
            // 
            // r_admin
            // 
            this.r_admin.AutoSize = true;
            this.r_admin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.r_admin.CheckedState.BorderThickness = 0;
            this.r_admin.CheckedState.FillColor = System.Drawing.Color.Red;
            this.r_admin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.r_admin.CheckedState.InnerOffset = -4;
            this.r_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.r_admin.ForeColor = System.Drawing.Color.DimGray;
            this.r_admin.Location = new System.Drawing.Point(1175, 507);
            this.r_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.r_admin.Name = "r_admin";
            this.r_admin.Size = new System.Drawing.Size(89, 29);
            this.r_admin.TabIndex = 23;
            this.r_admin.Text = "Admin";
            this.r_admin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.r_admin.UncheckedState.BorderThickness = 3;
            this.r_admin.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.r_admin.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btn_login
            // 
            this.btn_login.Animated = true;
            this.btn_login.AutoRoundedCorners = true;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BorderRadius = 25;
            this.btn_login.CheckedState.Parent = this.btn_login;
            this.btn_login.CustomImages.Parent = this.btn_login;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.DisabledState.Parent = this.btn_login;
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.HoverState.Parent = this.btn_login;
            this.btn_login.Location = new System.Drawing.Point(1085, 578);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.ShadowDecoration.Parent = this.btn_login;
            this.btn_login.Size = new System.Drawing.Size(389, 52);
            this.btn_login.TabIndex = 22;
            this.btn_login.Text = "LOGIN";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Animated = true;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.Parent = this.txt_password;
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.FocusedState.Parent = this.txt_password;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txt_password.ForeColor = System.Drawing.Color.DimGray;
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.HoverState.Parent = this.txt_password;
            this.txt_password.Location = new System.Drawing.Point(1085, 406);
            this.txt_password.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '◾';
            this.txt_password.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.SelectedText = "";
            this.txt_password.ShadowDecoration.Parent = this.txt_password;
            this.txt_password.Size = new System.Drawing.Size(389, 50);
            this.txt_password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_password.TabIndex = 21;
            // 
            // txt_ID
            // 
            this.txt_ID.Animated = true;
            this.txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID.DefaultText = "";
            this.txt_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID.DisabledState.Parent = this.txt_ID;
            this.txt_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID.FocusedState.Parent = this.txt_ID;
            this.txt_ID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID.HoverState.Parent = this.txt_ID;
            this.txt_ID.Location = new System.Drawing.Point(1085, 303);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PasswordChar = '\0';
            this.txt_ID.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_ID.PlaceholderText = "User ID";
            this.txt_ID.SelectedText = "";
            this.txt_ID.ShadowDecoration.Parent = this.txt_ID;
            this.txt_ID.Size = new System.Drawing.Size(389, 50);
            this.txt_ID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_ID.TabIndex = 20;
            // 
            // databaseerroor
            // 
            this.databaseerroor.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.databaseerroor.Caption = null;
            this.databaseerroor.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.databaseerroor.Parent = null;
            this.databaseerroor.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.databaseerroor.Text = null;
            // 
            // exceptionmessageform
            // 
            this.exceptionmessageform.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.exceptionmessageform.Caption = null;
            this.exceptionmessageform.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.exceptionmessageform.Parent = null;
            this.exceptionmessageform.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.exceptionmessageform.Text = null;
            // 
            // r_staff
            // 
            this.r_staff.AutoSize = true;
            this.r_staff.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.r_staff.CheckedState.BorderThickness = 0;
            this.r_staff.CheckedState.FillColor = System.Drawing.Color.Red;
            this.r_staff.CheckedState.InnerColor = System.Drawing.Color.White;
            this.r_staff.CheckedState.InnerOffset = -4;
            this.r_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.r_staff.ForeColor = System.Drawing.Color.DimGray;
            this.r_staff.Location = new System.Drawing.Point(1299, 507);
            this.r_staff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.r_staff.Name = "r_staff";
            this.r_staff.Size = new System.Drawing.Size(73, 29);
            this.r_staff.TabIndex = 28;
            this.r_staff.Text = "Staff";
            this.r_staff.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.r_staff.UncheckedState.BorderThickness = 3;
            this.r_staff.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.r_staff.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // incorrect
            // 
            this.incorrect.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.incorrect.Caption = null;
            this.incorrect.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.incorrect.Parent = null;
            this.incorrect.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.incorrect.Text = null;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::REDNA_BANK.Properties.Resources.Login_Graphic;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(997, 870);
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            // 
            // selecttypeerror
            // 
            this.selecttypeerror.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.selecttypeerror.Caption = null;
            this.selecttypeerror.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.selecttypeerror.Parent = null;
            this.selecttypeerror.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.selecttypeerror.Text = null;
            // 
            // RednaLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1550, 870);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.r_admin);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.r_staff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RednaLogin";
            this.Text = "RednaLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RednaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_minimize;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel label;
        private Guna.UI2.WinForms.Guna2RadioButton r_admin;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_ID;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2RadioButton r_staff;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Guna.UI2.WinForms.Guna2MessageDialog databaseerroor;
        private Guna.UI2.WinForms.Guna2MessageDialog exceptionmessageform;
        private Guna.UI2.WinForms.Guna2MessageDialog incorrect;
        private Guna.UI2.WinForms.Guna2MessageDialog selecttypeerror;
    }
}