using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = txtPass.Text;
            string username = txtuser.Text;

            if (pass.Equals("admin") && username.Equals("admin"))
            {
                MessageBox.Show("Login Berhasil!");
                form2 f = new form2();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf, Username atau Password salah")
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtuser.Text = "";
        }
    }
}
