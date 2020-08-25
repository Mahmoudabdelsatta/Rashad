namespace rashad.Forms
{
    partial class categorySearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtcatsearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btncatinsert = new System.Windows.Forms.Button();
            this.btncatupdate = new System.Windows.Forms.Button();
            this.btncatdelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtupdatename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(234, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(409, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 45;
            this.dataGridView1.Size = new System.Drawing.Size(618, 289);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // txtcatsearch
            // 
            this.txtcatsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatsearch.Location = new System.Drawing.Point(489, 29);
            this.txtcatsearch.Multiline = true;
            this.txtcatsearch.Name = "txtcatsearch";
            this.txtcatsearch.Size = new System.Drawing.Size(368, 49);
            this.txtcatsearch.TabIndex = 3;
            this.txtcatsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(953, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "رجوع";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncatinsert
            // 
            this.btncatinsert.BackColor = System.Drawing.Color.ForestGreen;
            this.btncatinsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatinsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncatinsert.Location = new System.Drawing.Point(252, 576);
            this.btncatinsert.Name = "btncatinsert";
            this.btncatinsert.Size = new System.Drawing.Size(92, 49);
            this.btncatinsert.TabIndex = 5;
            this.btncatinsert.Text = "ادخال";
            this.btncatinsert.UseVisualStyleBackColor = false;
            this.btncatinsert.Click += new System.EventHandler(this.btncatinsert_Click);
            // 
            // btncatupdate
            // 
            this.btncatupdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btncatupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncatupdate.Location = new System.Drawing.Point(137, 576);
            this.btncatupdate.Name = "btncatupdate";
            this.btncatupdate.Size = new System.Drawing.Size(92, 49);
            this.btncatupdate.TabIndex = 6;
            this.btncatupdate.Text = "تعديل";
            this.btncatupdate.UseVisualStyleBackColor = false;
            this.btncatupdate.Click += new System.EventHandler(this.btncatupdate_Click);
            // 
            // btncatdelete
            // 
            this.btncatdelete.BackColor = System.Drawing.Color.ForestGreen;
            this.btncatdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatdelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncatdelete.Location = new System.Drawing.Point(12, 576);
            this.btncatdelete.Name = "btncatdelete";
            this.btncatdelete.Size = new System.Drawing.Size(92, 49);
            this.btncatdelete.TabIndex = 7;
            this.btncatdelete.Text = "مسح";
            this.btncatdelete.UseVisualStyleBackColor = false;
            this.btncatdelete.Click += new System.EventHandler(this.btncatdelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtupdatename);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 289);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تعديل الاسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = ":اسم الطبقة";
            // 
            // txtupdatename
            // 
            this.txtupdatename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtupdatename.Location = new System.Drawing.Point(6, 30);
            this.txtupdatename.Multiline = true;
            this.txtupdatename.Name = "txtupdatename";
            this.txtupdatename.Size = new System.Drawing.Size(261, 49);
            this.txtupdatename.TabIndex = 4;
            this.txtupdatename.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // categorySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1057, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncatdelete);
            this.Controls.Add(this.btncatupdate);
            this.Controls.Add(this.btncatinsert);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtcatsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "categorySearch";
            this.Text = "بحث عن الطبقات";
            this.Load += new System.EventHandler(this.categorySearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcatsearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btncatinsert;
        private System.Windows.Forms.Button btncatupdate;
        private System.Windows.Forms.Button btncatdelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtupdatename;
        private System.Windows.Forms.Label label2;
    }
}