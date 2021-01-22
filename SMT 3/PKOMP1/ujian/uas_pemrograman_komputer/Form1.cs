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
    public partial class Form1 : Form
    {
        string konekinKeDB = ("server=localhost;uid=root;database=cafe;pwd='';");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                btnLogin.Enabled = false;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            koneksi = new MySqlConnection(konekinKeDB);
            koneksi.Open();
            cmd = new MySqlCommand("SELECT username,password FROM users", koneksi);
            var reader = cmd.ExecuteReader();
            try
            {
                if (!string.IsNullOrWhiteSpace(txtusername.Text) && !string.IsNullOrWhiteSpace(txtpass.Text))
                {
                    while(reader.Read())
                    { 
                        if (reader["username"].ToString() == txtusername.Text && reader["password"].ToString() == txtpass.Text)
                        {
                            label2.ForeColor = Color.Green;
                            label2.Text = "berhasil login";
                            this.Hide();
                            Dashboard dashboard = new Dashboard();
                            dashboard.Focus();
                            dashboard.Visible = true;
                        }
                        else
                        {
                            label2.ForeColor = Color.Red;
                            label2.Text = "username atau password salah";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Isi username dan password");
                }
            }
            catch (Exception anu)
            {
                label2.Text = anu.Message;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtusername.Focus();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Hide();
            tambahUser tbh = new tambahUser();
            tbh.Visible = true;
            tbh.Focus();
        }
    }
}
