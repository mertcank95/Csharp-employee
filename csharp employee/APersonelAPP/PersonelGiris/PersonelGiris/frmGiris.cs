using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;
namespace PersonelGiris
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            PersonelBLL pbl = new PersonelBLL();
            YöneticiModel ym = new YöneticiModel();
            ym= pbl.KullaniciGirisi( txtKulad.Text.Trim(), txtSifre.Text.Trim()) ;
            if (ym != null)
            {
                frmPersonelislemleri frm1 = new frmPersonelislemleri();
                frm1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı giriş yapdınız!!!");
            }



        }

        private void btnCık_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Çıkmak isdediğinize eminmisiniz!!!!", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
