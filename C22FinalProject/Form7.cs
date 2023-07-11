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
    public partial class Kamar : Form
    {
        private string stringConnection = "data source = LAPTOP-H0P5FB59\\SARAHHANNA17;" + "database = kost_h4sm00n; User Id=sa; Password=123";
        private SqlConnection koneksi;
        public Kamar()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            nkm.Text = "";
            jkm.Text = "";
            idk.Text = "";
            idp.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 fo = new Form2();
            fo.Show();
            this.Hide();
        }

        private void nkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nomorkamar = nkm.Text;
            string jeniskamar = jkm.Text;
            string idkamar = idk.Text;
            string idpenyewa = idp.Text;
            koneksi.Open();
            string str = "INSERT INTO Kamarr (No_kamar, Jenis_kamar, Id_Kamar, Id_Penyewa ) VALUES (@No_kamar, @Jenis_kamar, @Id_Kamar, @Id_Penyewa)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.Parameters.AddWithValue("@No_kamar", nomorkamar);
            cmd.Parameters.AddWithValue("@Jenis_kamar", jeniskamar);
            cmd.Parameters.AddWithValue("@Id_Kamar", idkamar);
            cmd.Parameters.AddWithValue("@Id_Penyewa", idpenyewa);
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan");
            refreshform();
            dataGridView();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string queryString = "Update dbo.Kamarr set No_kamar ='" + nkm.Text + "', Jenis_kamar='" + jkm.Text + "', Id_Kamar='" + idk.Text + "'  where Id_Penyewa='" + idp.Text + "'";
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
            string str = "select*from dbo.Kamarr";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data : " + nkm.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                koneksi.Open();
                string queryString = "Delete dbo.Kamarr where No_kamar='" + nkm.Text + "'";
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
                nkm.Text = row.Cells["No_kamar"].Value.ToString();
                jkm.Text = row.Cells["Jenis_kamar"].Value.ToString();
                idk.Text = row.Cells["Id_Kamar"].Value.ToString();
                idp.Text = row.Cells["Id_Penyewa"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }
    }
}
