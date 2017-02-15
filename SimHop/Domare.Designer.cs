namespace SimHop
{
    partial class Domare
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.labelresult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdifficulty = new System.Windows.Forms.TextBox();
            this.labelpoint = new System.Windows.Forms.Label();
            this.txtpoint = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(516, 483);
            this.dataGridView1.TabIndex = 0;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(110, 441);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(117, 54);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(358, 441);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(73, 54);
            this.txtresult.TabIndex = 2;
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Location = new System.Drawing.Point(279, 460);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(56, 17);
            this.labelresult.TabIndex = 3;
            this.labelresult.Text = "Result :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Difficulty";
            // 
            // txtdifficulty
            // 
            this.txtdifficulty.Location = new System.Drawing.Point(245, 132);
            this.txtdifficulty.Multiline = true;
            this.txtdifficulty.Name = "txtdifficulty";
            this.txtdifficulty.Size = new System.Drawing.Size(111, 37);
            this.txtdifficulty.TabIndex = 5;
            // 
            // labelpoint
            // 
            this.labelpoint.AutoSize = true;
            this.labelpoint.Location = new System.Drawing.Point(151, 212);
            this.labelpoint.Name = "labelpoint";
            this.labelpoint.Size = new System.Drawing.Size(40, 17);
            this.labelpoint.TabIndex = 6;
            this.labelpoint.Text = "Point";
            // 
            // txtpoint
            // 
            this.txtpoint.Location = new System.Drawing.Point(245, 192);
            this.txtpoint.Multiline = true;
            this.txtpoint.Name = "txtpoint";
            this.txtpoint.Size = new System.Drawing.Size(111, 37);
            this.txtpoint.TabIndex = 5;
            this.txtpoint.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Domare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.labelpoint);
            this.Controls.Add(this.txtpoint);
            this.Controls.Add(this.txtdifficulty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Domare";
            this.Text = "Domare";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdifficulty;
        private System.Windows.Forms.Label labelpoint;
        private System.Windows.Forms.TextBox txtpoint;
    }
}