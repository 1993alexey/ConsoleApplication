namespace MegaDesk_Alex_Shnyrov
{
    partial class ViewAllQuotes
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
            this.grdQuotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // grdQuotes
            // 
            this.grdQuotes.AllowUserToAddRows = false;
            this.grdQuotes.AllowUserToDeleteRows = false;
            this.grdQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQuotes.Location = new System.Drawing.Point(12, 12);
            this.grdQuotes.Name = "grdQuotes";
            this.grdQuotes.ReadOnly = true;
            this.grdQuotes.RowTemplate.Height = 24;
            this.grdQuotes.Size = new System.Drawing.Size(1118, 426);
            this.grdQuotes.TabIndex = 0;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.grdQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.grdQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdQuotes;
    }
}