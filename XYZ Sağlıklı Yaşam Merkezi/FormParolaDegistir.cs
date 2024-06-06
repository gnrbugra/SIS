using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZ_Sağlıklı_Yaşam_Merkezi
{
    public partial class FormParolaDegistir : Form
    {
        public FormParolaDegistir()
        {
            InitializeComponent();
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked)
            {

               txtOldPass.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
                txtYeniSifreTekrar.PasswordChar = '\0';
            }
            else
            {
              txtOldPass.PasswordChar = '*';
              txtYeniSifreTekrar.PasswordChar = '*';
                txtNewPassword.PasswordChar = '*';

            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {

        }

        private void lblEskiParola_Click(object sender, EventArgs e)
        {

        }

        private void lblYeniParolaTekrar_Click(object sender, EventArgs e)
        {

        }

        private void lblYeniParola_Click(object sender, EventArgs e)
        {

        }

        private void txtYeniSifreTekrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
