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
using System.IO;
using System.Drawing.Imaging;

namespace UTS
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }


        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='db_images';username=root;password=");

        private void form2_Load(object sender, EventArgs e)
        {
            FillDGV("");
        }

        private void FillDGV(string value)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM images WHERE CONCAT(ID, Name, Description) LIKE '%" + value + "%'", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.RowTemplate.Height = 60;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[3];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btn_choose_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[3].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);

            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdesc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO images(ID, Name, Description, Image) VALUES (@id,@name,@desc,@img)", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtid.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtname.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txtdesc.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Berhasil ditambahkan!");


        }

        public void ExecMyQuery(MySqlCommand mcomd, string mymsg)
        {
            connection.Open();

            if(mcomd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(mymsg);
            }
            else
            {
                MessageBox.Show("Query not executed");
            }

            connection.Close();

            FillDGV("");
        }

        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE images SET Name=@name,Description=@desc,Image=@img WHERE ID = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtid.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtname.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txtdesc.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Berhasil Diupdate!");


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `images` WHERE ID = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtid.Text;

            ExecMyQuery(command, "Data Berhasil dihapus!");


        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            FillDGV(searchbox.Text);
        }
    }
}
