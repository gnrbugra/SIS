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
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            panelBg.Controls.Clear();
            FormHosgeldiniz welcomeScr = new FormHosgeldiniz();
            welcomeScr.TopLevel = false;
            panelBg.Controls.Add(welcomeScr);
            welcomeScr.Show();
            welcomeScr.Dock = DockStyle.Fill;


        }

        private void btnSekKaydet_Click(object sender, EventArgs e)
        {
            panelBg.Controls.Clear();
           FormSekreterBilgisi sekreter = new FormSekreterBilgisi();
            sekreter.TopLevel = false;
            panelBg.Controls.Add(sekreter);
            sekreter.Show();
            sekreter.Dock = DockStyle.Fill;
        }

        private void panelBg_Click(object sender, EventArgs e)
        {
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUzmKaydet_Click(object sender, EventArgs e)
        {
              panelBg.Controls.Clear();
            FormUzmanBilgisi uzman = new FormUzmanBilgisi();
            uzman.TopLevel = false;
            panelBg.Controls.Add(uzman);
            uzman.Show();
            uzman.Dock = DockStyle.Fill;

        }

        private void btnCalisanAra_Click(object sender, EventArgs e)
        {
            panelBg.Controls.Clear();
            FormCalisanAra calisanara = new FormCalisanAra();
            calisanara.TopLevel = false;
            panelBg.Controls.Add(calisanara);
            calisanara.Show();
            calisanara.Dock = DockStyle.Fill;

        }

        private void btnRandevuYonet_Click(object sender, EventArgs e)
        {
            panelBg.Controls.Clear();
            FormHastaBilgisi hastaRandevu = new FormHastaBilgisi();
            hastaRandevu.TopLevel = false;
            panelBg.Controls.Add(hastaRandevu);
            hastaRandevu.Show();
            hastaRandevu.Dock = DockStyle.Fill;

        }

        private void btnParolaDegis_Click(object sender, EventArgs e)
        {
            panelBg.Controls.Clear();
            FormParolaDegistir parolaDegis = new FormParolaDegistir();
            parolaDegis.TopLevel = false;
            panelBg.Controls.Add(parolaDegis);
            parolaDegis.Show();
            parolaDegis.Dock = DockStyle.Fill;

        }

        private void pbVesika_Click(object sender, EventArgs e)
        {
            panelBg.Controls.Clear();
            FormHosgeldiniz welcomeScr = new FormHosgeldiniz();
            welcomeScr.TopLevel = false;
            panelBg.Controls.Add(welcomeScr);
            welcomeScr.Show();
            welcomeScr.Dock = DockStyle.Fill;
        }

        private void btnSeansYonetSek_Click(object sender, EventArgs e)
        {

            panelBg.Controls.Clear();
            FormSeansYonetimi seansYonetSek = new FormSeansYonetimi();
            seansYonetSek.TopLevel = false;
            panelBg.Controls.Add(seansYonetSek);
            seansYonetSek.Show();
            seansYonetSek.Dock = DockStyle.Fill;

        }

        private void btnSeansYonetUzm_Click(object sender, EventArgs e)
        {

            panelBg.Controls.Clear();
            FormUzmanSeansYonetimi seansYonetUzm = new FormUzmanSeansYonetimi();
            seansYonetUzm.TopLevel = false;
            panelBg.Controls.Add(seansYonetUzm);
            seansYonetUzm.Show();
            seansYonetUzm.Dock = DockStyle.Fill;
        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnParolaSifirla_Click(object sender, EventArgs e)
        {
            panelBg.Controls.Clear();
            FormParolaSıfırla passRes = new FormParolaSıfırla();
            passRes.TopLevel = false;
            panelBg.Controls.Add(passRes);
            passRes.Show();
            passRes.Dock = DockStyle.Fill;
        }
    }
}
