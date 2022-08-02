namespace AddInventory
{
    partial class MainWindow
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
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catagoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.catagoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.updateNewProductToolStripMenuItem,
            this.displayNewProductToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.productToolStripMenuItem.Text = "product";
            // 
            // catagoryToolStripMenuItem
            // 
            this.catagoryToolStripMenuItem.Name = "catagoryToolStripMenuItem";
            this.catagoryToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.catagoryToolStripMenuItem.Text = "catagory";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.addNewProductToolStripMenuItem.Text = "add new product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            this.addNewProductToolStripMenuItem.DoubleClick += new System.EventHandler(this.addNewProductToolStripMenuItem_DoubleClick);
            // 
            // updateNewProductToolStripMenuItem
            // 
            this.updateNewProductToolStripMenuItem.Name = "updateNewProductToolStripMenuItem";
            this.updateNewProductToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.updateNewProductToolStripMenuItem.Text = "update new product";
            // 
            // displayNewProductToolStripMenuItem
            // 
            this.displayNewProductToolStripMenuItem.Name = "displayNewProductToolStripMenuItem";
            this.displayNewProductToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.displayNewProductToolStripMenuItem.Text = "display new product";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catagoryToolStripMenuItem;
    }
}