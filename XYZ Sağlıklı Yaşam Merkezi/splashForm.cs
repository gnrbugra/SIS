using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZ_Sağlıklı_Yaşam_Merkezi
{
    public partial class splashForm : Form
    {
        public splashForm()
        {
            InitializeComponent();
        }
        bool animates = false;
        private void animate_Tick(object sender, EventArgs e)
        {
            if (!animates)
            {
                this.Opacity += 0.009;

                // kontrol et
                if (this.Opacity >= 1)
                {
                    this.Opacity = 1; 
                    animates = true; //baslat
                }
            }
            else
            {
                this.Opacity -= 0.009;

                if (this.Opacity <= 0)
                {
                    this.Opacity = 0; 
                    animate.Enabled = false; 



                    FormGiris login = new FormGiris();
                    login.Show(); 
                    this.Hide(); 
                }
            }
        

    }
    }
}
