
namespace REDNA_BANK
{
    partial class Logs
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.StaffLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logreports = new REDNA_BANK.logreports();
            this.AdminLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.editheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.validationmsgbx = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.staffrt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.adminrt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StaffLogsTableAdapter = new REDNA_BANK.logreportsTableAdapters.StaffLogsTableAdapter();
            this.AdminLogsTableAdapter = new REDNA_BANK.logreportsTableAdapters.AdminLogsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StaffLogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logreports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffLogsBindingSource
            // 
            this.StaffLogsBindingSource.DataMember = "StaffLogs";
            this.StaffLogsBindingSource.DataSource = this.logreports;
            // 
            // logreports
            // 
            this.logreports.DataSetName = "logreports";
            this.logreports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdminLogsBindingSource
            // 
            this.AdminLogsBindingSource.DataMember = "AdminLogs";
            this.AdminLogsBindingSource.DataSource = this.logreports;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderRadius = 19;
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
            this.btn_clear.Location = new System.Drawing.Point(1190, 132);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(170, 40);
            this.btn_clear.TabIndex = 22;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Animated = true;
            this.btn_search.AutoRoundedCorners = true;
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BorderColor = System.Drawing.Color.Transparent;
            this.btn_search.BorderRadius = 19;
            this.btn_search.CheckedState.Parent = this.btn_search;
            this.btn_search.CustomImages.Parent = this.btn_search;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.DisabledState.Parent = this.btn_search;
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.HoverState.Parent = this.btn_search;
            this.btn_search.Location = new System.Drawing.Point(990, 132);
            this.btn_search.Name = "btn_search";
            this.btn_search.ShadowDecoration.Parent = this.btn_search;
            this.btn_search.Size = new System.Drawing.Size(170, 40);
            this.btn_search.TabIndex = 21;
            this.btn_search.Text = "SEARCH";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(47, 101);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(89, 25);
            this.guna2HtmlLabel1.TabIndex = 20;
            this.guna2HtmlLabel1.Text = "Select Type     \r\n";
            // 
            // editheaderlabel
            // 
            this.editheaderlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editheaderlabel.BackColor = System.Drawing.Color.Transparent;
            this.editheaderlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editheaderlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editheaderlabel.Location = new System.Drawing.Point(47, 27);
            this.editheaderlabel.Name = "editheaderlabel";
            this.editheaderlabel.Size = new System.Drawing.Size(579, 56);
            this.editheaderlabel.TabIndex = 19;
            this.editheaderlabel.Text = "VIEW STAFF AND ADMIN LOGS\r\n";
            // 
            // cmbtype
            // 
            this.cmbtype.BackColor = System.Drawing.Color.Transparent;
            this.cmbtype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmbtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbtype.FocusedState.Parent = this.cmbtype;
            this.cmbtype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbtype.ForeColor = System.Drawing.Color.DimGray;
            this.cmbtype.HoverState.Parent = this.cmbtype;
            this.cmbtype.ItemHeight = 30;
            this.cmbtype.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmbtype.ItemsAppearance.Parent = this.cmbtype;
            this.cmbtype.Location = new System.Drawing.Point(47, 132);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.ShadowDecoration.Parent = this.cmbtype;
            this.cmbtype.Size = new System.Drawing.Size(214, 36);
            this.cmbtype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbtype.TabIndex = 18;
            this.cmbtype.SelectedIndexChanged += new System.EventHandler(this.cmbtype_SelectedIndexChanged);
            // 
            // txt_id
            // 
            this.txt_id.Animated = true;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.Parent = this.txt_id;
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.FocusedState.Parent = this.txt_id;
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_id.ForeColor = System.Drawing.Color.DimGray;
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.HoverState.Parent = this.txt_id;
            this.txt_id.Location = new System.Drawing.Point(293, 128);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_id.PlaceholderText = "Type \r\n(Admin ID - ADMINXXX  |  Staff ID- STXXX)";
            this.txt_id.SelectedText = "";
            this.txt_id.ShadowDecoration.Parent = this.txt_id;
            this.txt_id.Size = new System.Drawing.Size(645, 47);
            this.txt_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_id.TabIndex = 17;
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
            // staffrt
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StaffLogsBindingSource;
            this.staffrt.LocalReport.DataSources.Add(reportDataSource1);
            this.staffrt.LocalReport.ReportEmbeddedResource = "REDNA_BANK.stafflogreport.rdlc";
            this.staffrt.Location = new System.Drawing.Point(47, 203);
            this.staffrt.Name = "staffrt";
            this.staffrt.ServerReport.BearerToken = null;
            this.staffrt.Size = new System.Drawing.Size(1413, 552);
            this.staffrt.TabIndex = 23;
            // 
            // adminrt
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.AdminLogsBindingSource;
            this.adminrt.LocalReport.DataSources.Add(reportDataSource2);
            this.adminrt.LocalReport.ReportEmbeddedResource = "REDNA_BANK.admin_logsreport.rdlc";
            this.adminrt.Location = new System.Drawing.Point(47, 203);
            this.adminrt.Name = "adminrt";
            this.adminrt.ServerReport.BearerToken = null;
            this.adminrt.Size = new System.Drawing.Size(1413, 552);
            this.adminrt.TabIndex = 24;
            // 
            // StaffLogsTableAdapter
            // 
            this.StaffLogsTableAdapter.ClearBeforeFill = true;
            // 
            // AdminLogsTableAdapter
            // 
            this.AdminLogsTableAdapter.ClearBeforeFill = true;
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 892);
            this.Controls.Add(this.staffrt);
            this.Controls.Add(this.adminrt);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.editheaderlabel);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.txt_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Logs";
            this.Text = "Logs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logreports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel editheaderlabel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbtype;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2MessageDialog validationmsgbx;
        private Microsoft.Reporting.WinForms.ReportViewer staffrt;
        private System.Windows.Forms.BindingSource StaffLogsBindingSource;
        private logreports logreports;
        private logreportsTableAdapters.StaffLogsTableAdapter StaffLogsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer adminrt;
        private System.Windows.Forms.BindingSource AdminLogsBindingSource;
        private logreportsTableAdapters.AdminLogsTableAdapter AdminLogsTableAdapter;
    }
}