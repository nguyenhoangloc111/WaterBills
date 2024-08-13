namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            manageInvoices = new ManageInvoices();
            addToolStripMenuItem = new ToolStripMenuItem();
            managesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            addInvoices = new AddInvoices();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // manageInvoices
            // 
            manageInvoices.Location = new Point(0, 31);
            manageInvoices.Name = "manageInvoices";
            manageInvoices.Size = new Size(800, 364);
            manageInvoices.TabIndex = 1;
            manageInvoices.Load += manageInvoices_Load;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(108, 24);
            addToolStripMenuItem.Text = "Add Invoices";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // managesToolStripMenuItem
            // 
            managesToolStripMenuItem.Name = "managesToolStripMenuItem";
            managesToolStripMenuItem.Size = new Size(134, 24);
            managesToolStripMenuItem.Text = "Manage Invoices";
            managesToolStripMenuItem.Click += managesToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, managesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addInvoices
            // 
            addInvoices.Location = new Point(0, 31);
            addInvoices.Name = "addInvoices";
            addInvoices.Size = new Size(800, 478);
            addInvoices.TabIndex = 2;
            addInvoices.Load += addInvoices1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addInvoices);
            Controls.Add(manageInvoices);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ManageInvoices manageInvoices;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem managesToolStripMenuItem;
        private MenuStrip menuStrip1;
        private AddInvoices addInvoices;
    }
}
