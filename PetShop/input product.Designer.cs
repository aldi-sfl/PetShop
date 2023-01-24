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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtcari = new System.Windows.Forms.ToolStripTextBox();
            this.btcari = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label7 = new System.Windows.Forms.Label();
            this.cbvendor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduk)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(329, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(32, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "id produk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "nama produk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(393, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(393, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "jumlah produk";
            // 
            // txtidproduk
            // 
            this.txtidproduk.Location = new System.Drawing.Point(186, 149);
            this.txtidproduk.Name = "txtidproduk";
            this.txtidproduk.Size = new System.Drawing.Size(182, 23);
            this.txtidproduk.TabIndex = 1;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(186, 187);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(182, 23);
            this.txtnama.TabIndex = 3;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(547, 176);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(167, 23);
            this.txtharga.TabIndex = 4;
            this.txtharga.TextChanged += new System.EventHandler(this.txtharga_TextChanged);
            this.txtharga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtharga_KeyPress);
            // 
            // txtjumlah
            // 
            this.txtjumlah.Location = new System.Drawing.Point(547, 136);
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(167, 23);
            this.txtjumlah.TabIndex = 5;
            this.txtjumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtjumlah_KeyPress);
            // 
            // dgvproduk
            // 
            this.dgvproduk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduk.Location = new System.Drawing.Point(93, 325);
            this.dgvproduk.Name = "dgvproduk";
            this.dgvproduk.RowHeadersWidth = 51;
            this.dgvproduk.RowTemplate.Height = 25;
            this.dgvproduk.Size = new System.Drawing.Size(621, 220);
            this.dgvproduk.TabIndex = 9;
            this.dgvproduk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduk_CellClick);
            this.dgvproduk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduk_CellContentClick);
            // 
            // btupdate
            // 
            this.btupdate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btupdate.Location = new System.Drawing.Point(293, 267);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 99;
            this.btupdate.Text = "update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btinsert
            // 
            this.btinsert.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btinsert.Location = new System.Drawing.Point(186, 267);
            this.btinsert.Name = "btinsert";
            this.btinsert.Size = new System.Drawing.Size(75, 23);
            this.btinsert.TabIndex = 6;
            this.btinsert.Text = "insert";
            this.btinsert.UseVisualStyleBackColor = true;
            this.btinsert.Click += new System.EventHandler(this.btinsert_Click);
            // 
            // btdelete
            // 
            this.btdelete.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btdelete.Location = new System.Drawing.Point(405, 267);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 89;
            this.btdelete.Text = "delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btreset
            // 
            this.btreset.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btreset.Location = new System.Drawing.Point(513, 267);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 23);
            this.btreset.TabIndex = 67;
            this.btreset.Text = "reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(32, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kategori";
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Items.AddRange(new object[] {
            "-",
            "Pakan",
            "Alat-alat"});
            this.cbkategori.Location = new System.Drawing.Point(186, 75);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(182, 23);
            this.cbkategori.TabIndex = 2;
            this.cbkategori.SelectedIndexChanged += new System.EventHandler(this.cbkategori_SelectedIndexChanged);
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btexit.Location = new System.Drawing.Point(713, 12);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 8;
            this.btexit.Text = "keluar";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(144, 24);
            this.toolStripLabel1.Text = "Cari Produk atau kategori";
            // 
            // txtcari
            // 
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(100, 27);
            this.txtcari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcari_KeyPress);
            this.txtcari.Click += new System.EventHandler(this.txtcari_Click);
            // 
            // btcari
            // 
            this.btcari.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btcari.Image = ((System.Drawing.Image)(resources.GetObject("btcari.Image")));
            this.btcari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(24, 24);
            this.btcari.Text = "toolStripButton1";
            this.btcari.Click += new System.EventHandler(this.btcari_Click);
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
            this.toolStrip1.Location = new System.Drawing.Point(261, 222);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(282, 27);
            this.toolStrip1.TabIndex = 100;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(32, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "vendor";
            // 
            // cbvendor
            // 
            this.cbvendor.FormattingEnabled = true;
            this.cbvendor.Location = new System.Drawing.Point(186, 110);
            this.cbvendor.Name = "cbvendor";
            this.cbvendor.Size = new System.Drawing.Size(182, 23);
            this.cbvendor.TabIndex = 101;
            this.cbvendor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.cbvendor);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "order";
            this.Text = "order";
            this.Load += new System.EventHandler(this.order_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.order_KeyPress);
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
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtcari;
        private ToolStripButton btcari;
        private ToolStrip toolStrip1;
        private Label label7;
        private ComboBox cbvendor;
    }
}