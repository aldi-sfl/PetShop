﻿namespace PetShop
{
    partial class register
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btsave = new System.Windows.Forms.Button();
            this.btcanccel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btrng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(86, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(86, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "email";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(241, 125);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(397, 27);
            this.txtnama.TabIndex = 1;
            this.txtnama.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(86, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password";
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(241, 167);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(397, 27);
            this.txtalamat.TabIndex = 2;
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(241, 211);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(397, 27);
            this.txthp.TabIndex = 3;
            this.txthp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthp_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(241, 253);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(397, 27);
            this.txtemail.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(242, 299);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(397, 27);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // btsave
            // 
            this.btsave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btsave.Location = new System.Drawing.Point(121, 355);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(117, 53);
            this.btsave.TabIndex = 6;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btcanccel
            // 
            this.btcanccel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcanccel.Location = new System.Drawing.Point(489, 355);
            this.btcanccel.Name = "btcanccel";
            this.btcanccel.Size = new System.Drawing.Size(117, 53);
            this.btcanccel.TabIndex = 7;
            this.btcanccel.Text = "Back";
            this.btcanccel.UseVisualStyleBackColor = true;
            this.btcanccel.Click += new System.EventHandler(this.btcanccel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(86, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(242, 81);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(82, 27);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            // 
            // btrng
            // 
            this.btrng.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btrng.Location = new System.Drawing.Point(349, 81);
            this.btrng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btrng.Name = "btrng";
            this.btrng.Size = new System.Drawing.Size(113, 31);
            this.btrng.TabIndex = 0;
            this.btrng.Text = "generate new id";
            this.btrng.UseVisualStyleBackColor = true;
            this.btrng.Click += new System.EventHandler(this.btrng_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(701, 451);
            this.Controls.Add(this.btrng);
            this.Controls.Add(this.btcanccel);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txthp);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "register";
            this.Text = "Name";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtnama;
        private Label label6;
        private TextBox txtalamat;
        private TextBox txthp;
        private TextBox txtemail;
        private TextBox txtpassword;
        private Button btsave;
        private Button btcanccel;
        private Label label7;
        private TextBox txtId;
        private Button btrng;
    }
}