namespace BillingManagementStudi
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Create,
            this.updateBillToolStripMenuItem,
            this.deleteBillToolStripMenuItem,
            this.viewBillToolStripMenuItem});
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.billingToolStripMenuItem.Text = "Billing";
            // 
            // menu_Create
            // 
            this.menu_Create.Name = "menu_Create";
            this.menu_Create.Size = new System.Drawing.Size(181, 26);
            this.menu_Create.Text = "New Bill";
            this.menu_Create.Click += new System.EventHandler(this.menu_Create_Click);
            // 
            // updateBillToolStripMenuItem
            // 
            this.updateBillToolStripMenuItem.Name = "updateBillToolStripMenuItem";
            this.updateBillToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.updateBillToolStripMenuItem.Text = "Update Bill";
            // 
            // deleteBillToolStripMenuItem
            // 
            this.deleteBillToolStripMenuItem.Name = "deleteBillToolStripMenuItem";
            this.deleteBillToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.deleteBillToolStripMenuItem.Text = "Delete Bill";
            // 
            // viewBillToolStripMenuItem
            // 
            this.viewBillToolStripMenuItem.Name = "viewBillToolStripMenuItem";
            this.viewBillToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.viewBillToolStripMenuItem.Text = "View Bill";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Create;
        private System.Windows.Forms.ToolStripMenuItem updateBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}