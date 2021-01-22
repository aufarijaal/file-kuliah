namespace uas_pemrograman_komputer
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTambahPesanan = new Guna.UI2.WinForms.Guna2Button();
            this.btnTambahItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapusItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnLaporan = new Guna.UI2.WinForms.Guna2Button();
            this.pContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(28)))), ((int)(((byte)(53)))));
            this.guna2Panel1.Controls.Add(this.btnLogout);
            this.guna2Panel1.Controls.Add(this.btnLaporan);
            this.guna2Panel1.Controls.Add(this.btnHapusItem);
            this.guna2Panel1.Controls.Add(this.btnEditItem);
            this.guna2Panel1.Controls.Add(this.btnTambahItem);
            this.guna2Panel1.Controls.Add(this.btnTambahPesanan);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(200, 516);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnTambahPesanan
            // 
            this.btnTambahPesanan.BorderRadius = 20;
            this.btnTambahPesanan.CheckedState.Parent = this.btnTambahPesanan;
            this.btnTambahPesanan.CustomImages.Parent = this.btnTambahPesanan;
            this.btnTambahPesanan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(76)))), ((int)(((byte)(147)))));
            this.btnTambahPesanan.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPesanan.ForeColor = System.Drawing.Color.White;
            this.btnTambahPesanan.HoverState.Parent = this.btnTambahPesanan;
            this.btnTambahPesanan.Location = new System.Drawing.Point(12, 134);
            this.btnTambahPesanan.Name = "btnTambahPesanan";
            this.btnTambahPesanan.ShadowDecoration.Parent = this.btnTambahPesanan;
            this.btnTambahPesanan.Size = new System.Drawing.Size(208, 45);
            this.btnTambahPesanan.TabIndex = 0;
            this.btnTambahPesanan.Text = "TAMBAH PESANAN";
            this.btnTambahPesanan.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnTambahItem
            // 
            this.btnTambahItem.BorderRadius = 20;
            this.btnTambahItem.CheckedState.Parent = this.btnTambahItem;
            this.btnTambahItem.CustomImages.Parent = this.btnTambahItem;
            this.btnTambahItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(76)))), ((int)(((byte)(147)))));
            this.btnTambahItem.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahItem.ForeColor = System.Drawing.Color.White;
            this.btnTambahItem.HoverState.Parent = this.btnTambahItem;
            this.btnTambahItem.Location = new System.Drawing.Point(12, 185);
            this.btnTambahItem.Name = "btnTambahItem";
            this.btnTambahItem.ShadowDecoration.Parent = this.btnTambahItem;
            this.btnTambahItem.Size = new System.Drawing.Size(208, 45);
            this.btnTambahItem.TabIndex = 1;
            this.btnTambahItem.Text = "TAMBAH ITEM";
            this.btnTambahItem.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.BorderRadius = 20;
            this.btnEditItem.CheckedState.Parent = this.btnEditItem;
            this.btnEditItem.CustomImages.Parent = this.btnEditItem;
            this.btnEditItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(76)))), ((int)(((byte)(147)))));
            this.btnEditItem.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItem.ForeColor = System.Drawing.Color.White;
            this.btnEditItem.HoverState.Parent = this.btnEditItem;
            this.btnEditItem.Location = new System.Drawing.Point(12, 236);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.ShadowDecoration.Parent = this.btnEditItem;
            this.btnEditItem.Size = new System.Drawing.Size(208, 45);
            this.btnEditItem.TabIndex = 2;
            this.btnEditItem.Text = "EDIT ITEM";
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnHapusItem
            // 
            this.btnHapusItem.BorderRadius = 20;
            this.btnHapusItem.CheckedState.Parent = this.btnHapusItem;
            this.btnHapusItem.CustomImages.Parent = this.btnHapusItem;
            this.btnHapusItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(76)))), ((int)(((byte)(147)))));
            this.btnHapusItem.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusItem.ForeColor = System.Drawing.Color.White;
            this.btnHapusItem.HoverState.Parent = this.btnHapusItem;
            this.btnHapusItem.Location = new System.Drawing.Point(12, 287);
            this.btnHapusItem.Name = "btnHapusItem";
            this.btnHapusItem.ShadowDecoration.Parent = this.btnHapusItem;
            this.btnHapusItem.Size = new System.Drawing.Size(208, 45);
            this.btnHapusItem.TabIndex = 3;
            this.btnHapusItem.Text = "HAPUS ITEM";
            this.btnHapusItem.Click += new System.EventHandler(this.btnHapusItem_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BorderRadius = 20;
            this.btnLaporan.CheckedState.Parent = this.btnLaporan;
            this.btnLaporan.CustomImages.Parent = this.btnLaporan;
            this.btnLaporan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(76)))), ((int)(((byte)(147)))));
            this.btnLaporan.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.HoverState.Parent = this.btnLaporan;
            this.btnLaporan.Location = new System.Drawing.Point(12, 338);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.ShadowDecoration.Parent = this.btnLaporan;
            this.btnLaporan.Size = new System.Drawing.Size(208, 45);
            this.btnLaporan.TabIndex = 4;
            this.btnLaporan.Text = "LAPORAN";
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.Color.White;
            this.pContainer.Controls.Add(this.label1);
            this.pContainer.Controls.Add(this.guna2PictureBox1);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(200, 0);
            this.pContainer.Name = "pContainer";
            this.pContainer.ShadowDecoration.Parent = this.pContainer;
            this.pContainer.Size = new System.Drawing.Size(867, 516);
            this.pContainer.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 5;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.btnLogout.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Location = new System.Drawing.Point(50, 474);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(283, 108);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 300);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIDAK ADA MENU YANG DIPILIH";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1067, 516);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.guna2Panel1.ResumeLayout(false);
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTambahPesanan;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnLaporan;
        private Guna.UI2.WinForms.Guna2Button btnHapusItem;
        private Guna.UI2.WinForms.Guna2Button btnEditItem;
        private Guna.UI2.WinForms.Guna2Button btnTambahItem;
        private Guna.UI2.WinForms.Guna2Panel pContainer;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}