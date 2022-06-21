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
    public partial class frmPerGos : Form
    {
        PersonelBLL pbl = new PersonelBLL();

        PersonelModel pm = new PersonelModel();

        BolumBLL bl = new BolumBLL();

        DataTable dt;
        frmPersonelislemleri frm = (frmPersonelislemleri)Application.OpenForms["frmPersonelislemleri"];
        public frmPerGos()
        {
            InitializeComponent();
            grdPerGos.AutoGenerateColumns = false;
            dt = pbl.PersonelGoster();

           cmlBolumid.DisplayMember = "Bolumad";
           cmlBolumid.ValueMember = "Bolumid";
           cmlBolumid.DataSource = bl.Liste();
            
            
        }

        private void frmPerGos_Load(object sender, EventArgs e)
        {
            PersonelYukle();
        }


        public void PersonelYukle() => grdPerGos.DataSource = dt;


        

        private void grdPerGos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (!(e.RowIndex>dt.Rows.Count-1))
            {

                frm.txtAd.Text = grdPerGos.Rows[e.RowIndex].Cells["cmlAd"].Value.ToString();
                frm.txtSoyad.Text= grdPerGos.Rows[e.RowIndex].Cells["cmlSoyad"].Value.ToString();
                frm.txtTc.Text= grdPerGos.Rows[e.RowIndex].Cells["clmTc"].Value.ToString();
                frm.txtSicil.Text= grdPerGos.Rows[e.RowIndex].Cells["clmSicilNo"].Value.ToString();
                frm.txtYas.Text= grdPerGos.Rows[e.RowIndex].Cells["cmlYas"].Value.ToString();
                frm.txtPozisyon.Text= grdPerGos.Rows[e.RowIndex].Cells["clmPoz"].Value.ToString();
                frm.cmbBolum.SelectedValue = grdPerGos.Rows[e.RowIndex].Cells["cmlBolumid"].Value;
                frm.id = Convert.ToInt32(dt.Rows[e.RowIndex][0]);
                
            }





        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            PersonelModel pm = new PersonelModel();

            foreach (DataRow item in dt.Rows)
            {

                switch (item.RowState)
                {

                    case DataRowState.Added:
                        pm.ad = item["Ad"].ToString();
                        pm.soyad = item["Soyad"].ToString();
                        pm.tc = item["Tc"].ToString();
                        pm.sicilno= item["SicilNo"].ToString();
                        pm.yas= item["Yas"].ToString();
                        pm.pozisyon= item["Pozisyon"].ToString();
                        pm.bolumid = Convert.ToInt32(item["bolumid"]);
                        pbl.PersonelEkle(pm);
                        break;



                    case DataRowState.Modified:
                        pm.id = Convert.ToInt32(item["id"]);
                        pm.ad = item["Ad"].ToString();
                        pm.soyad = item["Soyad"].ToString();
                        pm.tc = item["Tc"].ToString();
                        pm.sicilno = item["SicilNo"].ToString();
                        pm.yas = item["Yas"].ToString();
                        pm.pozisyon = item["Pozisyon"].ToString();
                        pm.bolumid = Convert.ToInt32(item["bolumid"]);
                        pbl.PersonelGuncelle(pm);

                        break;




                    case DataRowState.Deleted:
                        pbl.PersonelSil(frm.id);
                            
                        break;
                }



            }

            MessageBox.Show("degişikliler kayıt edildi..");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt);
           
            try
            {
                dv.RowFilter = "Ad LIKE '%" + textBox1.Text + "%'";
            }
            catch
            {
                throw;
            }
            
            grdPerGos.DataSource = dv;

        }



        /*
        private void grdPerGos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message=="DataGridViewComboBoxCell değeri geçerli değil")
            {
                object value = grdPerGos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)grdPerGos.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)grdPerGos.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }

        }*/


    }
}
