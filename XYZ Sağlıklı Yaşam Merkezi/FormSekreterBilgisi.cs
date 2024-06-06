using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZ_Sağlıklı_Yaşam_Merkezi
{
    public partial class FormSekreterBilgisi : Form
    {
        public FormSekreterBilgisi()
        {
            InitializeComponent();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtTc.Text, "[^0-9]"))
            {
                txtTc.Text = txtTc.Text.Remove(txtTc.Text.Length - 1);
            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtTelefonNo.Text, "[^0-9]"))
            {
                txtTelefonNo.Text = txtTelefonNo.Text.Remove(txtTc.Text.Length - 1);
            }
        }
       
        private void txtEspota_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void FormSekreterBilgisi_Load(object sender, EventArgs e)
        {

        }
       
        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtGsm.Text, "[^0-9]"))
            {
                txtGsm.Text = txtTc.Text.Remove(txtTc.Text.Length - 1);
            }
        }
    }
}
