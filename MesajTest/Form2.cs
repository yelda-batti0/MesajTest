using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesajTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Test;Integrated Security=True");

        void gelenkutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM TBLMESAJLAR WHERE ALICI = " +numara,baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM TBLMESAJLAR WHERE GONDEREN = " + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;

            gelenkutusu();
            gidenkutusu();

            //AD-SOYAD BİLGİSİNİ ÇEKME

            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT AD,SOYAD FROM TBLKISILER WHERE NUMARA = " + numara, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Lbladsoyad.Text = dr[0] + " " +  dr[1];

            }
            baglanti.Close();

        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) VALUES (@P1,@P2,@P3,@P4) ",baglanti);
            komut1.Parameters.AddWithValue("@P1", numara);
            komut1.Parameters.AddWithValue("@P2", MskAlici.Text);
            komut1.Parameters.AddWithValue("@P3", TxtBaslik.Text);
            komut1.Parameters.AddWithValue("@P4", richTextBox1.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesaj Gönderildi ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gidenkutusu();
        }
    }
}
