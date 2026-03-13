using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        string connString = "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=DBAkademikADO;Integrated Security=True";

        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Koneksi()
        {
            conn = new SqlConnection(connString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Tombol Connect
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                MessageBox.Show("Koneksi ke database berhasil");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Hitung jumlah Mahasiswa
        private void btnHitungMhs_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "SELECT COUNT(*) FROM Mahasiswa";

                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();

                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        