namespace PetShop
{
    partial class input_hewan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(input_hewan));
            this.cbvendor = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtcari = new System.Windows.Forms.ToolStripTextBox();
            this.btcari = new System.Windows.Forms.ToolStripButton();
            this.btexit = new System.Windows.Forms.Button();
            this.cbhewan = new System.Windows.Forms.ComboBox();
            this.btinsert = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.txtjumlah = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtidhewan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvhewan = new System.Windows.Forms.DataGridView();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhewan)).BeginInit();
            this.SuspendLayout();
            // 
            // cbvendor
            // 
            this.cbvendor.FormattingEnabled = true;
            this.cbvendor.Location = new System.Drawing.Point(243, 163);
            this.cbvendor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbvendor.Name = "cbvendor";
            this.cbvendor.Size = new System.Drawing.Size(207, 28);
            this.cbvendor.TabIndex = 121;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtcari,
            this.btcari});
            this.toolStrip1.Location = new System.Drawing.Point(329, 312);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(322, 27);
            this.toolStrip1.TabIndex = 120;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(180, 24);
            this.toolStripLabel1.Text = "Cari Produk atau kategori";
            // 
            // txtcari
            // 
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(100, 27);
            // 
            // btcari
            // 
            this.btcari.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btcari.Image = ((System.Drawing.Image)(resources.GetObject("btcari.Image")));
            this.btcari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(29, 24);
            this.btcari.Text = "toolStripButton1";
            this.btcari.Click += new System.EventHandler(this.btcari_Click);
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btexit.Location = new System.Drawing.Point(846, 32);
            this.btexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(86, 31);
            this.btexit.TabIndex = 115;
            this.btexit.Text = "keluar";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // cbhewan
            // 
            this.cbhewan.FormattingEnabled = true;
            this.cbhewan.Items.AddRange(new object[] {
            "-",
            "Burung",
            "Kucing",
            "Anjing",
            "Kelinci",
            "Hamster"});
            this.cbhewan.Location = new System.Drawing.Point(243, 116);
            this.cbhewan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbhewan.Name = "cbhewan";
            this.cbhewan.Size = new System.Drawing.Size(207, 28);
            this.cbhewan.TabIndex = 106;
            this.cbhewan.SelectedIndexChanged += new System.EventHandler(this.cbhewan_SelectedIndexChanged);
            // 
            // btinsert
            // 
            this.btinsert.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btinsert.Location = new System.Drawing.Point(243, 372);
            this.btinsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btinsert.Name = "btinsert";
            this.btinsert.Size = new System.Drawing.Size(86, 31);
            this.btinsert.TabIndex = 114;
            this.btinsert.Text = "insert";
            this.btinsert.UseVisualStyleBackColor = true;
            this.btinsert.Click += new System.EventHandler(this.btinsert_Click);
            // 
            // btreset
            // 
            this.btreset.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btreset.Location = new System.Drawing.Point(617, 372);
            this.btreset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(86, 31);
            this.btreset.TabIndex = 117;
            this.btreset.Text = "reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btdelete
            // 
            this.btdelete.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btdelete.Location = new System.Drawing.Point(494, 372);
            this.btdelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(86, 31);
            this.btdelete.TabIndex = 118;
            this.btdelete.Text = "delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btupdate
            // 
            this.btupdate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btupdate.Location = new System.Drawing.Point(366, 372);
            this.btupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(86, 31);
            this.btupdate.TabIndex = 119;
            this.btupdate.Text = "update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // txtjumlah
            // 
            this.txtjumlah.Location = new System.Drawing.Point(656, 197);
            this.txtjumlah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(190, 27);
            this.txtjumlah.TabIndex = 113;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(656, 251);
            this.txtharga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(190, 27);
            this.txtharga.TabIndex = 112;
            // 
            // txtidhewan
            // 
            this.txtidhewan.Location = new System.Drawing.Point(243, 215);
            this.txtidhewan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtidhewan.Name = "txtidhewan";
            this.txtidhewan.Size = new System.Drawing.Size(207, 27);
            this.txtidhewan.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(480, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 109;
            this.label4.Text = "jumlah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(480, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 108;
            this.label3.Text = "harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(67, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 107;
            this.label7.Text = "id vendor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(67, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 29);
            this.label5.TabIndex = 105;
            this.label5.Text = "jenis hewan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 104;
            this.label2.Text = "gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(67, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 29);
            this.label8.TabIndex = 110;
            this.label8.Text = "id hewan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(407, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 40);
            this.label1.TabIndex = 102;
            this.label1.Text = "input hewan";
            // 
            // dgvhewan
            // 
            this.dgvhewan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhewan.Location = new System.Drawing.Point(114, 431);
            this.dgvhewan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvhewan.Name = "dgvhewan";
            this.dgvhewan.RowHeadersWidth = 51;
            this.dgvhewan.RowTemplate.Height = 25;
            this.dgvhewan.Size = new System.Drawing.Size(721, 316);
            this.dgvhewan.TabIndex = 122;
            this.dgvhewan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhewan_CellContentClick);
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "-",
            "Jantan",
            "Betina"});
            this.cbgender.Location = new System.Drawing.Point(243, 271);
            this.cbgender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(207, 28);
            this.cbgender.TabIndex = 123;
            // 
            // input_hewan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(990, 821);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.dgvhewan);
            this.Controls.Add(this.cbvendor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.cbhewan);
            this.Controls.Add(this.btinsert);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.txtjumlah);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.txtidhewan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "input_hewan";
            this.Text = "input_hewan";
            this.Load += new System.EventHandler(this.input_hewan_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhewan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbvendor;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtcari;
        private ToolStripButton btcari;
        private Button btexit;
        private ComboBox cbhewan;
        private Button btinsert;
        private Button btreset;
        private Button btdelete;
        private Button btupdate;
        private TextBox txtjumlah;
        private TextBox txtharga;
        private TextBox txtidhewan;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label5;
        private Label label2;
        private Label label8;
        private Label label1;
        private DataGridView dgvhewan;
        private ComboBox cbgender;
    }
}