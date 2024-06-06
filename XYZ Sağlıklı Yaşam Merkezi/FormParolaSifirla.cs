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
    public partial class FormParolaSıfırla : Form
    {
        public FormParolaSıfırla()
        {
            InitializeComponent();
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked)
            {

               
                txtNewPassword.PasswordChar = '\0';
            }
            else
            {
              
                txtNewPassword.PasswordChar = '*';

            }
        }
    }
}
