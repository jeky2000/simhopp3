namespace SimHop
{
    partial class Guest
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
            this.dataGridViewguest = new System.Windows.Forms.DataGridView();
            this.btnshowtableguest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewguest)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewguest
            // 
            this.dataGridViewguest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewguest.Location = new System.Drawing.Point(54, 41);
            this.dataGridViewguest.Name = "dataGridViewguest";
            this.dataGridViewguest.RowTemplate.Height = 24;
            this.dataGridViewguest.Size = new System.Drawing.Size(727, 393);
            this.dataGridViewguest.TabIndex = 0;
            // 
            // btnshowtableguest
            // 
            this.btnshowtableguest.Image = global::SimHop.Properties.Resources.Document_Copy_icon;
            this.btnshowtableguest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnshowtableguest.Location = new System.Drawing.Point(623, 440);
            this.btnshowtableguest.Name = "btnshowtableguest";
            this.btnshowtableguest.Size = new System.Drawing.Size(158, 49);
            this.btnshowtableguest.TabIndex = 1;
            this.btnshowtableguest.Text = "Show Table";
            this.btnshowtableguest.UseVisualStyleBackColor = true;
            this.btnshowtableguest.Click += new System.EventHandler(this.btnshowtableguest_Click);
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 534);
            this.Controls.Add(this.btnshowtableguest);
            this.Controls.Add(this.dataGridViewguest);
            this.Name = "Guest";
            this.Text = "Guest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewguest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewguest;
        private System.Windows.Forms.Button btnshowtableguest;
    }
}