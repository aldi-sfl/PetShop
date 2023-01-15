namespace PetShop
{
    partial class nota
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
            this.labelusername = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btexit = new System.Windows.Forms.Button();
            this.dgvnota = new System.Windows.Forms.DataGridView();
            this.ldidorder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnota)).BeginInit();
            this.SuspendLayout();
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelusername.Location = new System.Drawing.Point(363, 72);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(83, 17);
            this.labelusername.TabIndex = 4;
            this.labelusername.Text = "username :";
            this.labelusername.Click += new System.EventHandler(this.labelusername_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(376, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "nota";
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(704, 339);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 6;
            this.btexit.Text = "exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // dgvnota
            // 
            this.dgvnota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnota.Location = new System.Drawing.Point(157, 128);
            this.dgvnota.Name = "dgvnota";
            this.dgvnota.RowTemplate.Height = 25;
            this.dgvnota.Size = new System.Drawing.Size(504, 163);
            this.dgvnota.TabIndex = 7;
            // 
            // ldidorder
            // 
            this.ldidorder.AutoSize = true;
            this.ldidorder.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ldidorder.Location = new System.Drawing.Point(374, 90);
            this.ldidorder.Name = "ldidorder";
            this.ldidorder.Size = new System.Drawing.Size(56, 17);
            this.ldidorder.TabIndex = 4;
            this.ldidorder.Text = "orderid";
            // 
            // nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvnota);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ldidorder);
            this.Controls.Add(this.labelusername);
            this.Name = "nota";
            this.Text = "nota";
            this.Load += new System.EventHandler(this.nota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelusername;
        private Label label7;
        private Button btexit;
        private DataGridView dgvnota;
        private Label ldidorder;
    }
}