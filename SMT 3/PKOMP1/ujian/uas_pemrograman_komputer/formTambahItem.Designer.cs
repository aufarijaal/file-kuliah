namespace uas_pemrograman_komputer
{
    partial class formTambahItem
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
            this.btnAddNewItem = new Guna.UI2.WinForms.Guna2Button();
            this.txtNamaItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHargaItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbAddItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAMBAH ITEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga";
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.BorderRadius = 10;
            this.btnAddNewItem.CheckedState.Parent = this.btnAddNewItem;
            this.btnAddNewItem.CustomImages.Parent = this.btnAddNewItem;
            this.btnAddNewItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(76)))), ((int)(((byte)(147)))));
            this.btnAddNewItem.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewItem.ForeColor = System.Drawing.Color.White;
            this.btnAddNewItem.HoverState.Parent = this.btnAddNewItem;
            this.btnAddNewItem.Location = new System.Drawing.Point(348, 330);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.ShadowDecoration.Parent = this.btnAddNewItem;
            this.btnAddNewItem.Size = new System.Drawing.Size(180, 45);
            this.btnAddNewItem.TabIndex = 4;
            this.btnAddNewItem.Text = "TAMBAHKAN";
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // txtNamaItem
            // 
            this.txtNamaItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaItem.DefaultText = "";
            this.txtNamaItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaItem.DisabledState.Parent = this.txtNamaItem;
            this.txtNamaItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaItem.FocusedState.Parent = this.txtNamaItem;
            this.txtNamaItem.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaItem.ForeColor = System.Drawing.Color.Black;
            this.txtNamaItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaItem.HoverState.Parent = this.txtNamaItem;
            this.txtNamaItem.Location = new System.Drawing.Point(280, 222);
            this.txtNamaItem.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtNamaItem.Name = "txtNamaItem";
            this.txtNamaItem.PasswordChar = '\0';
            this.txtNamaItem.PlaceholderText = "";
            this.txtNamaItem.SelectedText = "";
            this.txtNamaItem.ShadowDecoration.Parent = this.txtNamaItem;
            this.txtNamaItem.Size = new System.Drawing.Size(302, 31);
            this.txtNamaItem.TabIndex = 6;
            this.txtNamaItem.TextChanged += new System.EventHandler(this.txtNamaItem_TextChanged);
            // 
            // txtHargaItem
            // 
            this.txtHargaItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHargaItem.DefaultText = "";
            this.txtHargaItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHargaItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHargaItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHargaItem.DisabledState.Parent = this.txtHargaItem;
            this.txtHargaItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHargaItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHargaItem.FocusedState.Parent = this.txtHargaItem;
            this.txtHargaItem.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHargaItem.ForeColor = System.Drawing.Color.Black;
            this.txtHargaItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHargaItem.HoverState.Parent = this.txtHargaItem;
            this.txtHargaItem.Location = new System.Drawing.Point(280, 285);
            this.txtHargaItem.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtHargaItem.Name = "txtHargaItem";
            this.txtHargaItem.PasswordChar = '\0';
            this.txtHargaItem.PlaceholderText = "";
            this.txtHargaItem.SelectedText = "";
            this.txtHargaItem.ShadowDecoration.Parent = this.txtHargaItem;
            this.txtHargaItem.Size = new System.Drawing.Size(302, 31);
            this.txtHargaItem.TabIndex = 7;
            // 
            // cmbAddItem
            // 
            this.cmbAddItem.BackColor = System.Drawing.Color.Transparent;
            this.cmbAddItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAddItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddItem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAddItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAddItem.FocusedState.Parent = this.cmbAddItem;
            this.cmbAddItem.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.cmbAddItem.ForeColor = System.Drawing.Color.Black;
            this.cmbAddItem.HoverState.Parent = this.cmbAddItem;
            this.cmbAddItem.ItemHeight = 30;
            this.cmbAddItem.Items.AddRange(new object[] {
            "Makanan",
            "Minuman"});
            this.cmbAddItem.ItemsAppearance.Parent = this.cmbAddItem;
            this.cmbAddItem.Location = new System.Drawing.Point(280, 154);
            this.cmbAddItem.Name = "cmbAddItem";
            this.cmbAddItem.ShadowDecoration.Parent = this.cmbAddItem;
            this.cmbAddItem.Size = new System.Drawing.Size(302, 36);
            this.cmbAddItem.TabIndex = 8;
            // 
            // formTambahItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 516);
            this.ControlBox = false;
            this.Controls.Add(this.cmbAddItem);
            this.Controls.Add(this.txtHargaItem);
            this.Controls.Add(this.txtNamaItem);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTambahItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "formTambahPesanan";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnAddNewItem;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaItem;
        private Guna.UI2.WinForms.Guna2TextBox txtHargaItem;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAddItem;
    }
}