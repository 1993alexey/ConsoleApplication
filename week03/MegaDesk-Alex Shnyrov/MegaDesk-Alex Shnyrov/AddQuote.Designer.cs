namespace MegaDesk_Alex_Shnyrov
{
    partial class AddQuote
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
            this.width = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.rushOrder = new System.Windows.Forms.ComboBox();
            this.materialType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.newQuoteBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawers)).BeginInit();
            this.SuspendLayout();
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(179, 181);
            this.width.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(234, 34);
            this.width.TabIndex = 3;
            this.width.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.width.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(179, 93);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(234, 34);
            this.name.TabIndex = 1;
            this.name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.name_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depth";
            // 
            // depth
            // 
            this.depth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.Location = new System.Drawing.Point(179, 225);
            this.depth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(234, 34);
            this.depth.TabIndex = 4;
            this.depth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depth.ValueChanged += new System.EventHandler(this.depth_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Drawers";
            // 
            // drawers
            // 
            this.drawers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawers.Location = new System.Drawing.Point(179, 269);
            this.drawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(234, 34);
            this.drawers.TabIndex = 5;
            this.drawers.ValueChanged += new System.EventHandler(this.drawers_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rush Order";
            // 
            // rushOrder
            // 
            this.rushOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rushOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrder.FormattingEnabled = true;
            this.rushOrder.Items.AddRange(new object[] {
            "14",
            "7",
            "5",
            "3"});
            this.rushOrder.Location = new System.Drawing.Point(179, 312);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(234, 36);
            this.rushOrder.TabIndex = 6;
            this.rushOrder.Tag = "";
            this.rushOrder.SelectedIndexChanged += new System.EventHandler(this.rushOrder_SelectedIndexChanged);
            // 
            // materialType
            // 
            this.materialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialType.FormattingEnabled = true;
            this.materialType.Items.AddRange(new object[] {
            "--Select wood type--"});
            this.materialType.Location = new System.Drawing.Point(179, 137);
            this.materialType.Name = "materialType";
            this.materialType.Size = new System.Drawing.Size(234, 36);
            this.materialType.TabIndex = 2;
            this.materialType.Tag = "";
            this.materialType.SelectedIndexChanged += new System.EventHandler(this.materialType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 59);
            this.label7.TabIndex = 12;
            this.label7.Text = "Add New Quote";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 49);
            this.label8.TabIndex = 13;
            this.label8.Text = "Price:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(135, 380);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(84, 49);
            this.price.TabIndex = 14;
            this.price.Text = "$0.0";
            // 
            // newQuoteBtn
            // 
            this.newQuoteBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.newQuoteBtn.Enabled = false;
            this.newQuoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newQuoteBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuoteBtn.Location = new System.Drawing.Point(37, 454);
            this.newQuoteBtn.Name = "newQuoteBtn";
            this.newQuoteBtn.Size = new System.Drawing.Size(182, 76);
            this.newQuoteBtn.TabIndex = 15;
            this.newQuoteBtn.Text = "Add";
            this.newQuoteBtn.UseVisualStyleBackColor = true;
            this.newQuoteBtn.Click += new System.EventHandler(this.newQuoteBtn_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(227, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 76);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newQuoteBtn);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.materialType);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.width);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown drawers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox materialType;
        private System.Windows.Forms.ComboBox rushOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button newQuoteBtn;
        private System.Windows.Forms.Button button1;
    }
}