using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C22FinalProject
{
    public partial class Form4 : Form
    {
        private string stringConnection = "data source = LAPTOP-H0P5FB59\\SARAHHANNA17;" + "database = kost_h4sm00n; User Id=sa; Password=123";
        private SqlConnection koneksi;
        public Form4()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            idp.Text = "";
            nmp.Text = "";
            almt.Text = "";
            nmrt.Text = "";
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 fo = new Form2();
            fo.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            new Form4().Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           

            string idpemilik = idp.Text;
            string namapemilik = nmp.Text;
            string alamatpemilik = almt.Text;   
            string nohp = nmrt.Text;
            koneksi.Open();
            string str = "INSERT INTO PemilikKost (Id_Pemilik, Nama_Pemilik, Alamat_Pemilik, no_telp_pemilik) VALUES (@Id_Pemilik, @Nama_Pemilik, @Alamat_Pemilik, @no_telp_pemilik)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.Parameters.AddWithValue("@Id_Pemilik", idpemilik);
            cmd.Parameters.AddWithValue("@Nama_Pemilik", namapemilik);
            cmd.Parameters.AddWithValue("@Alamat_Pemilik", alamatpemilik);
            cmd.Parameters.AddWithValue("@no_telp_pemilik", nohp);
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan");
            refreshform();
            dataGridView();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string queryString = "Update dbo.PemilikKost set Nama_Pemilik='" + nmp.Text + "', Alamat_Pemilik='" + almt.Text + "', no_telp_pemilik='" + nmrt.Text + "' where Id_Pemilik='" + idp.Text + "'";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Update Data Berhasil");
            dataGridView();
            refreshform();
        }

        
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select*from dbo.PemilikKost";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();

        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data : " + idp.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                koneksi.Open();
                string queryString = "Delete dbo.PemilikKost where Id_Pemilik='" + idp.Text + "'";
                SqlCommand cmd = new SqlCommand(queryString, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Hapus Data Berhasil");
                dataGridView();
                refreshform();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                idp.Text = row.Cells["Id_Pemilik"].Value.ToString();
                nmp.Text = row.Cells["Nama_Pemilik"].Value.ToString();
                almt.Text = row.Cells["Alamat_Pemilik"].Value.ToString();
                nmrt.Text = row.Cells["no_telp_pemilik"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }
    }
}
