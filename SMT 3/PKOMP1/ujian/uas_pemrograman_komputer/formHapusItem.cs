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

    public partial class formHapusItem : Form
    {
        function fn = new function();
        String q;
        public formHapusItem()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            q = "SELECT * FROM menu";
            DataSet ds = fn.getData(q);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void formHapusItem_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            q = "SELECT * FROM menu WHERE nama_menu LIKE '%" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(q);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus menu ini?", "Hapus Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                q = "DELETE FROM menu WHERE id = " + id;
                fn.setData(q);
                loadData();
            }
        }
    }
}
