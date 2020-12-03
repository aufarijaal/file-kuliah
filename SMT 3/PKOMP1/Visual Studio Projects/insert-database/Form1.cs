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

namespace insert_database
{
    public partial class Form1 : Form
    {
        string database = ("server = localhost; uid = root; database = sekolah; pwd = '';");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public Form1()
        {
            InitializeComponent();
        }

        public void konek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Open();
        }
        public void diskonek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Close();
        }
        public DataTable baca()
        {
            string sql = "select * from siswa";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception anu)
            {
                MessageBox.Show(anu.Message);
            }
            diskonek();
            return dt;
        }

        public void Query(string query)
        {
            koneksi = new MySqlConnection(database);
            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();
            }
            catch (Exception anu)
            {
                MessageBox.Show(anu.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }
        public void QueryUpdate()
        {
            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();
                // string update = "UPDATE siswa SET nama='" + textBox1.Text + "',jk='" + 
            }
        }
        private string RadioButtonText()
        {
            if (radioButton1.Checked)
            {
                return radioButton1.Text;
            }
            else
            {
                return radioButton2.Text;
            }
        }
        private void btn_input_Click(object sender, EventArgs e)
        {
            Query("insert into siswa values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + RadioButtonText() + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "')");
            MessageBox.Show("Insert data berhasil");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baca();
        }
    }
}
