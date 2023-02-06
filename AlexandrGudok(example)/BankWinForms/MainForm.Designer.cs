namespace BankWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbx_debitors = new System.Windows.Forms.GroupBox();
            this.grbx_debitorDetails = new System.Windows.Forms.GroupBox();
            this.grbx_credits = new System.Windows.Forms.GroupBox();
            this.grbx_Payments = new System.Windows.Forms.GroupBox();
            this.dgv_debitors = new System.Windows.Forms.DataGridView();
            this.dgv_credits = new System.Windows.Forms.DataGridView();
            this.dgv_payments = new System.Windows.Forms.DataGridView();
            this.txbx_debitorID = new System.Windows.Forms.TextBox();
            this.txbx_debitorName = new System.Windows.Forms.TextBox();
            this.txbx_debitorPostNumber = new System.Windows.Forms.TextBox();
            this.txbx_phoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbx_Search = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbx_debitors.SuspendLayout();
            this.grbx_debitorDetails.SuspendLayout();
            this.grbx_credits.SuspendLayout();
            this.grbx_Payments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_debitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payments)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_debitors
            // 
            this.grbx_debitors.Controls.Add(this.dgv_debitors);
            this.grbx_debitors.Location = new System.Drawing.Point(12, 199);
            this.grbx_debitors.Name = "grbx_debitors";
            this.grbx_debitors.Size = new System.Drawing.Size(456, 133);
            this.grbx_debitors.TabIndex = 0;
            this.grbx_debitors.TabStop = false;
            this.grbx_debitors.Text = "Debitors";
            // 
            // grbx_debitorDetails
            // 
            this.grbx_debitorDetails.Controls.Add(this.label4);
            this.grbx_debitorDetails.Controls.Add(this.label3);
            this.grbx_debitorDetails.Controls.Add(this.label2);
            this.grbx_debitorDetails.Controls.Add(this.label1);
            this.grbx_debitorDetails.Controls.Add(this.txbx_phoneNumber);
            this.grbx_debitorDetails.Controls.Add(this.txbx_debitorPostNumber);
            this.grbx_debitorDetails.Controls.Add(this.txbx_debitorName);
            this.grbx_debitorDetails.Controls.Add(this.txbx_debitorID);
            this.grbx_debitorDetails.Location = new System.Drawing.Point(474, 199);
            this.grbx_debitorDetails.Name = "grbx_debitorDetails";
            this.grbx_debitorDetails.Size = new System.Drawing.Size(596, 133);
            this.grbx_debitorDetails.TabIndex = 1;
            this.grbx_debitorDetails.TabStop = false;
            this.grbx_debitorDetails.Text = "Debitors details";
            // 
            // grbx_credits
            // 
            this.grbx_credits.Controls.Add(this.dgv_credits);
            this.grbx_credits.Location = new System.Drawing.Point(12, 347);
            this.grbx_credits.Name = "grbx_credits";
            this.grbx_credits.Size = new System.Drawing.Size(1058, 116);
            this.grbx_credits.TabIndex = 2;
            this.grbx_credits.TabStop = false;
            this.grbx_credits.Text = "Credits";
            // 
            // grbx_Payments
            // 
            this.grbx_Payments.Controls.Add(this.dgv_payments);
            this.grbx_Payments.Location = new System.Drawing.Point(12, 469);
            this.grbx_Payments.Name = "grbx_Payments";
            this.grbx_Payments.Size = new System.Drawing.Size(1058, 116);
            this.grbx_Payments.TabIndex = 2;
            this.grbx_Payments.TabStop = false;
            this.grbx_Payments.Text = "Payments";
            // 
            // dgv_debitors
            // 
            this.dgv_debitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_debitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_debitors.Location = new System.Drawing.Point(3, 16);
            this.dgv_debitors.Name = "dgv_debitors";
            this.dgv_debitors.Size = new System.Drawing.Size(450, 114);
            this.dgv_debitors.TabIndex = 0;
            // 
            // dgv_credits
            // 
            this.dgv_credits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_credits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_credits.Location = new System.Drawing.Point(3, 16);
            this.dgv_credits.Name = "dgv_credits";
            this.dgv_credits.Size = new System.Drawing.Size(1052, 97);
            this.dgv_credits.TabIndex = 0;
            // 
            // dgv_payments
            // 
            this.dgv_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_payments.Location = new System.Drawing.Point(3, 16);
            this.dgv_payments.Name = "dgv_payments";
            this.dgv_payments.Size = new System.Drawing.Size(1052, 97);
            this.dgv_payments.TabIndex = 0;
            // 
            // txbx_debitorID
            // 
            this.txbx_debitorID.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_debitorID.Location = new System.Drawing.Point(302, 19);
            this.txbx_debitorID.Name = "txbx_debitorID";
            this.txbx_debitorID.ReadOnly = true;
            this.txbx_debitorID.Size = new System.Drawing.Size(288, 20);
            this.txbx_debitorID.TabIndex = 0;
            // 
            // txbx_debitorName
            // 
            this.txbx_debitorName.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_debitorName.Location = new System.Drawing.Point(302, 45);
            this.txbx_debitorName.Name = "txbx_debitorName";
            this.txbx_debitorName.ReadOnly = true;
            this.txbx_debitorName.Size = new System.Drawing.Size(288, 20);
            this.txbx_debitorName.TabIndex = 1;
            // 
            // txbx_debitorPostNumber
            // 
            this.txbx_debitorPostNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_debitorPostNumber.Location = new System.Drawing.Point(302, 71);
            this.txbx_debitorPostNumber.Name = "txbx_debitorPostNumber";
            this.txbx_debitorPostNumber.ReadOnly = true;
            this.txbx_debitorPostNumber.Size = new System.Drawing.Size(288, 20);
            this.txbx_debitorPostNumber.TabIndex = 2;
            // 
            // txbx_phoneNumber
            // 
            this.txbx_phoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_phoneNumber.Location = new System.Drawing.Point(302, 97);
            this.txbx_phoneNumber.Name = "txbx_phoneNumber";
            this.txbx_phoneNumber.ReadOnly = true;
            this.txbx_phoneNumber.Size = new System.Drawing.Size(288, 20);
            this.txbx_phoneNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DebitorID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DebitorName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Debitor Post Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Debitor Phone number";
            // 
            // grbx_Search
            // 
            this.grbx_Search.Location = new System.Drawing.Point(15, 60);
            this.grbx_Search.Name = "grbx_Search";
            this.grbx_Search.Size = new System.Drawing.Size(1066, 106);
            this.grbx_Search.TabIndex = 3;
            this.grbx_Search.TabStop = false;
            this.grbx_Search.Text = "Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveDataToCSVToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDataToCSVToolStripMenuItem
            // 
            this.saveDataToCSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.saveDataToCSVToolStripMenuItem.Name = "saveDataToCSVToolStripMenuItem";
            this.saveDataToCSVToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.saveDataToCSVToolStripMenuItem.Text = "Debitor";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Save data to CSV";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Add new debitor";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.creditToolStripMenuItem.Text = "Credit";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open new credit";
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passNewPaymentToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // passNewPaymentToolStripMenuItem
            // 
            this.passNewPaymentToolStripMenuItem.Name = "passNewPaymentToolStripMenuItem";
            this.passNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.passNewPaymentToolStripMenuItem.Text = "Pass new payment";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 608);
            this.Controls.Add(this.grbx_Search);
            this.Controls.Add(this.grbx_Payments);
            this.Controls.Add(this.grbx_credits);
            this.Controls.Add(this.grbx_debitorDetails);
            this.Controls.Add(this.grbx_debitors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Bank manager";
            this.grbx_debitors.ResumeLayout(false);
            this.grbx_debitorDetails.ResumeLayout(false);
            this.grbx_debitorDetails.PerformLayout();
            this.grbx_credits.ResumeLayout(false);
            this.grbx_Payments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_debitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payments)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_debitors;
        private System.Windows.Forms.GroupBox grbx_debitorDetails;
        private System.Windows.Forms.GroupBox grbx_credits;
        private System.Windows.Forms.GroupBox grbx_Payments;
        private System.Windows.Forms.DataGridView dgv_debitors;
        private System.Windows.Forms.DataGridView dgv_credits;
        private System.Windows.Forms.DataGridView dgv_payments;
        private System.Windows.Forms.TextBox txbx_debitorName;
        private System.Windows.Forms.TextBox txbx_debitorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_phoneNumber;
        private System.Windows.Forms.TextBox txbx_debitorPostNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbx_Search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveDataToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passNewPaymentToolStripMenuItem;
    }
}

