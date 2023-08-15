
namespace REDNA_BANK
{
    partial class ViewTransactionDetails
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
            this.TransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TransactionsData = new REDNA_BANK.TransactionsData();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_view = new Guna.UI2.WinForms.Guna2Button();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog3 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TransactionsTableAdapter = new REDNA_BANK.TransactionsDataTableAdapters.TransactionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsData)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionsBindingSource
            // 
            this.TransactionsBindingSource.DataMember = "Transactions";
            this.TransactionsBindingSource.DataSource = this.TransactionsData;
            // 
            // TransactionsData
            // 
            this.TransactionsData.DataSetName = "TransactionsData";
            this.TransactionsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btn_clear.Location = new System.Drawing.Point(599, 110);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(180, 45);
            this.btn_clear.TabIndex = 50;
            this.btn_clear.Text = "Clear";
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
            this.btn_view.Location = new System.Drawing.Point(817, 110);
            this.btn_view.Name = "btn_view";
            this.btn_view.ShadowDecoration.Parent = this.btn_view;
            this.btn_view.Size = new System.Drawing.Size(180, 45);
            this.btn_view.TabIndex = 49;
            this.btn_view.Text = "View";
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
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
            this.txt_id.Location = new System.Drawing.Point(63, 110);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_id.PlaceholderText = "Account Number";
            this.txt_id.SelectedText = "";
            this.txt_id.ShadowDecoration.Parent = this.txt_id;
            this.txt_id.Size = new System.Drawing.Size(443, 36);
            this.txt_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_id.TabIndex = 48;
            // 
            // viewheaderlabel
            // 
            this.viewheaderlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewheaderlabel.BackColor = System.Drawing.Color.Transparent;
            this.viewheaderlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewheaderlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewheaderlabel.Location = new System.Drawing.Point(37, 13);
            this.viewheaderlabel.Name = "viewheaderlabel";
            this.viewheaderlabel.Size = new System.Drawing.Size(550, 56);
            this.viewheaderlabel.TabIndex = 47;
            this.viewheaderlabel.Text = "VIEW TRANSACTION DETAILS";
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog1.Text = "Please Check the Account Number";
            // 
            // guna2MessageDialog2
            // 
            this.guna2MessageDialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog2.Caption = "Error";
            this.guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.guna2MessageDialog2.Parent = null;
            this.guna2MessageDialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog2.Text = "Database Error";
            // 
            // guna2MessageDialog3
            // 
            this.guna2MessageDialog3.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog3.Caption = "Error";
            this.guna2MessageDialog3.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.guna2MessageDialog3.Parent = null;
            this.guna2MessageDialog3.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog3.Text = "Check Again";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TransactionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "REDNA_BANK.TransactionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(37, 203);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1387, 677);
            this.reportViewer1.TabIndex = 51;
            // 
            // TransactionsTableAdapter
            // 
            this.TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewTransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 892);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.viewheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewTransactionDetails";
            this.Text = "ViewTransactionDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewTransactionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_view;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TransactionsBindingSource;
        private TransactionsData TransactionsData;
        private TransactionsDataTableAdapters.TransactionsTableAdapter TransactionsTableAdapter;
    }
}