namespace rashad.Forms
{
    partial class Home
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
            this.txtcategorie = new System.Windows.Forms.Button();
            this.txtitems = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcategorie);
            this.groupBox1.Controls.Add(this.txtitems);
            this.groupBox1.Location = new System.Drawing.Point(250, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الصفحة الرئيسية";
            // 
            // txtcategorie
            // 
            this.txtcategorie.BackColor = System.Drawing.Color.ForestGreen;
            this.txtcategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategorie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcategorie.Location = new System.Drawing.Point(215, 123);
            this.txtcategorie.Name = "txtcategorie";
            this.txtcategorie.Size = new System.Drawing.Size(146, 56);
            this.txtcategorie.TabIndex = 1;
            this.txtcategorie.Text = "الطبقات";
            this.txtcategorie.UseVisualStyleBackColor = false;
            this.txtcategorie.Click += new System.EventHandler(this.txtcategorie_Click);
            // 
            // txtitems
            // 
            this.txtitems.BackColor = System.Drawing.Color.ForestGreen;
            this.txtitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtitems.Location = new System.Drawing.Point(215, 253);
            this.txtitems.Name = "txtitems";
            this.txtitems.Size = new System.Drawing.Size(146, 51);
            this.txtitems.TabIndex = 2;
            this.txtitems.Text = "الاصناف";
            this.txtitems.UseVisualStyleBackColor = false;
            this.txtitems.Click += new System.EventHandler(this.txtitems_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(899, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1057, 637);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "الصفحة الرئيسية";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtcategorie;
        private System.Windows.Forms.Button txtitems;
        private System.Windows.Forms.Button button1;
    }
}