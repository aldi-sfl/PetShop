namespace PetShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataUser));
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.btntampil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.btexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvds
            // 
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Location = new System.Drawing.Point(23, 72);
            this.dgvds.Name = "dgvds";
            this.dgvds.RowHeadersWidth = 62;
            this.dgvds.RowTemplate.Height = 33;
            this.dgvds.Size = new System.Drawing.Size(874, 336);
            this.dgvds.TabIndex = 0;
            this.dgvds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvds_CellContentClick);
            // 
            // btntampil
            // 
            this.btntampil.Location = new System.Drawing.Point(92, 15);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(176, 51);
            this.btntampil.TabIndex = 1;
            this.btntampil.Text = "TAMPIL";
            this.btntampil.UseVisualStyleBackColor = true;
            this.btntampil.Click += new System.EventHandler(this.btntampil_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(840, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 52);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcari
            // 
            this.txtcari.Location = new System.Drawing.Point(691, 25);
            this.txtcari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(141, 31);
            this.txtcari.TabIndex = 14;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(779, 416);
            this.btexit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(107, 38);
            this.btexit.TabIndex = 18;
            this.btexit.Text = "keluar";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // DataUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(909, 460);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntampil);
            this.Controls.Add(this.dgvds);
            this.Name = "DataUser";
            this.Text = "DataUser";
            this.Load += new System.EventHandler(this.DataUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvds;
        private Button btntampil;
        private Button button1;
        private TextBox txtcari;
        private Button btexit;
    }
}