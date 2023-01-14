namespace PetShop
{
    partial class dgv
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelet = new System.Windows.Forms.Button();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txtnomor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(274, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data User";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(603, 17);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(72, 22);
            this.btnKembali.TabIndex = 3;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(10, 190);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 29;
            this.dgvUser.Size = new System.Drawing.Size(679, 131);
            this.dgvUser.TabIndex = 4;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(160, 158);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(313, 158);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelet
            // 
            this.btndelet.Location = new System.Drawing.Point(467, 158);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(75, 23);
            this.btndelet.TabIndex = 7;
            this.btndelet.Text = "Delet";
            this.btndelet.UseVisualStyleBackColor = true;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(39, 72);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(100, 23);
            this.txtnama.TabIndex = 8;
            this.txtnama.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(204, 72);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(100, 23);
            this.txtalamat.TabIndex = 9;
            // 
            // txtnomor
            // 
            this.txtnomor.Location = new System.Drawing.Point(379, 72);
            this.txtnomor.Name = "txtnomor";
            this.txtnomor.Size = new System.Drawing.Size(100, 23);
            this.txtnomor.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nomor HP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Alamat";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(521, 72);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 23);
            this.txtpassword.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Username";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(39, 123);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 23);
            this.txtusername.TabIndex = 17;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(204, 123);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 23);
            this.txtemail.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Email";
            // 
            // dgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnomor);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dgv";
            this.Load += new System.EventHandler(this.DataUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnKembali;
        private DataGridView dgvUser;
        private Button btnsave;
        private Button btnedit;
        private Button btndelet;
        private TextBox txtnama;
        private TextBox txtalamat;
        private TextBox txtnomor;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtpassword;
        private Label label5;
        private Label label6;
        private TextBox txtusername;
        private TextBox txtemail;
        private Label label7;
    }
}