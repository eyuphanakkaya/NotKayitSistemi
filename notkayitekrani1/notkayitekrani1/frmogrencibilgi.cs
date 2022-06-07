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
    public partial class frmogrencibilgi : Form
    {
        public frmogrencibilgi()
        {
            InitializeComponent();
        }

        public string numara;
        //Data Source=DESKTOP-PHRFHT3;Initial Catalog=dbnotkayit;Integrated Security=True
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-PHRFHT3;Initial Catalog=dbnotkayit;Integrated Security=True");
        private void frmogrencibilgi_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_ders where ogrnumara=@p1 ",baglan);
            komut.Parameters.AddWithValue("@p1",numara);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lbladsoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lbls1.Text = dr[4].ToString();
                lbls2.Text = dr[5].ToString();
                lbls3.Text = dr[6].ToString();
                lblort.Text = dr[7].ToString();
                lbldurum.Text = dr[8].ToString();
            }
            baglan.Close();
        }
    }
}
