using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace notkayitekrani1
{
    public partial class frmogretmendetay : Form
    {
        public frmogretmendetay()
        {
            InitializeComponent();
        }
        SqlConnection baglan1 = new SqlConnection(@"Data Source=DESKTOP-PHRFHT3;Initial Catalog=dbnotkayit;Integrated Security=True");
        private void frmogretmendetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbnotkayitDataSet.tbl_ders' table. You can move, or remove it, as needed.
            

            this.tbl_dersTableAdapter.Fill(this.dbnotkayitDataSet.tbl_ders);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglan1.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_ders (ogrnumara,ograd,ogrsoyad) values (@p1,@p2,@p3)", baglan1);
            komut.Parameters.AddWithValue("@p1",maskedTextBoxnumara.Text);
            komut.Parameters.AddWithValue("@p2", txtkayitad.Text);
            komut.Parameters.AddWithValue("@p3", txtkayitsoyad.Text);
            komut.ExecuteNonQuery();
            baglan1.Close();
            MessageBox.Show("Kayıt Gerçekleşmiştir");
            this.tbl_dersTableAdapter.Fill(this.dbnotkayitDataSet.tbl_ders);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            maskedTextBoxnumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtkayitad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtkayitsoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtnotgiriss1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtnotgiriss2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtnotgiriss3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
          //lblort.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            double ort, s1, s2, s3;
           string durum; int gecen = 0; int kalan = 0;
            s1 = Convert.ToDouble(txtnotgiriss1.Text);
            s2 = Convert.ToDouble(txtnotgiriss2.Text);
            s3 = Convert.ToDouble(txtnotgiriss3.Text);
            ort = (s1 + s2 + s3) / 3;
            lblort.Text = ort.ToString();
          
            if (ort>=50)
            {
                durum = "True";

            }
            else
            {
                durum = "False";    
            }
          
            if (ort>=50)
            {
                gecen =+1;
                lblgecensayisi.Text = gecen.ToString();
            }
            else
            {
                kalan = +1;
                lblkalansayisi.Text = kalan.ToString();
            }

            baglan1.Open();
            SqlCommand komut = new SqlCommand("update tbl_ders set ogrs1=@p1,ogrs2=@p2,ogrs3=@p3,ortalama=@p4,durum=@p5 where ogrnumara=@p6",baglan1);
            komut.Parameters.AddWithValue("@p1",txtnotgiriss1.Text);
            komut.Parameters.AddWithValue("@p2", txtnotgiriss2.Text);
            komut.Parameters.AddWithValue("@p3", txtnotgiriss3.Text);
            komut.Parameters.AddWithValue("@p4",decimal.Parse(lblort.Text));
            komut.Parameters.AddWithValue("@p5",durum);
            komut.Parameters.AddWithValue("@p6",maskedTextBoxnumara.Text);
            komut.ExecuteNonQuery();
            baglan1.Close();
            this.tbl_dersTableAdapter.Fill(this.dbnotkayitDataSet.tbl_ders);

        }
    }
}
