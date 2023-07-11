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
    public partial class Form8 : Form
    {
        private string stringConnection = "data source = LAPTOP-H0P5FB59\\SARAHHANNA17;" + "database = kost_h4sm00n; User Id=sa; Password=123";
        private SqlConnection koneksi;
        public Form8()
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
            notlp.Text = "";
            idpem.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 fo = new Form2();
            fo.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string idpenyewa = idp.Text;
            string namapenyewa = nmp.Text;
            string alamat = almt.Text;
            string notelp = notlp.Text;
            string idpemilik = idpem.Text;
            koneksi.Open();
            string str = "INSERT INTO PenyewaKost (Id_Penyewa, Nama_Penyewa, Alamat_Penyewa, no_telp_penyewa,  Id_Pemilik) VALUES (@Id_Penyewa, @Nama_Penyewa, @Alamat_Penyewa, @no_telp_penyewa, @Id_Pemilik)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.Parameters.AddWithValue("@Id_Penyewa", idpenyewa);
            cmd.Parameters.AddWithValue("@Nama_Penyewa", namapenyewa);
            cmd.Parameters.AddWithValue("@Alamat_Penyewa", alamat);
            cmd.Parameters.AddWithValue("@no_telp_penyewa", notelp);
            cmd.Parameters.AddWithValue("@Id_Pemilik", idpemilik);
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan");
            refreshform();
            dataGridView();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string queryString = "Update dbo.PenyewaKost set Id_Penyewa ='" + idp.Text + "', Nama_Penyewa='" + nmp.Text + "', Alamat_Penyewa='" + almt.Text + " + ', no_telp_penyewa='" + notlp.Text + "'  where Id_Pemilik='" + idpem.Text + "'";
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
            string str = "select*from dbo.PenyewaKost";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data : " + idp.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                koneksi.Open();
                string queryString = "Delete dbo.PenyewaKost where Id_Penyewa='" + idp.Text + "'";
                SqlCommand cmd = new SqlCommand(queryString, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Hapus Data Berhasil");
                dataGridView();
                refreshform();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                idp.Text = row.Cells["Id_Penyewa"].Value.ToString();
                nmp.Text = row.Cells["Nama_Penyewa"].Value.ToString();
                almt.Text = row.Cells["Alamat_Penyewa"].Value.ToString();
                notlp.Text = row.Cells["no_telp_penyewa"].Value.ToString();
                idpem.Text = row.Cells["Id_Pemilik"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }
    }
}
