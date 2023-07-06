using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyResume
{
    public class Cls_main
    {
        #region SQL Server Name
        public static string SQL_Server_Name = ".";
        public static string DB_Name = "niluahirepatil_SampleDB";
        public static string SQL_Server_User_Name = "niluahirepatil_SampleDB";
        public static string SQL_Server_Password = "admin@1234";
        #endregion



        public static string Conn_String = "Data Source=" + SQL_Server_Name + ";Initial Catalog=" + DB_Name + ";User ID=" + SQL_Server_User_Name + ";password=" + SQL_Server_Password + "; ";

        public static SqlConnection Conn = new SqlConnection(Conn_String);

        internal static bool Open_Connection()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed || Conn.State == ConnectionState.Broken)
                {
                    Conn.Open();
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal static void Close_Connection()
        {
            try
            {
                Conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static void Set_Connections()
        {
            Conn = new SqlConnection(Conn_String);
        }

        internal static void VisitorCount(bool postback,string PegName)
        {
            try
            {
                if (postback)
                {
                    int TempCount;
                    Cls_main.Open_Connection();
                    SqlCommand cmd = new SqlCommand("select visitor_count from visitor_count where peg_name='"+ PegName+"'", Conn);
                    SqlDataReader drd = cmd.ExecuteReader();
                    
                    if (drd.Read())
                    {
                        string temp = drd["visitor_count"].ToString();
                        drd.Close();
                        TempCount = Convert.ToInt32(temp)+1;
                        SqlCommand cmd2 = new SqlCommand("update visitor_count set visitor_count='" + TempCount + "' where peg_name='" + PegName + "'", Conn);
                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        drd.Close();
                    }
                    Cls_main.Close_Connection();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        

    }
}