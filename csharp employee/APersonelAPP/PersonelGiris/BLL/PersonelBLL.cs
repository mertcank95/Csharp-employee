using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class PersonelBLL
    {
        Helper hlp = new Helper();


        public YöneticiModel KullaniciGirisi(string kulad, string sifre)
        {
            try
            {
                SqlParameter[] p =
           {
                new SqlParameter("@Kulad",kulad),
                new SqlParameter("@Sifre",sifre)
            };

                SqlDataReader dr = hlp.ExecuteReader("spKulGiris", p);
                YöneticiModel ym = null;
                if (dr.Read())
                {
                    ym = new YöneticiModel();
                    ym.kulad = dr["Kulad"].ToString();
                    ym.sifre = dr["Sifre"].ToString();

                }
                dr.Close();
                return ym;

            }
            catch (Exception)
            {

                throw;
            }


        }


        public bool PersonelEkle(PersonelModel pm)
        {
            try
            {
                SqlParameter[] p = {

               new SqlParameter("@Ad",pm.ad),
               new SqlParameter("@Soyad",pm.soyad),
               new SqlParameter("@Tc",pm.tc),
               new SqlParameter("@SicilNo",pm.sicilno),
               new SqlParameter("@Yas",pm.yas),
               new SqlParameter("@Bolumid",pm.bolumid),
               new SqlParameter("@Pozisyon",pm.pozisyon)


            };

                return hlp.ExecuteNonQuery("spPersonelEkle",p) > 0;

            }

            catch (Exception)
            {

                throw;
            }

        }


        public bool PersonelGuncelle(PersonelModel pm)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@id",pm.id),
                    new SqlParameter("@Ad",pm.ad),
               new SqlParameter("@Soyad",pm.soyad),
               new SqlParameter("@Tc",pm.tc),
               new SqlParameter("@SicilNo",pm.sicilno),
               new SqlParameter("@Yas",pm.yas),
               new SqlParameter("@Bolumid",pm.bolumid),
               new SqlParameter("@Pozisyon",pm.pozisyon)


                };

                return hlp.ExecuteNonQuery("spPersonelGuncelle", p) > 0;


            }
            catch (Exception)
            {
                throw;
            }
        }


        public PersonelModel PersonelAra(string sicilno)
        {
            try
            {
                SqlParameter[] p = {
                new SqlParameter("@SicilNo",sicilno)

            };

                SqlDataReader dr = hlp.ExecuteReader("spPersonelAra", p);
                PersonelModel pm = null;
                if (dr.Read())
                {
                    pm = new PersonelModel();
                    pm.id = Convert.ToInt32(dr["id"]);
                    pm.ad = dr["Ad"].ToString();
                    pm.soyad = dr["Soyad"].ToString();
                    pm.tc = dr["Tc"].ToString();
                    pm.sicilno = dr["SicilNo"].ToString();
                    pm.yas = dr["Yas"].ToString();
                    pm.bolumid = Convert.ToInt32(dr["Bolumid"]);
                    pm.pozisyon = dr["Pozisyon"].ToString();


                }
                dr.Close();
                return pm;
            }
            catch (Exception)
            {

                throw;
            }

        }


        public bool PersonelSil(int id)
        {
            try
            {
                SqlParameter[] p = {
                new SqlParameter("@id",id)

            };

                return hlp.ExecuteNonQuery("spPersonelSil", p) > 0;


            }
            catch (Exception)
            {

                throw;
            }

        }


        public DataTable PersonelGoster()
        {
            return hlp.MyDataTable("spPersonelTable");
            

        }







    }
}
