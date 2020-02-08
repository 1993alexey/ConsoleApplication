namespace MegaDesk_Alex_Shnyrov
{
    partial class SearchQuotes
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
            this.grdQuotes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.materialType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // grdQuotes
            // 
            this.grdQuotes.AllowUserToAddRows = false;
            this.grdQuotes.AllowUserToDeleteRows = false;
            this.grdQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQuotes.Location = new System.Drawing.Point(-1, 68);
            this.grdQuotes.Name = "grdQuotes";
            this.grdQuotes.ReadOnly = true;
            this.grdQuotes.RowHeadersWidth = 51;
            this.grdQuotes.RowTemplate.Height = 24;
            this.grdQuotes.Size = new System.Drawing.Size(1006, 382);
            this.grdQuotes.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search quote";
            // 
            // materialType
            // 
            this.materialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialType.FormattingEnabled = true;
            this.materialType.Items.AddRange(new object[] {
            "=== All ==="});
            this.materialType.Location = new System.Drawing.Point(365, 27);
            this.materialType.Name = "materialType";
            this.materialType.Size = new System.Drawing.Size(233, 33);
            this.materialType.TabIndex = 4;
            this.materialType.SelectedIndexChanged += new System.EventHandler(this.materialType_SelectedIndexChanged);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 449);
            this.Controls.Add(this.materialType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdQuotes);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdQuotes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materialType;
    }
}