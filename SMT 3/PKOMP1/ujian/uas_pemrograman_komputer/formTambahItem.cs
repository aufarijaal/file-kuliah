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
    public partial class formTambahItem : Form
    {
        function fn = new function();
        String q, category, nama;
        int harga;
        public formTambahItem()
        {
            InitializeComponent();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            category = cmbAddItem.Text;
            nama = txtNamaItem.Text;
            harga = int.Parse(txtHargaItem.Text);
            try
            {
                q = "INSERT INTO menu (id, kategori, nama_menu, harga_menu) VALUES (NULL, '" + category + "', '" + nama + "', '" + harga + "');";
                fn.setData(q);
            }
            catch (Exception anu)
            {
                MessageBox.Show(anu.Message);
            }
        }

        private void txtNamaItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
