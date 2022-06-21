using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using Model;

namespace BLL
{
    public class BolumBLL
    {

        Helper hlp = new Helper();

        List<BolumModel> lst = new List<BolumModel>();

        public List<BolumModel> Liste()
        {
            SqlDataReader dr = hlp.ExecuteReader("spBolumListe");
            while(dr.Read())
            {
                BolumModel bm = new BolumModel();
                bm.bolumid = Convert.ToInt32(dr["bolumid"]);
                bm.bolumad = (dr["Bolumad"]).ToString();
                bm.kontenjan = Convert.ToInt32(dr["Kontenjan"]);
                lst.Add(bm);

            }
            dr.Close();
            return lst;
        }

        


    }
}
