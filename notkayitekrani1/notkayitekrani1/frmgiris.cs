using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notkayitekrani1
{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmogrencibilgi frm = new frmogrencibilgi();
            frm.numara = maskedTextBox1.Text;
            frm.Show();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text=="1111")
            {
                frmogretmendetay frm = new frmogretmendetay();
                frm.Show();
            }
        }
    }
}
