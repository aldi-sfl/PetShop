namespace PetShop
{
    partial class add_customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.btsimpan = new System.Windows.Forms.Button();
            this.btkembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(130, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "tambahkan informasi customer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(51, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "id customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "no handphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "alamat";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(218, 98);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(85, 23);
            this.txtid.TabIndex = 15;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(218, 139);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(275, 23);
            this.txtnama.TabIndex = 15;
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(218, 181);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(275, 23);
            this.txthp.TabIndex = 15;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(218, 231);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(275, 23);
            this.txtalamat.TabIndex = 15;
            // 
            // btsimpan
            // 
            this.btsimpan.Location = new System.Drawing.Point(515, 318);
            this.btsimpan.Name = "btsimpan";
            this.btsimpan.Size = new System.Drawing.Size(97, 40);
            this.btsimpan.TabIndex = 16;
            this.btsimpan.Text = "selanjutnya";
            this.btsimpan.UseVisualStyleBackColor = true;
            this.btsimpan.Click += new System.EventHandler(this.btsimpan_Click);
            // 
            // btkembali
            // 
            this.btkembali.Location = new System.Drawing.Point(68, 318);
            this.btkembali.Name = "btkembali";
            this.btkembali.Size = new System.Drawing.Size(98, 38);
            this.btkembali.TabIndex = 17;
            this.btkembali.Text = "Kembali";
            this.btkembali.UseVisualStyleBackColor = true;
            this.btkembali.Click += new System.EventHandler(this.btkembali_Click);
            // 
            // add_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(692, 410);
            this.Controls.Add(this.btkembali);
            this.Controls.Add(this.btsimpan);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txthp);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Name = "add_customer";
            this.Text = "add_customer";
            this.Load += new System.EventHandler(this.add_customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label8;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtid;
        private TextBox txtnama;
        private TextBox txthp;
        private TextBox txtalamat;
        private Button btsimpan;
        private Button btkembali;
    }
}