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
    public partial class frmPersonelAra : Form
    {
        frmPersonelislemleri frm;
        public frmPersonelAra(frmPersonelislemleri frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelBLL bll = new PersonelBLL();
                PersonelModel pm = (bll.PersonelAra(txtAraSicil.Text.Trim()));
                if (pm!=null)
                {
                    DialogResult secenek = MessageBox.Show("Personel adı soyadı:" + pm.ad + " " + pm.soyad + " Daha Detaylı bilgi istermisiniz", "Bilgilendirme Penceresi",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secenek==DialogResult.Yes)
                    {
                        frm.id = pm.id;
                        frm.txtAd.Text = pm.ad;
                        frm.txtSoyad.Text = pm.soyad;
                        frm.txtTc.Text = pm.tc;
                        frm.txtSicil.Text = pm.sicilno;
                        frm.txtYas.Text = pm.yas;
                        frm.txtPozisyon.Text = pm.pozisyon;
                        frm.cmbBolum.SelectedValue = pm.bolumid;
                      
                    }

                }
                else
                {
                    MessageBox.Show("Böyle Bir Personel Bulunamadı");
                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmPersonelAra_Load(object sender, EventArgs e)
        {

        }
    }
}
