using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyResume
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Cls_main.VisitorCount(!IsPostBack,"MyResume");
           
                try
                {
                    if (!IsPostBack)
                    {
                        int TempCount;
                        String mycon = ConfigurationManager.ConnectionStrings["mydatabase"].ConnectionString;
                        SqlConnection conn = new SqlConnection(mycon);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("select visitor_count from visitor_count where peg_name='myresume'", conn);
                        SqlDataReader drd = cmd.ExecuteReader();

                        if (drd.Read())
                        {
                            string temp = drd["visitor_count"].ToString();
                            drd.Close();
                            TempCount = Convert.ToInt32(temp) + 1;
                            SqlCommand cmd2 = new SqlCommand("update visitor_count set visitor_count='" + TempCount + "' where peg_name='myresume'", conn);
                            cmd2.ExecuteNonQuery();
                        }
                        else
                        {
                            drd.Close();
                        }
                      
                    }
                }
                catch (Exception)
                {
                    throw;
                }

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            try
            {


                string time = DateTime.Now.ToString();
                String query = "insert into comment(name, email, subject,message,message_at) values('" + txt_name.Text + "', '" + txt_email.Text + "', '" + txt_subject.Text + "','" + txt_message.Text + "','" + time + "')";
                String mycon = ConfigurationManager.ConnectionStrings["mydatabase"].ConnectionString;
                SqlConnection conn = new SqlConnection(mycon);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "12121", "alert('Thank you for your message and we will be in touch soon.');", true);
                txt_name.Text = "";
                txt_message.Text = "";
                txt_subject.Text = "";
                txt_email.Text = "";

            }
            catch (Exception )
            {
                throw;
            }
           

        }


    }
}
