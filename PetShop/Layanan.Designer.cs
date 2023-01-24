namespace PetShop
{
    partial class Layanan
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnext = new System.Windows.Forms.Button();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtPet = new System.Windows.Forms.TextBox();
            this.txtRas = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.noid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(226, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Daftarkan Hewan";
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(594, 227);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(88, 23);
            this.btnext.TabIndex = 11;
            this.btnext.Text = "selanjutnya";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(268, 179);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(348, 23);
            this.txtCustomer.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pet Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(66, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(67, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Customer Id";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(268, 115);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(348, 23);
            this.txtname.TabIndex = 19;
            // 
            // txtPet
            // 
            this.txtPet.Location = new System.Drawing.Point(269, 82);
            this.txtPet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPet.Name = "txtPet";
            this.txtPet.Size = new System.Drawing.Size(347, 23);
            this.txtPet.TabIndex = 12;
            this.txtPet.TextChanged += new System.EventHandler(this.txtPet_TextChanged);
            // 
            // txtRas
            // 
            this.txtRas.Location = new System.Drawing.Point(268, 146);
            this.txtRas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRas.Name = "txtRas";
            this.txtRas.Size = new System.Drawing.Size(348, 23);
            this.txtRas.TabIndex = 20;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(290, 239);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 21);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Text = "Username";
            // 
            // noid
            // 
            this.noid.AutoSize = true;
            this.noid.Location = new System.Drawing.Point(401, 242);
            this.noid.Name = "noid";
            this.noid.Size = new System.Drawing.Size(38, 15);
            this.noid.TabIndex = 23;
            this.noid.Text = "label5";
            // 
            // Layanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(711, 276);
            this.Controls.Add(this.noid);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtRas);
            this.Controls.Add(this.txtPet);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Layanan";
            this.Text = "Layanan";
            this.Load += new System.EventHandler(this.Layanan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Button btnext;
        private TextBox txtCustomer;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtname;
        private TextBox txtPet;
        private TextBox txtRas;
        private Label lblUsername;
        private Label noid;
    }
}