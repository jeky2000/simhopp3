namespace SimHop
{
    partial class Admin
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
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtdataofbirht = new System.Windows.Forms.TextBox();
            this.txtdive = new System.Windows.Forms.TextBox();
            this.labelfirstname = new System.Windows.Forms.Label();
            this.labellastname = new System.Windows.Forms.Label();
            this.labeldateofbirth = new System.Windows.Forms.Label();
            this.labeldive = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(767, 614);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(154, 57);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(439, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 498);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(492, 614);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(152, 57);
            this.btnremove.TabIndex = 2;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(273, 614);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(152, 56);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(49, 614);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(152, 56);
            this.btnread.TabIndex = 4;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(184, 87);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(163, 22);
            this.txtfirstname.TabIndex = 5;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(184, 139);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(163, 22);
            this.txtlastname.TabIndex = 5;
            // 
            // txtdataofbirht
            // 
            this.txtdataofbirht.Location = new System.Drawing.Point(184, 195);
            this.txtdataofbirht.Name = "txtdataofbirht";
            this.txtdataofbirht.Size = new System.Drawing.Size(163, 22);
            this.txtdataofbirht.TabIndex = 5;
            // 
            // txtdive
            // 
            this.txtdive.Location = new System.Drawing.Point(184, 248);
            this.txtdive.Name = "txtdive";
            this.txtdive.Size = new System.Drawing.Size(163, 22);
            this.txtdive.TabIndex = 5;
            // 
            // labelfirstname
            // 
            this.labelfirstname.AutoSize = true;
            this.labelfirstname.Location = new System.Drawing.Point(96, 94);
            this.labelfirstname.Name = "labelfirstname";
            this.labelfirstname.Size = new System.Drawing.Size(72, 17);
            this.labelfirstname.TabIndex = 6;
            this.labelfirstname.Text = "FirstName";
            // 
            // labellastname
            // 
            this.labellastname.AutoSize = true;
            this.labellastname.Location = new System.Drawing.Point(96, 139);
            this.labellastname.Name = "labellastname";
            this.labellastname.Size = new System.Drawing.Size(72, 17);
            this.labellastname.TabIndex = 6;
            this.labellastname.Text = "LastName";
            // 
            // labeldateofbirth
            // 
            this.labeldateofbirth.AutoSize = true;
            this.labeldateofbirth.Location = new System.Drawing.Point(96, 195);
            this.labeldateofbirth.Name = "labeldateofbirth";
            this.labeldateofbirth.Size = new System.Drawing.Size(78, 17);
            this.labeldateofbirth.TabIndex = 6;
            this.labeldateofbirth.Text = "Dateofbirth";
            // 
            // labeldive
            // 
            this.labeldive.AutoSize = true;
            this.labeldive.Location = new System.Drawing.Point(96, 248);
            this.labeldive.Name = "labeldive";
            this.labeldive.Size = new System.Drawing.Size(36, 17);
            this.labeldive.TabIndex = 6;
            this.labeldive.Text = "Dive";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labeldive);
            this.Controls.Add(this.labeldateofbirth);
            this.Controls.Add(this.labellastname);
            this.Controls.Add(this.labelfirstname);
            this.Controls.Add(this.txtdive);
            this.Controls.Add(this.txtdataofbirht);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadd);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtdataofbirht;
        private System.Windows.Forms.TextBox txtdive;
        private System.Windows.Forms.Label labelfirstname;
        private System.Windows.Forms.Label labellastname;
        private System.Windows.Forms.Label labeldateofbirth;
        private System.Windows.Forms.Label labeldive;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}