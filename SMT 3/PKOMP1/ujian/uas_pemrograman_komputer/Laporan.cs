using DGVPrinterHelper;
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
    public partial class Laporan : Form
    {
        function fn = new function();
        String q;
        public Laporan()
        {
            InitializeComponent();
        }

        private void tableLaporan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            q = "SELECT * FROM laporan";
            DataSet ds = fn.getData(q);
            tableLaporan.DataSource = ds.Tables[0];
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "LAPORAN PENJUALAN";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(tableLaporan);
        }
    }
}
