namespace rashad.Forms
{
    partial class ItemHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInsertitem = new System.Windows.Forms.Button();
            this.txtcategorySearch = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInsertitem);
            this.groupBox1.Controls.Add(this.txtcategorySearch);
            this.groupBox1.Location = new System.Drawing.Point(236, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 419);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاصناف";
            // 
            // txtInsertitem
            // 
            this.txtInsertitem.BackColor = System.Drawing.Color.ForestGreen;
            this.txtInsertitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertitem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInsertitem.Location = new System.Drawing.Point(215, 123);
            this.txtInsertitem.Name = "txtInsertitem";
            this.txtInsertitem.Size = new System.Drawing.Size(146, 56);
            this.txtInsertitem.TabIndex = 1;
            this.txtInsertitem.Text = "ادخال ";
            this.txtInsertitem.UseVisualStyleBackColor = false;
            this.txtInsertitem.Click += new System.EventHandler(this.txtInsertitem_Click);
            // 
            // txtcategorySearch
            // 
            this.txtcategorySearch.BackColor = System.Drawing.Color.ForestGreen;
            this.txtcategorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategorySearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcategorySearch.Location = new System.Drawing.Point(215, 253);
            this.txtcategorySearch.Name = "txtcategorySearch";
            this.txtcategorySearch.Size = new System.Drawing.Size(146, 51);
            this.txtcategorySearch.TabIndex = 2;
            this.txtcategorySearch.Text = "بحث";
            this.txtcategorySearch.UseVisualStyleBackColor = false;
            this.txtcategorySearch.Click += new System.EventHandler(this.txtcategorySearch_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.ForestGreen;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(960, 592);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(96, 45);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "رجوع";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // ItemHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1057, 637);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemHome";
            this.Text = "عمليات على الاصناف";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtInsertitem;
        private System.Windows.Forms.Button txtcategorySearch;
        private System.Windows.Forms.Button btnback;
    }
}