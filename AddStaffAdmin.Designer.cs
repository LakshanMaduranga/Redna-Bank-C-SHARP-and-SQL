
namespace REDNA_BANK
{
    partial class AddStaffAdmin
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
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.age = new Guna.UI2.WinForms.Guna2TextBox();
            this.dob_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.nic = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.t_no = new Guna.UI2.WinForms.Guna2TextBox();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.address = new Guna.UI2.WinForms.Guna2TextBox();
            this.name_with_i = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new Guna.UI2.WinForms.Guna2TextBox();
            this.type_selector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_add_staff = new Guna.UI2.WinForms.Guna2Button();
            this.fname = new Guna.UI2.WinForms.Guna2TextBox();
            this.error_msg_box = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.successful_msg_box = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(708, 350);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(99, 23);
            this.guna2HtmlLabel3.TabIndex = 46;
            this.guna2HtmlLabel3.Text = "Select Gender";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(61, 95);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(81, 23);
            this.guna2HtmlLabel2.TabIndex = 45;
            this.guna2HtmlLabel2.Text = "Select Type";
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gender.FocusedState.Parent = this.gender;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gender.HoverState.Parent = this.gender;
            this.gender.ItemHeight = 30;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.ItemsAppearance.Parent = this.gender;
            this.gender.Location = new System.Drawing.Point(708, 372);
            this.gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gender.Name = "gender";
            this.gender.ShadowDecoration.Parent = this.gender;
            this.gender.Size = new System.Drawing.Size(366, 36);
            this.gender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.gender.TabIndex = 44;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // age
            // 
            this.age.Animated = true;
            this.age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.age.DefaultText = "";
            this.age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age.DisabledState.Parent = this.age;
            this.age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.age.FocusedState.Parent = this.age;
            this.age.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.age.ForeColor = System.Drawing.Color.DimGray;
            this.age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.age.HoverState.Parent = this.age;
            this.age.Location = new System.Drawing.Point(708, 294);
            this.age.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.age.Name = "age";
            this.age.PasswordChar = '\0';
            this.age.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.age.PlaceholderText = "Age";
            this.age.SelectedText = "";
            this.age.ShadowDecoration.Parent = this.age;
            this.age.Size = new System.Drawing.Size(602, 44);
            this.age.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.age.TabIndex = 43;
            // 
            // dob_picker
            // 
            this.dob_picker.Animated = true;
            this.dob_picker.Checked = true;
            this.dob_picker.CheckedState.Parent = this.dob_picker;
            this.dob_picker.FillColor = System.Drawing.Color.White;
            this.dob_picker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dob_picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dob_picker.HoverState.Parent = this.dob_picker;
            this.dob_picker.Location = new System.Drawing.Point(61, 294);
            this.dob_picker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dob_picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dob_picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dob_picker.Name = "dob_picker";
            this.dob_picker.ShadowDecoration.Parent = this.dob_picker;
            this.dob_picker.Size = new System.Drawing.Size(550, 44);
            this.dob_picker.TabIndex = 42;
            this.dob_picker.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            this.dob_picker.ValueChanged += new System.EventHandler(this.dob_picker_ValueChanged);
            // 
            // nic
            // 
            this.nic.Animated = true;
            this.nic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nic.DefaultText = "";
            this.nic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nic.DisabledState.Parent = this.nic;
            this.nic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nic.FocusedState.Parent = this.nic;
            this.nic.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nic.ForeColor = System.Drawing.Color.DimGray;
            this.nic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nic.HoverState.Parent = this.nic;
            this.nic.Location = new System.Drawing.Point(61, 372);
            this.nic.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.nic.Name = "nic";
            this.nic.PasswordChar = '\0';
            this.nic.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nic.PlaceholderText = "NIC";
            this.nic.SelectedText = "";
            this.nic.ShadowDecoration.Parent = this.nic;
            this.nic.Size = new System.Drawing.Size(550, 44);
            this.nic.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.nic.TabIndex = 41;
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BorderRadius = 26;
            this.btn_clear.CheckedState.Parent = this.btn_clear;
            this.btn_clear.CustomImages.Parent = this.btn_clear;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.DisabledState.Parent = this.btn_clear;
            this.btn_clear.FillColor = System.Drawing.Color.Gray;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.Parent = this.btn_clear;
            this.btn_clear.Location = new System.Drawing.Point(708, 741);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(240, 55);
            this.btn_clear.TabIndex = 40;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(61, 33);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(375, 47);
            this.guna2HtmlLabel1.TabIndex = 39;
            this.guna2HtmlLabel1.Text = "ADD STAFF AND ADMIN";
            // 
            // password
            // 
            this.password.Animated = true;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.FocusedState.Parent = this.password;
            this.password.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.HoverState.Parent = this.password;
            this.password.Location = new System.Drawing.Point(708, 553);
            this.password.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.password.PlaceholderText = "Password";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(602, 44);
            this.password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.password.TabIndex = 38;
            // 
            // t_no
            // 
            this.t_no.Animated = true;
            this.t_no.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_no.DefaultText = "";
            this.t_no.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_no.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_no.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_no.DisabledState.Parent = this.t_no;
            this.t_no.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_no.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_no.FocusedState.Parent = this.t_no;
            this.t_no.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.t_no.ForeColor = System.Drawing.Color.DimGray;
            this.t_no.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_no.HoverState.Parent = this.t_no;
            this.t_no.Location = new System.Drawing.Point(708, 458);
            this.t_no.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.t_no.Name = "t_no";
            this.t_no.PasswordChar = '\0';
            this.t_no.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.t_no.PlaceholderText = "Telephone Number";
            this.t_no.SelectedText = "";
            this.t_no.ShadowDecoration.Parent = this.t_no;
            this.t_no.Size = new System.Drawing.Size(602, 44);
            this.t_no.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.t_no.TabIndex = 37;
            // 
            // email
            // 
            this.email.Animated = true;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.Parent = this.email;
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.FocusedState.Parent = this.email;
            this.email.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.email.ForeColor = System.Drawing.Color.DimGray;
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.HoverState.Parent = this.email;
            this.email.Location = new System.Drawing.Point(61, 553);
            this.email.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.email.PlaceholderText = "Email";
            this.email.SelectedText = "";
            this.email.ShadowDecoration.Parent = this.email;
            this.email.Size = new System.Drawing.Size(550, 44);
            this.email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.email.TabIndex = 36;
            // 
            // address
            // 
            this.address.Animated = true;
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.DefaultText = "";
            this.address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.address.DisabledState.Parent = this.address;
            this.address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.address.FocusedState.Parent = this.address;
            this.address.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.address.ForeColor = System.Drawing.Color.DimGray;
            this.address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.address.HoverState.Parent = this.address;
            this.address.Location = new System.Drawing.Point(61, 458);
            this.address.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.address.Name = "address";
            this.address.PasswordChar = '\0';
            this.address.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.address.PlaceholderText = "Address";
            this.address.SelectedText = "";
            this.address.ShadowDecoration.Parent = this.address;
            this.address.Size = new System.Drawing.Size(550, 44);
            this.address.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.address.TabIndex = 35;
            // 
            // name_with_i
            // 
            this.name_with_i.Animated = true;
            this.name_with_i.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_with_i.DefaultText = "";
            this.name_with_i.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_with_i.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_with_i.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_with_i.DisabledState.Parent = this.name_with_i;
            this.name_with_i.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_with_i.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_with_i.FocusedState.Parent = this.name_with_i;
            this.name_with_i.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.name_with_i.ForeColor = System.Drawing.Color.DimGray;
            this.name_with_i.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_with_i.HoverState.Parent = this.name_with_i;
            this.name_with_i.Location = new System.Drawing.Point(708, 204);
            this.name_with_i.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.name_with_i.Name = "name_with_i";
            this.name_with_i.PasswordChar = '\0';
            this.name_with_i.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.name_with_i.PlaceholderText = "Name With Initials";
            this.name_with_i.SelectedText = "";
            this.name_with_i.ShadowDecoration.Parent = this.name_with_i;
            this.name_with_i.Size = new System.Drawing.Size(602, 44);
            this.name_with_i.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.name_with_i.TabIndex = 34;
            // 
            // id
            // 
            this.id.Animated = true;
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.DefaultText = "";
            this.id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id.DisabledState.Parent = this.id;
            this.id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.FocusedState.Parent = this.id;
            this.id.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.id.ForeColor = System.Drawing.Color.DimGray;
            this.id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.HoverState.Parent = this.id;
            this.id.Location = new System.Drawing.Point(708, 119);
            this.id.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.id.Name = "id";
            this.id.PasswordChar = '\0';
            this.id.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.id.PlaceholderText = "User ID";
            this.id.ReadOnly = true;
            this.id.SelectedText = "";
            this.id.ShadowDecoration.Parent = this.id;
            this.id.Size = new System.Drawing.Size(602, 44);
            this.id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.id.TabIndex = 33;
            // 
            // type_selector
            // 
            this.type_selector.BackColor = System.Drawing.Color.Transparent;
            this.type_selector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.type_selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_selector.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.type_selector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.type_selector.FocusedState.Parent = this.type_selector;
            this.type_selector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.type_selector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.type_selector.HoverState.Parent = this.type_selector;
            this.type_selector.ItemHeight = 30;
            this.type_selector.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.type_selector.ItemsAppearance.Parent = this.type_selector;
            this.type_selector.Location = new System.Drawing.Point(61, 119);
            this.type_selector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.type_selector.Name = "type_selector";
            this.type_selector.ShadowDecoration.Parent = this.type_selector;
            this.type_selector.Size = new System.Drawing.Size(549, 36);
            this.type_selector.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.type_selector.TabIndex = 32;
            this.type_selector.SelectedIndexChanged += new System.EventHandler(this.type_selector_SelectedIndexChanged);
            // 
            // btn_add_staff
            // 
            this.btn_add_staff.Animated = true;
            this.btn_add_staff.AutoRoundedCorners = true;
            this.btn_add_staff.BorderRadius = 26;
            this.btn_add_staff.CheckedState.Parent = this.btn_add_staff;
            this.btn_add_staff.CustomImages.Parent = this.btn_add_staff;
            this.btn_add_staff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_staff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_staff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_staff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_staff.DisabledState.Parent = this.btn_add_staff;
            this.btn_add_staff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_add_staff.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btn_add_staff.ForeColor = System.Drawing.Color.White;
            this.btn_add_staff.HoverState.Parent = this.btn_add_staff;
            this.btn_add_staff.Location = new System.Drawing.Point(1003, 741);
            this.btn_add_staff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add_staff.Name = "btn_add_staff";
            this.btn_add_staff.ShadowDecoration.Parent = this.btn_add_staff;
            this.btn_add_staff.Size = new System.Drawing.Size(240, 55);
            this.btn_add_staff.TabIndex = 31;
            this.btn_add_staff.Text = "ADD";
            this.btn_add_staff.Click += new System.EventHandler(this.btn_add_staff_Click);
            // 
            // fname
            // 
            this.fname.Animated = true;
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.DefaultText = "";
            this.fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fname.DisabledState.Parent = this.fname;
            this.fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fname.FocusedState.Parent = this.fname;
            this.fname.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.fname.ForeColor = System.Drawing.Color.DimGray;
            this.fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fname.HoverState.Parent = this.fname;
            this.fname.Location = new System.Drawing.Point(61, 204);
            this.fname.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.fname.Name = "fname";
            this.fname.PasswordChar = '\0';
            this.fname.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fname.PlaceholderText = "Full Name";
            this.fname.SelectedText = "";
            this.fname.ShadowDecoration.Parent = this.fname;
            this.fname.Size = new System.Drawing.Size(550, 44);
            this.fname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.fname.TabIndex = 30;
            // 
            // error_msg_box
            // 
            this.error_msg_box.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.error_msg_box.Caption = null;
            this.error_msg_box.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.error_msg_box.Parent = null;
            this.error_msg_box.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.error_msg_box.Text = null;
            // 
            // successful_msg_box
            // 
            this.successful_msg_box.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.successful_msg_box.Caption = null;
            this.successful_msg_box.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.successful_msg_box.Parent = null;
            this.successful_msg_box.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.successful_msg_box.Text = null;
            // 
            // AddStaffAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 892);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.age);
            this.Controls.Add(this.dob_picker);
            this.Controls.Add(this.nic);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.t_no);
            this.Controls.Add(this.email);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name_with_i);
            this.Controls.Add(this.id);
            this.Controls.Add(this.type_selector);
            this.Controls.Add(this.btn_add_staff);
            this.Controls.Add(this.fname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddStaffAdmin";
            this.Text = "AddStaffAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddStaffAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox gender;
        private Guna.UI2.WinForms.Guna2TextBox age;
        private Guna.UI2.WinForms.Guna2DateTimePicker dob_picker;
        private Guna.UI2.WinForms.Guna2TextBox nic;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox t_no;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2TextBox address;
        private Guna.UI2.WinForms.Guna2TextBox name_with_i;
        private Guna.UI2.WinForms.Guna2TextBox id;
        private Guna.UI2.WinForms.Guna2ComboBox type_selector;
        private Guna.UI2.WinForms.Guna2Button btn_add_staff;
        private Guna.UI2.WinForms.Guna2TextBox fname;
        private Guna.UI2.WinForms.Guna2MessageDialog error_msg_box;
        private Guna.UI2.WinForms.Guna2MessageDialog successful_msg_box;
    }
}