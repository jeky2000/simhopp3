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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtdataofbirht = new System.Windows.Forms.TextBox();
            this.txtdive = new System.Windows.Forms.TextBox();
            this.labelfirstname = new System.Windows.Forms.Label();
            this.labellastname = new System.Windows.Forms.Label();
            this.labeldateofbirth = new System.Windows.Forms.Label();
            this.labeldive = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnread = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnserver = new System.Windows.Forms.Button();
            this.txtservername = new System.Windows.Forms.TextBox();
            this.txtserverhopp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            resources.ApplyResources(this.btnadd, "btnadd");
            this.btnadd.Name = "btnadd";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtfirstname
            // 
            resources.ApplyResources(this.txtfirstname, "txtfirstname");
            this.txtfirstname.Name = "txtfirstname";
            // 
            // txtlastname
            // 
            resources.ApplyResources(this.txtlastname, "txtlastname");
            this.txtlastname.Name = "txtlastname";
            // 
            // txtdataofbirht
            // 
            resources.ApplyResources(this.txtdataofbirht, "txtdataofbirht");
            this.txtdataofbirht.Name = "txtdataofbirht";
            // 
            // txtdive
            // 
            resources.ApplyResources(this.txtdive, "txtdive");
            this.txtdive.Name = "txtdive";
            // 
            // labelfirstname
            // 
            resources.ApplyResources(this.labelfirstname, "labelfirstname");
            this.labelfirstname.Name = "labelfirstname";
            // 
            // labellastname
            // 
            resources.ApplyResources(this.labellastname, "labellastname");
            this.labellastname.Name = "labellastname";
            // 
            // labeldateofbirth
            // 
            resources.ApplyResources(this.labeldateofbirth, "labeldateofbirth");
            this.labeldateofbirth.Name = "labeldateofbirth";
            // 
            // labeldive
            // 
            resources.ApplyResources(this.labeldive, "labeldive");
            this.labeldive.Name = "labeldive";
            // 
            // btnupdate
            // 
            resources.ApplyResources(this.btnupdate, "btnupdate");
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // txtPoint
            // 
            resources.ApplyResources(this.txtPoint, "txtPoint");
            this.txtPoint.Name = "txtPoint";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnread
            // 
            this.btnread.Image = global::SimHop.Properties.Resources.Document_Copy_icon;
            resources.ApplyResources(this.btnread, "btnread");
            this.btnread.Name = "btnread";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::SimHop.Properties.Resources.Save_icon;
            resources.ApplyResources(this.btnsave, "btnsave");
            this.btnsave.Name = "btnsave";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnremove
            // 
            this.btnremove.Image = global::SimHop.Properties.Resources.Close_2_icon;
            resources.ApplyResources(this.btnremove, "btnremove");
            this.btnremove.Name = "btnremove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnserver
            // 
            resources.ApplyResources(this.btnserver, "btnserver");
            this.btnserver.Name = "btnserver";
            this.btnserver.UseVisualStyleBackColor = true;
            this.btnserver.Click += new System.EventHandler(this.btnserver_Click);
            // 
            // txtservername
            // 
            resources.ApplyResources(this.txtservername, "txtservername");
            this.txtservername.Name = "txtservername";
            // 
            // txtserverhopp
            // 
            resources.ApplyResources(this.txtserverhopp, "txtserverhopp");
            this.txtserverhopp.Name = "txtserverhopp";
            // 
            // Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnserver);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeldive);
            this.Controls.Add(this.labeldateofbirth);
            this.Controls.Add(this.labellastname);
            this.Controls.Add(this.txtserverhopp);
            this.Controls.Add(this.txtservername);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelfirstname);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtdive);
            this.Controls.Add(this.txtdataofbirht);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnserver;
        private System.Windows.Forms.TextBox txtservername;
        private System.Windows.Forms.TextBox txtserverhopp;
    }
}