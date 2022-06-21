using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace PersonelGiris
{
    public partial class frmPersonelislemleri : Form
    {
        public int id = 0;
        public frmPersonelislemleri()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPersonelislemleri_Load(object sender, EventArgs e)
        {
            BolumBLL bbl = new BolumBLL();

            cmbBolum.DisplayMember = "Bolumad";
            cmbBolum.ValueMember = "bolumid";
            cmbBolum.DataSource = bbl.Liste();


        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmPersonelAra frm = new frmPersonelAra(this);
            frm.Show();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonelBLL bll = new PersonelBLL();
            try
            {
                if (id != 0)
                {
                    if (bll.PersonelGuncelle(new PersonelModel
                    {
                        id = id,
                        ad = txtAd.Text.Trim(),
                        soyad = txtSoyad.Text.Trim(),
                        tc = txtTc.Text.Trim(),
                        sicilno = txtSicil.Text.Trim(),
                        pozisyon = txtPozisyon.Text.Trim(),
                        yas = txtYas.Text.Trim(),
                        bolumid = Convert.ToInt32(cmbBolum.SelectedValue)
                    }
                    ))
                    {
                        MessageBox.Show("işlem başarılı");
                        id = 0;
                    }
                    else
                    {
                        MessageBox.Show("İslem başarısız");
                    }
                }
                else if (id == 0)
                {
                    if (bll.PersonelEkle(new PersonelModel { ad = txtAd.Text.Trim(), soyad = txtSoyad.Text.Trim(), tc = txtTc.Text.Trim(), sicilno = txtSicil.Text.Trim(),
                        yas = txtYas.Text.Trim(),pozisyon=txtPozisyon.Text.Trim(),
                        bolumid = Convert.ToInt32(cmbBolum.SelectedValue) }))
                    {
                        MessageBox.Show("İslem başarılı");
                    }
                    else
                    {
                        MessageBox.Show("islem başarısız");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            PersonelBLL bll = new PersonelBLL();

            DialogResult secenek = MessageBox.Show("Silmek istediğinize eminmisiniz!!" , "Bilgilendirme Penceresi",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                if (bll.PersonelSil(this.id))
                {
                    MessageBox.Show("Silme işlemi başarılı!!!");
                    id = 0;
                }
                else
                {
                    MessageBox.Show("silme işlemi gerçekleşmedi!!!");
                }
            }
            else
            {
                MessageBox.Show("silme işlemi iptal edildi");
            }
        }

        private void btnGos_Click(object sender, EventArgs e)
        {
            frmPerGos frmg = new frmPerGos();
            frmg.Show();


        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            ppdDialog.ShowDialog();

        }

        Font f1 = new Font("verdana", 25, FontStyle.Bold);
        Font f2 = new Font("verdana", 15,FontStyle.Bold);
        SolidBrush sb = new SolidBrush(Color.Black);


        private void pdYazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sfor = new StringFormat();
            sfor.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Personel Bilgi Formu" , f1, sb, 200, 100);



            e.Graphics.DrawString("Personel isimi: "+txtAd.Text,f2,sb,150,200);
            e.Graphics.DrawString("Personel soyisimi: " + txtSoyad.Text, f2, sb, 150, 250);
            e.Graphics.DrawString("Personel Tc no: " + txtTc.Text, f2, sb, 150, 300);
            e.Graphics.DrawString("Personel sicil no: " + txtSicil.Text, f2, sb, 150, 350);
            e.Graphics.DrawString("Personel yaşı: " + txtYas.Text, f2, sb, 150, 400);
            e.Graphics.DrawString("Personel pozisyonu: " + txtPozisyon.Text, f2, sb, 150, 450);
            e.Graphics.DrawString("Personel bölümü: " + cmbBolum.Text, f2, sb, 150, 500);


        }
    }
}
