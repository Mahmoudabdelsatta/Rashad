namespace rashad.Forms
{
    partial class CategoryHome
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
            this.txtInsertcategory = new System.Windows.Forms.Button();
            this.txtcategorySearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInsertcategory);
            this.groupBox1.Controls.Add(this.txtcategorySearch);
            this.groupBox1.Location = new System.Drawing.Point(236, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 419);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الطبقات";
            // 
            // txtInsertcategory
            // 
            this.txtInsertcategory.BackColor = System.Drawing.Color.ForestGreen;
            this.txtInsertcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertcategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInsertcategory.Location = new System.Drawing.Point(215, 123);
            this.txtInsertcategory.Name = "txtInsertcategory";
            this.txtInsertcategory.Size = new System.Drawing.Size(146, 56);
            this.txtInsertcategory.TabIndex = 1;
            this.txtInsertcategory.Text = "ادخال ";
            this.txtInsertcategory.UseVisualStyleBackColor = false;
            this.txtInsertcategory.Click += new System.EventHandler(this.txtInsertcategory_Click);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "رجوع للصفحة الرئيسية";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CategoryHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1057, 637);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoryHome";
            this.Text = "عمليات على الطبقات";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtInsertcategory;
        private System.Windows.Forms.Button txtcategorySearch;
        private System.Windows.Forms.Button button2;
    }
}