using DGVPrinterHelper;
using MySql.Data.MySqlClient;
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
    public partial class formTambahPesanan : Form
    {
        function fn = new function();
        String q, tanggal;
        DateTime date = new DateTime();
        public MySqlConnection koneksi;
        public MySqlDataAdapter adapter;
        public formTambahPesanan()
        {
            InitializeComponent();
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String category = cmbKategori.Text;
                q = "SELECT nama_menu FROM menu where kategori ='" + category.ToLower() + "'";
                showItemList(q);
            }
            catch (Exception anu)
            {
                MessageBox.Show(anu.Message);
            }
        }

        private void listMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBanyak.Value = 1;
            txtTotal.Text = "0";

            String txt = listMenu.GetItemText(listMenu.SelectedItem);
            txtNamaMenu.Text = txt;
            q = "SELECT harga_menu from menu where nama_menu = '" + txt + "'";
            DataSet ds = fn.getData(q);

            txtHargaMenu.Text = ds.Tables[0].Rows[0][0].ToString();
            Int64 quan = Int64.Parse(txtBanyak.Value.ToString());
            Int64 harga = Int64.Parse(txtHargaMenu.Text);
            txtTotal.Text = (quan * harga).ToString();
        }

        private void txtBanyak_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtBanyak.Value.ToString());
            Int64 harga = Int64.Parse(txtHargaMenu.Text);
            txtTotal.Text = (quan * harga).ToString();
        }
        protected int n, total = 0;
        int amount;

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if(guna2DataGridView1.SelectedRows.Count > 0) {
                    guna2DataGridView1.Rows.RemoveAt(guna2DataGridView1.SelectedRows[0].Index);
                    total -= amount;
                    subTotal.Text = "Rp. " + total;
                    guna2DataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Pilih baris yang ingin dihapus");
                }
                if(total == 0)
                {
                    MessageBox.Show("Pesanan kosong");
                    amount = 0;
                }
            }
            catch (Exception anu)
            {

            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Item yang ingin anda hapus kosong.");
                }
            }
            catch (NullReferenceException anu)
            {
                MessageBox.Show("Item yang ingin anda hapus kosong.");
            }
        }
        int counter;
        private void guna2Button3_Click(object sender, EventArgs e)
        {

            try
            {
                for (counter = 0; counter < guna2DataGridView1.Rows.Count - 1; counter++)
                {
                    q = $"INSERT INTO laporan (id, menu, harga, tanggal) VALUES (NULL, '{guna2DataGridView1.Rows[counter].Cells[0].Value}({guna2DataGridView1.Rows[counter].Cells[2].Value})', '{guna2DataGridView1.Rows[counter].Cells[3].Value}', '{DateTime.Now:yyyy-MM-dd HH:mm:ss}');";
                    fn.setData(q);
                }
            }
            catch (Exception anu)
            {
                MessageBox.Show(anu.Message);
            }

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Invoice Pelanggan";
            printer.SubTitle = string.Format("Tanggal {0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total tagihan = " + subTotal.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);

            printer.DocName = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss");
            total = 0;
            guna2DataGridView1.Rows.Clear();
            subTotal.Text = "Rp. " + total;

            //q = "INSERT INTO laporan (detail, total_harga) VALUES ('"++"', '120000');";
            //fn.setData(q);

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            String category = cmbKategori.Text;
            q = "SELECT nama_menu FROM menu where kategori ='" + category.ToLower() + "' and nama_menu like '%" + txtSearch.Text + "%'";
            showItemList(q);
        }

        private void formTambahPesanan_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        public void showItemList(String query)
        {
            listMenu.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listMenu.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnTambahKeKeranjang_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTotal.Text != "0" && txtTotal.Text != "" && txtHargaMenu.Text != "0" && txtNamaMenu.Text != "0")
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtNamaMenu.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtHargaMenu.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtBanyak.Value;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                    total += int.Parse(txtTotal.Text);
                    subTotal.Text = "Rp. " + total;
                    guna2DataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Lengkapi kolom pemesanan terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception anu)
            {
                MessageBox.Show("Lengkapi kolom pemesanan terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
