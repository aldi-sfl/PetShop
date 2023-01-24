namespace PetShop
{
    partial class vendor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtidvendor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.btsimpan = new System.Windows.Forms.Button();
            this.bthapus = new System.Windows.Forms.Button();
            this.bthome = new System.Windows.Forms.Button();
            this.dgvvendor = new System.Windows.Forms.DataGridView();
            this.btshow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendor)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "form Supplier barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(54, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "id vendor";
            // 
            // txtidvendor
            // 
            this.txtidvendor.Location = new System.Drawing.Point(210, 67);
            this.txtidvendor.Name = "txtidvendor";
            this.txtidvendor.Size = new System.Drawing.Size(271, 23);
            this.txtidvendor.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "nama vendor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "no hp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "alamat";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(210, 117);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(271, 23);
            this.txtnama.TabIndex = 14;
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(210, 166);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(271, 23);
            this.txthp.TabIndex = 14;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(210, 209);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(271, 23);
            this.txtalamat.TabIndex = 14;
            // 
            // btsimpan
            // 
            this.btsimpan.Location = new System.Drawing.Point(534, 274);
            this.btsimpan.Name = "btsimpan";
            this.btsimpan.Size = new System.Drawing.Size(75, 23);
            this.btsimpan.TabIndex = 15;
            this.btsimpan.Text = "simpan";
            this.btsimpan.UseVisualStyleBackColor = true;
            this.btsimpan.Click += new System.EventHandler(this.btsimpan_Click);
            // 
            // bthapus
            // 
            this.bthapus.Location = new System.Drawing.Point(141, 274);
            this.bthapus.Name = "bthapus";
            this.bthapus.Size = new System.Drawing.Size(75, 23);
            this.bthapus.TabIndex = 15;
            this.bthapus.Text = "hapus";
            this.bthapus.UseVisualStyleBackColor = true;
            // 
            // bthome
            // 
            this.bthome.Location = new System.Drawing.Point(700, 56);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(75, 23);
            this.bthome.TabIndex = 16;
            this.bthome.Text = "home";
            this.bthome.UseVisualStyleBackColor = true;
            this.bthome.Click += new System.EventHandler(this.bthome_Click);
            // 
            // dgvvendor
            // 
            this.dgvvendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvendor.Location = new System.Drawing.Point(210, 315);
            this.dgvvendor.Name = "dgvvendor";
            this.dgvvendor.RowTemplate.Height = 25;
            this.dgvvendor.Size = new System.Drawing.Size(476, 123);
            this.dgvvendor.TabIndex = 17;
            // 
            // btshow
            // 
            this.btshow.Location = new System.Drawing.Point(363, 274);
            this.btshow.Name = "btshow";
            this.btshow.Size = new System.Drawing.Size(75, 23);
            this.btshow.TabIndex = 18;
            this.btshow.Text = "show";
            this.btshow.UseVisualStyleBackColor = true;
            this.btshow.Click += new System.EventHandler(this.btshow_Click);
            // 
            // vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btshow);
            this.Controls.Add(this.dgvvendor);
            this.Controls.Add(this.bthome);
            this.Controls.Add(this.bthapus);
            this.Controls.Add(this.btsimpan);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txthp);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtidvendor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Name = "vendor";
            this.Text = "vendor";
            this.Load += new System.EventHandler(this.vendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label8;
        private TextBox txtidvendor;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtnama;
        private TextBox txthp;
        private TextBox txtalamat;
        private Button btsimpan;
        private Button bthapus;
        private Button bthome;
        private DataGridView dgvvendor;
        private Button btshow;
    }
}