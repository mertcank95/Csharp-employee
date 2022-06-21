using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DAL
{
    public class Helper
    {
        public int ExecuteNonQuery(string cmdText,SqlParameter[] p=null,CommandType type=CommandType.StoredProcedure)
        {
            try
            {
                using (SqlConnection cn= new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(cmdText, cn))
                    {
                        if (p !=null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        cmd.CommandType = type;
                        cn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }


        public SqlDataReader ExecuteReader(string cmdText, SqlParameter[] p = null, CommandType type = CommandType.StoredProcedure)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);


                     SqlCommand cmd = new SqlCommand(cmdText, cn);

                      cmd.CommandType = type;
                       if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        
                        cn.Open();

                        return cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception)
            {

                throw;
            }

        }


        public DataTable MyDataTable(string cmdtext, SqlParameter[] p = null, CommandType type = CommandType.StoredProcedure)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);

                da.SelectCommand.CommandType = type;

                if (p != null)
                {
                    da.SelectCommand.Parameters.AddRange(p);
                }



                DataTable dt = new DataTable();



                da.Fill(dt);

                return dt;
            }


        }









    }
}
