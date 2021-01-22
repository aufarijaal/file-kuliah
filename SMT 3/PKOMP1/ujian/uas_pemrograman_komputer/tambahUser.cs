using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace uas_pemrograman_komputer
{
    public partial class tambahUser : Form
    {
        string konekinKeDB = ("server=localhost;uid=root;database=cafe;pwd='';");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public tambahUser()
        {
            InitializeComponent();
        }

        private void tambahUser_Load(object sender, EventArgs e)
        {
            koneksi = new MySqlConnection(konekinKeDB);
            try
            {
                koneksi.Open();
                if (koneksi.State == System.Data.ConnectionState.Open){
                    label2.ForeColor = Color.Green;
                    label2.Text = "koneksi ke DB berhasil";
                }
            }
            catch (Exception anu)
            {
                label2.ForeColor = Color.Red;
                label2.Text = anu.Message;
                txtpass.Enabled = false;
                txtusername.Enabled = false;
                btnTambahUser.Enabled = false;
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tambahUser_Shown(object sender, EventArgs e)
        {
            txtusername.Focus();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnTambahUser_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f = new Form1();
                koneksi = new MySqlConnection(konekinKeDB);
                koneksi.Open();
                cmd = new MySqlCommand("INSERT INTO users (id, username, password) VALUES (NULL, '" + txtusername.Text + "', '" + txtpass.Text + "');", koneksi);
                cmd.ExecuteNonQuery();

                MessageBox.Show("User berhasil ditambahkan");

                f.Visible = true;
                f.Focus();
                Hide();
            }
            catch (Exception anu)
            {
                label2.Text = anu.Message;
            }
        }
    }
}
