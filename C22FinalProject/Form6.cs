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
    public partial class Form6 : Form
    {
        private string stringConnection = "data source = LAPTOP-H0P5FB59\\SARAHHANNA17;" + "database = kost_h4sm00n; User Id=sa; Password=123";
        private SqlConnection koneksi;
        public Form6()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }
        private void refreshform()
        {
            nmk.Text = "";
            almt.Text = "";
            idk.Text = "";
            idp.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 fo = new Form2();
            fo.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            string namakost = nmk.Text;
            string alamat = almt.Text;
            string idkost = idk.Text;
            string idpemilik = idp.Text;
            koneksi.Open();
            string str = "INSERT INTO Kostt (Nama_kost, Alamat, Id_kost, Id_Pemilik ) VALUES (@Nama_Kost, @Alamat, @Id_Kost, @Id_Pemilik)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.Parameters.AddWithValue("@Nama_kost", namakost);
            cmd.Parameters.AddWithValue("@Alamat", alamat);
            cmd.Parameters.AddWithValue("@Id_kost", idkost);
            cmd.Parameters.AddWithValue("@Id_Pemilik", idpemilik);
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan");
            refreshform();
            dataGridView();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string queryString = "Update dbo.Kostt set Nama_kost ='" + nmk.Text + "', Alamat='" + almt.Text + "', Id_kost='" + idk.Text + "'  where Id_Pemilik='" + idp.Text + "'";
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
            string str = "select*from dbo.Kostt";
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
                string queryString = "Delete dbo.Kostt where Id_kost='" + idk.Text + "'";
                SqlCommand cmd = new SqlCommand(queryString, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Hapus Data Berhasil");
                dataGridView();
                refreshform();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                nmk.Text = row.Cells["Nama_kost"].Value.ToString();
                almt.Text = row.Cells["Alamat"].Value.ToString();
                idk.Text = row.Cells["Id_kost"].Value.ToString();
                idp.Text = row.Cells["Id_Pemilik"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }
    }
}
