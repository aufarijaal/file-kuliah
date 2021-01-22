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
    public partial class formEditItem : Form
    {
        function fn = new function();
        String query;
        public formEditItem()
        {
            InitializeComponent();
        }

        private void formEditItem_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = "SELECT * FROM menu";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM menu WHERE nama_menu LIKE '%" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String c = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            String nama_menu = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            int harga = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtKategori.Text = c;
            txtNamaMenu.Text = nama_menu;
            txtHarga.Text = harga.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                query = "UPDATE menu SET nama_menu = '" + txtNamaMenu.Text + "', kategori = '" + txtKategori.Text + "', harga_menu = " + txtHarga.Text + " WHERE id = " + id;
                fn.setData(query);
                loadData();
            }
            catch (Exception anu)
            {
                MessageBox.Show(anu.Message);
            }
        }
    }
}
