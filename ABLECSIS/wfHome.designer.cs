namespace ABLECSIS
{
    partial class wfHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfHome));
            this.tmDate = new System.Windows.Forms.Timer(this.components);
            this.ttHome = new System.Windows.Forms.ToolTip(this.components);
            this.dgCritical = new System.Windows.Forms.DataGridView();
            this.pnCriticalItem = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbCustomer = new System.Windows.Forms.ToolStripButton();
            this.bnProduct = new System.Windows.Forms.ToolStripButton();
            this.bnPurchasing = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnItem = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUsernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bnCritical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lbDate = new System.Windows.Forms.ToolStripLabel();
            this.lbUser = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgCritical)).BeginInit();
            this.pnCriticalItem.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mnItem.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmDate
            // 
            this.tmDate.Interval = 1000;
            this.tmDate.Tick += new System.EventHandler(this.tmDate_Tick);
            // 
            // dgCritical
            // 
            this.dgCritical.AllowUserToAddRows = false;
            this.dgCritical.AllowUserToDeleteRows = false;
            this.dgCritical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCritical.BackgroundColor = System.Drawing.Color.White;
            this.dgCritical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCritical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCritical.Location = new System.Drawing.Point(0, 43);
            this.dgCritical.Name = "dgCritical";
            this.dgCritical.ReadOnly = true;
            this.dgCritical.RowHeadersVisible = false;
            this.dgCritical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCritical.Size = new System.Drawing.Size(1028, 144);
            this.dgCritical.TabIndex = 7;
            this.dgCritical.DoubleClick += new System.EventHandler(this.dgCritical_DoubleClick);
            // 
            // pnCriticalItem
            // 
            this.pnCriticalItem.BackColor = System.Drawing.Color.Transparent;
            this.pnCriticalItem.Controls.Add(this.dgCritical);
            this.pnCriticalItem.Controls.Add(this.panel2);
            this.pnCriticalItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCriticalItem.Location = new System.Drawing.Point(0, 195);
            this.pnCriticalItem.Name = "pnCriticalItem";
            this.pnCriticalItem.Size = new System.Drawing.Size(1028, 187);
            this.pnCriticalItem.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::ABLECSIS.Properties.Resources.New;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.bnPrint);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 43);
            this.panel2.TabIndex = 8;
            // 
            // bnPrint
            // 
            this.bnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnPrint.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnPrint.Location = new System.Drawing.Point(935, 9);
            this.bnPrint.Name = "bnPrint";
            this.bnPrint.Size = new System.Drawing.Size(87, 27);
            this.bnPrint.TabIndex = 7;
            this.bnPrint.Text = "Print";
            this.bnPrint.UseVisualStyleBackColor = true;
            this.bnPrint.Click += new System.EventHandler(this.bnPrint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Critical Item";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbCustomer,
            this.bnProduct,
            this.bnPurchasing});
            this.toolStrip1.Location = new System.Drawing.Point(0, 118);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbCustomer
            // 
            this.cbCustomer.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.ForeColor = System.Drawing.Color.Black;
            this.cbCustomer.Image = ((System.Drawing.Image)(resources.GetObject("cbCustomer.Image")));
            this.cbCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(74, 22);
            this.cbCustomer.Text = "Customer";
            this.cbCustomer.Click += new System.EventHandler(this.cbCustomer_Click);
            // 
            // bnProduct
            // 
            this.bnProduct.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnProduct.ForeColor = System.Drawing.Color.Black;
            this.bnProduct.Image = ((System.Drawing.Image)(resources.GetObject("bnProduct.Image")));
            this.bnProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnProduct.Name = "bnProduct";
            this.bnProduct.Size = new System.Drawing.Size(66, 22);
            this.bnProduct.Text = "Product";
            this.bnProduct.Click += new System.EventHandler(this.bnProduct_Click);
            // 
            // bnPurchasing
            // 
            this.bnPurchasing.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnPurchasing.ForeColor = System.Drawing.Color.Black;
            this.bnPurchasing.Image = ((System.Drawing.Image)(resources.GetObject("bnPurchasing.Image")));
            this.bnPurchasing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnPurchasing.Name = "bnPurchasing";
            this.bnPurchasing.Size = new System.Drawing.Size(83, 22);
            this.bnPurchasing.Text = "Purchasing";
            this.bnPurchasing.Click += new System.EventHandler(this.bnPurchasing_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ABLECSIS.Properties.Resources.New;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 94);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ABLECSIS.Properties.Resources._150px_San_Miguel_Corporation_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(11, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(285, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "National Highway, Pangobilian Brooke\'s Point Palawan";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(976, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computerized Sales and Inventory System of A.B. Leoncio Enterprises";
            // 
            // mnItem
            // 
            this.mnItem.BackColor = System.Drawing.Color.White;
            this.mnItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.mnItem.Location = new System.Drawing.Point(0, 0);
            this.mnItem.Name = "mnItem";
            this.mnItem.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnItem.Size = new System.Drawing.Size(1028, 24);
            this.mnItem.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUsernameToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changeUsernameToolStripMenuItem
            // 
            this.changeUsernameToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.changeUsernameToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeUsernameToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.changeUsernameToolStripMenuItem.Name = "changeUsernameToolStripMenuItem";
            this.changeUsernameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.C)));
            this.changeUsernameToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.changeUsernameToolStripMenuItem.Text = "&Change User Information";
            this.changeUsernameToolStripMenuItem.Click += new System.EventHandler(this.changeUsernameToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.logOutToolStripMenuItem.Text = "&Log - Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInformationToolStripMenuItem});
            this.informationToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.informationToolStripMenuItem.Text = "Configuration";
            // 
            // userInformationToolStripMenuItem
            // 
            this.userInformationToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userInformationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            this.userInformationToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.userInformationToolStripMenuItem.Text = "User Configure";
            this.userInformationToolStripMenuItem.Click += new System.EventHandler(this.userInformationToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.logInHistoryToolStripMenuItem,
            this.bnCritical});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // logInHistoryToolStripMenuItem
            // 
            this.logInHistoryToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logInHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.logInHistoryToolStripMenuItem.Name = "logInHistoryToolStripMenuItem";
            this.logInHistoryToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.logInHistoryToolStripMenuItem.Text = "Log - In History";
            this.logInHistoryToolStripMenuItem.Click += new System.EventHandler(this.logInHistoryToolStripMenuItem_Click);
            // 
            // bnCritical
            // 
            this.bnCritical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnCritical.Checked = true;
            this.bnCritical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bnCritical.ForeColor = System.Drawing.Color.Black;
            this.bnCritical.Name = "bnCritical";
            this.bnCritical.Size = new System.Drawing.Size(155, 22);
            this.bnCritical.Text = "Critical Item";
            this.bnCritical.Click += new System.EventHandler(this.bnCritical_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDate,
            this.lbUser});
            this.toolStrip2.Location = new System.Drawing.Point(0, 382);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1028, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lbDate
            // 
            this.lbDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbDate.ForeColor = System.Drawing.Color.Black;
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 22);
            // 
            // lbUser
            // 
            this.lbUser.ForeColor = System.Drawing.Color.Black;
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(0, 22);
            // 
            // wfHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ABLECSIS.Properties.Resources.New;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 407);
            this.ControlBox = false;
            this.Controls.Add(this.pnCriticalItem);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnItem);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnItem;
            this.Name = "wfHome";
            this.Text = "AB Leoncio Enterprises Computerized Sales Inventory System - Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wfHome_FormClosing);
            this.Load += new System.EventHandler(this.wfHome_Load);
            this.Resize += new System.EventHandler(this.wfHome_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgCritical)).EndInit();
            this.pnCriticalItem.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mnItem.ResumeLayout(false);
            this.mnItem.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mnItem;
        private System.Windows.Forms.Timer tmDate;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lbDate;
        private System.Windows.Forms.ToolStripLabel lbUser;
        private System.Windows.Forms.ToolStripMenuItem changeUsernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttHome;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton cbCustomer;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bnProduct;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bnPurchasing;
        private System.Windows.Forms.DataGridView dgCritical;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnCriticalItem;
        private System.Windows.Forms.ToolStripMenuItem bnCritical;
        private System.Windows.Forms.Button bnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}