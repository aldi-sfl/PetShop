﻿namespace PetShop
{
    partial class DataUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidcustomer = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.btsimpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(247, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "data customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "idcustomer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(66, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "no hp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(66, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "alamat";
            // 
            // txtidcustomer
            // 
            this.txtidcustomer.Location = new System.Drawing.Point(219, 68);
            this.txtidcustomer.Name = "txtidcustomer";
            this.txtidcustomer.Size = new System.Drawing.Size(100, 23);
            this.txtidcustomer.TabIndex = 19;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(219, 112);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(235, 23);
            this.txtnama.TabIndex = 19;
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(219, 151);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(235, 23);
            this.txthp.TabIndex = 19;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(219, 187);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(235, 23);
            this.txtalamat.TabIndex = 19;
            // 
            // btsimpan
            // 
            this.btsimpan.Location = new System.Drawing.Point(531, 230);
            this.btsimpan.Name = "btsimpan";
            this.btsimpan.Size = new System.Drawing.Size(75, 23);
            this.btsimpan.TabIndex = 20;
            this.btsimpan.Text = "button1";
            this.btsimpan.UseVisualStyleBackColor = true;
            // 
            // DataUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(636, 289);
            this.Controls.Add(this.btsimpan);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txthp);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtidcustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DataUser";
            this.Text = "DataUser";
            this.Load += new System.EventHandler(this.DataUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtidcustomer;
        private TextBox txtnama;
        private TextBox txthp;
        private TextBox txtalamat;
        private Button btsimpan;
    }
}