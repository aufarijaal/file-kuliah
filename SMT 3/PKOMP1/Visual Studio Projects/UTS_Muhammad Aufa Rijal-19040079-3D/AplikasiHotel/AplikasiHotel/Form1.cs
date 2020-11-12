using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pss.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = pss.Text; /* Untuk menampung nilai yang ada pada TextBox2 yang Name nya diubah menjadi pss */

            if (a.Equals("hotel"))
            {
                MessageBox.Show("Selamat, login telah berhasil!");
                hotel h = new hotel(); /* Instantiasi hotel atau mendefinisikan sebuah class baru */

                h.Show(); /* perintah untuk menampilkan hotel.cs */
                this.Hide(); // Untuk menyembunyikan form1
            }
            else
            {
                MessageBox.Show("Maaf, password salah");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nama.Text = "";
            pss.Text = "";
        }
    }
}
