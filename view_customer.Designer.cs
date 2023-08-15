
namespace REDNA_BANK
{
    partial class view_customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.databaseerroor = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.exceptionmessageform = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.validationmsgbx = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_view = new Guna.UI2.WinForms.Guna2Button();
            this.datagridview_cus = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_no_nic = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdb_accno = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radb_nic = new Guna.UI2.WinForms.Guna2RadioButton();
            this.editheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_cus)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            // validationmsgbx
            // 
            this.validationmsgbx.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.validationmsgbx.Caption = null;
            this.validationmsgbx.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.validationmsgbx.Parent = null;
            this.validationmsgbx.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.validationmsgbx.Text = null;
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderRadius = 21;
            this.btn_clear.CheckedState.Parent = this.btn_clear;
            this.btn_clear.CustomImages.Parent = this.btn_clear;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.DisabledState.Parent = this.btn_clear;
            this.btn_clear.FillColor = System.Drawing.Color.Gray;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.Parent = this.btn_clear;
            this.btn_clear.Location = new System.Drawing.Point(955, 769);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(180, 45);
            this.btn_clear.TabIndex = 29;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_view
            // 
            this.btn_view.Animated = true;
            this.btn_view.AutoRoundedCorners = true;
            this.btn_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_view.BorderColor = System.Drawing.Color.Transparent;
            this.btn_view.BorderRadius = 21;
            this.btn_view.CheckedState.Parent = this.btn_view;
            this.btn_view.CustomImages.Parent = this.btn_view;
            this.btn_view.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_view.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_view.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_view.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_view.DisabledState.Parent = this.btn_view;
            this.btn_view.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_view.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_view.ForeColor = System.Drawing.Color.White;
            this.btn_view.HoverState.Parent = this.btn_view;
            this.btn_view.Location = new System.Drawing.Point(1158, 769);
            this.btn_view.Name = "btn_view";
            this.btn_view.ShadowDecoration.Parent = this.btn_view;
            this.btn_view.Size = new System.Drawing.Size(180, 45);
            this.btn_view.TabIndex = 28;
            this.btn_view.Text = "VIEW";
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // datagridview_cus
            // 
            this.datagridview_cus.AllowUserToAddRows = false;
            this.datagridview_cus.AllowUserToDeleteRows = false;
            this.datagridview_cus.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(194)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridview_cus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview_cus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_cus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_cus.BackgroundColor = System.Drawing.Color.White;
            this.datagridview_cus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_cus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview_cus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_cus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview_cus.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(194)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_cus.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview_cus.EnableHeadersVisualStyles = false;
            this.datagridview_cus.GridColor = System.Drawing.Color.White;
            this.datagridview_cus.Location = new System.Drawing.Point(67, 196);
            this.datagridview_cus.Name = "datagridview_cus";
            this.datagridview_cus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_cus.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview_cus.RowHeadersVisible = false;
            this.datagridview_cus.RowHeadersWidth = 51;
            this.datagridview_cus.RowTemplate.Height = 26;
            this.datagridview_cus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_cus.Size = new System.Drawing.Size(1338, 528);
            this.datagridview_cus.TabIndex = 27;
            this.datagridview_cus.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower;
            this.datagridview_cus.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(179)))));
            this.datagridview_cus.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_cus.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.datagridview_cus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(194)))), ((int)(((byte)(196)))));
            this.datagridview_cus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridview_cus.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_cus.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.datagridview_cus.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.datagridview_cus.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview_cus.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridview_cus.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridview_cus.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridview_cus.ThemeStyle.HeaderStyle.Height = 40;
            this.datagridview_cus.ThemeStyle.ReadOnly = false;
            this.datagridview_cus.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_cus.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview_cus.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_cus.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridview_cus.ThemeStyle.RowsStyle.Height = 26;
            this.datagridview_cus.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(194)))), ((int)(((byte)(196)))));
            this.datagridview_cus.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // txt_no_nic
            // 
            this.txt_no_nic.Animated = true;
            this.txt_no_nic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_no_nic.DefaultText = "";
            this.txt_no_nic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_no_nic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_no_nic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_no_nic.DisabledState.Parent = this.txt_no_nic;
            this.txt_no_nic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_no_nic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_no_nic.FocusedState.Parent = this.txt_no_nic;
            this.txt_no_nic.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_no_nic.ForeColor = System.Drawing.Color.DimGray;
            this.txt_no_nic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_no_nic.HoverState.Parent = this.txt_no_nic;
            this.txt_no_nic.Location = new System.Drawing.Point(420, 126);
            this.txt_no_nic.Margin = new System.Windows.Forms.Padding(4);
            this.txt_no_nic.Name = "txt_no_nic";
            this.txt_no_nic.PasswordChar = '\0';
            this.txt_no_nic.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_no_nic.PlaceholderText = "Type NIC Number or Account Number";
            this.txt_no_nic.SelectedText = "";
            this.txt_no_nic.ShadowDecoration.Parent = this.txt_no_nic;
            this.txt_no_nic.Size = new System.Drawing.Size(515, 41);
            this.txt_no_nic.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_no_nic.TabIndex = 26;
            // 
            // rdb_accno
            // 
            this.rdb_accno.AutoSize = true;
            this.rdb_accno.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdb_accno.CheckedState.BorderThickness = 0;
            this.rdb_accno.CheckedState.FillColor = System.Drawing.Color.Red;
            this.rdb_accno.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdb_accno.CheckedState.InnerOffset = -4;
            this.rdb_accno.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdb_accno.ForeColor = System.Drawing.Color.DimGray;
            this.rdb_accno.Location = new System.Drawing.Point(195, 140);
            this.rdb_accno.Name = "rdb_accno";
            this.rdb_accno.Size = new System.Drawing.Size(162, 27);
            this.rdb_accno.TabIndex = 25;
            this.rdb_accno.Text = "Account Number";
            this.rdb_accno.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdb_accno.UncheckedState.BorderThickness = 3;
            this.rdb_accno.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdb_accno.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radb_nic
            // 
            this.radb_nic.AutoSize = true;
            this.radb_nic.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radb_nic.CheckedState.BorderThickness = 0;
            this.radb_nic.CheckedState.FillColor = System.Drawing.Color.Red;
            this.radb_nic.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radb_nic.CheckedState.InnerOffset = -4;
            this.radb_nic.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.radb_nic.ForeColor = System.Drawing.Color.DimGray;
            this.radb_nic.Location = new System.Drawing.Point(67, 140);
            this.radb_nic.Name = "radb_nic";
            this.radb_nic.Size = new System.Drawing.Size(60, 27);
            this.radb_nic.TabIndex = 24;
            this.radb_nic.Text = "NIC";
            this.radb_nic.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radb_nic.UncheckedState.BorderThickness = 3;
            this.radb_nic.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radb_nic.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // editheaderlabel
            // 
            this.editheaderlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editheaderlabel.BackColor = System.Drawing.Color.Transparent;
            this.editheaderlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editheaderlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editheaderlabel.Location = new System.Drawing.Point(67, 50);
            this.editheaderlabel.Name = "editheaderlabel";
            this.editheaderlabel.Size = new System.Drawing.Size(322, 56);
            this.editheaderlabel.TabIndex = 23;
            this.editheaderlabel.Text = "VIEW CUSTOMER";
            // 
            // view_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 892);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.datagridview_cus);
            this.Controls.Add(this.txt_no_nic);
            this.Controls.Add(this.rdb_accno);
            this.Controls.Add(this.radb_nic);
            this.Controls.Add(this.editheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "view_customer";
            this.Text = "view_customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.view_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_cus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_view;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview_cus;
        private Guna.UI2.WinForms.Guna2TextBox txt_no_nic;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_accno;
        private Guna.UI2.WinForms.Guna2RadioButton radb_nic;
        private Guna.UI2.WinForms.Guna2HtmlLabel editheaderlabel;
        private Guna.UI2.WinForms.Guna2MessageDialog databaseerroor;
        private Guna.UI2.WinForms.Guna2MessageDialog exceptionmessageform;
        private Guna.UI2.WinForms.Guna2MessageDialog validationmsgbx;
    }
}