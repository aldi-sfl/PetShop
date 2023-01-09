namespace PetShop
{
    partial class order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order));
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidproduk = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtjumlah = new System.Windows.Forms.TextBox();
            this.dgvproduk = new System.Windows.Forms.DataGridView();
            this.btupdate = new System.Windows.Forms.Button();
            this.btinsert = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.btexit = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtcari = new System.Windows.Forms.ToolStripTextBox();
            this.btcari = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduk)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(376, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(78, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "product id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "nama produk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(451, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(451, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "jumlah";
            // 
            // txtidproduk
            // 
            this.txtidproduk.Location = new System.Drawing.Point(254, 83);
            this.txtidproduk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtidproduk.Name = "txtidproduk";
            this.txtidproduk.Size = new System.Drawing.Size(159, 27);
            this.txtidproduk.TabIndex = 1;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(254, 169);
            this.txtnama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(159, 27);
            this.txtnama.TabIndex = 3;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(627, 88);
            this.txtharga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(159, 27);
            this.txtharga.TabIndex = 4;
            this.txtharga.TextChanged += new System.EventHandler(this.txtharga_TextChanged);
            this.txtharga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtharga_KeyPress);
            // 
            // txtjumlah
            // 
            this.txtjumlah.Location = new System.Drawing.Point(627, 137);
            this.txtjumlah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(159, 27);
            this.txtjumlah.TabIndex = 5;
            // 
            // dgvproduk
            // 
            this.dgvproduk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduk.Location = new System.Drawing.Point(106, 336);
            this.dgvproduk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvproduk.Name = "dgvproduk";
            this.dgvproduk.RowHeadersWidth = 51;
            this.dgvproduk.RowTemplate.Height = 25;
            this.dgvproduk.Size = new System.Drawing.Size(710, 281);
            this.dgvproduk.TabIndex = 9;
            // 
            // btupdate
            // 
            this.btupdate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btupdate.Location = new System.Drawing.Point(337, 275);
            this.btupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(86, 31);
            this.btupdate.TabIndex = 99;
            this.btupdate.Text = "update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btinsert
            // 
            this.btinsert.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btinsert.Location = new System.Drawing.Point(215, 275);
            this.btinsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btinsert.Name = "btinsert";
            this.btinsert.Size = new System.Drawing.Size(86, 31);
            this.btinsert.TabIndex = 6;
            this.btinsert.Text = "insert";
            this.btinsert.UseVisualStyleBackColor = true;
            this.btinsert.Click += new System.EventHandler(this.btinsert_Click);
            // 
            // btdelete
            // 
            this.btdelete.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btdelete.Location = new System.Drawing.Point(465, 275);
            this.btdelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(86, 31);
            this.btdelete.TabIndex = 89;
            this.btdelete.Text = "delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btreset
            // 
            this.btreset.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btreset.Location = new System.Drawing.Point(589, 275);
            this.btreset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(86, 31);
            this.btreset.TabIndex = 67;
            this.btreset.Text = "reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(78, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kategori";
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Items.AddRange(new object[] {
            "-",
            "Hewan",
            "Pakan",
            "Alat-alat",
            "Layanan"});
            this.cbkategori.Location = new System.Drawing.Point(254, 129);
            this.cbkategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(159, 28);
            this.cbkategori.TabIndex = 2;
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btexit.Location = new System.Drawing.Point(815, 16);
            this.btexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(86, 31);
            this.btexit.TabIndex = 8;
            this.btexit.Text = "keluar";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
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
            this.toolStrip1.Location = new System.Drawing.Point(289, 217);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(323, 27);
            this.toolStrip1.TabIndex = 100;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(165, 24);
            this.toolStripLabel1.Text = "Cari data atau kategori";
            // 
            // txtcari
            // 
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(114, 27);
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
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(914, 633);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.cbkategori);
            this.Controls.Add(this.btinsert);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.dgvproduk);
            this.Controls.Add(this.txtjumlah);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtidproduk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "order";
            this.Text = "order";
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduk)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label8;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtidproduk;
        private TextBox txtnama;
        private TextBox txtharga;
        private TextBox txtjumlah;
        private DataGridView dgvproduk;
        private Button btupdate;
        private Button btinsert;
        private Button btdelete;
        private Button btreset;
        private Label label5;
        private ComboBox cbkategori;
        private Button btexit;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtcari;
        private ToolStripButton btcari;
    }
}