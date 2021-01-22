using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uas_pemrograman_komputer
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Visible = true;
            frm.Focus();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pContainer.Controls.Clear();

            formTambahPesanan frm = new formTambahPesanan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            pContainer.Controls.Add(frm);
            guna2PictureBox1.Visible = false;
            label1.Visible = false;
            frm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pContainer.Controls.Clear();

            formTambahItem frm = new formTambahItem() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            pContainer.Controls.Add(frm);
            frm.Show();
            guna2PictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            pContainer.Controls.Clear();

            formEditItem frm = new formEditItem() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            pContainer.Controls.Add(frm);
            guna2PictureBox1.Visible = false;
            label1.Visible = false;
            frm.Show();
        }

        private void btnHapusItem_Click(object sender, EventArgs e)
        {
            pContainer.Controls.Clear();

            formHapusItem frm = new formHapusItem() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            pContainer.Controls.Add(frm);
            guna2PictureBox1.Visible = false;
            label1.Visible = false;
            frm.Show();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            pContainer.Controls.Clear();

            Laporan lap = new Laporan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lap.FormBorderStyle = FormBorderStyle.None;
            pContainer.Controls.Add(lap);
            guna2PictureBox1.Visible = false;
            label1.Visible = false;
            lap.Show();


        }
    }
}
