namespace WinFormsApp2
{
    partial class ManageInvoices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            invoicesDateGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)invoicesDateGridView).BeginInit();
            SuspendLayout();
            // 
            // invoicesDateGridView
            // 
            invoicesDateGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoicesDateGridView.Location = new Point(3, 3);
            invoicesDateGridView.Name = "invoicesDateGridView";
            invoicesDateGridView.RowHeadersWidth = 51;
            invoicesDateGridView.Size = new Size(688, 551);
            invoicesDateGridView.TabIndex = 0;
            // 
            // ManageInvoices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(invoicesDateGridView);
            Name = "ManageInvoices";
            Size = new Size(694, 575);
            ((System.ComponentModel.ISupportInitialize)invoicesDateGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView invoicesDateGridView;
    }
}
