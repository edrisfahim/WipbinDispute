using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using OfficeOpenXml;

namespace WipbinDispute
{
    public partial class DisputeUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Visible = false;
              
          
            }
        }

        protected void SaveDispute_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=58.26.238.245;Database=BPOReport;User Id=devops;Password = D3v0ps12345");
            SqlCommand cmdinsert = new SqlCommand("INSERT INTO [dbo].[WIPBIN_Dispute] values( ' " + DropDownList1.SelectedValue + " ','" +CasedID.Text+"','" + LogFocusID.Text + "','" + TextBox1.Text + "','" + Calendar1.SelectedDate.ToString("MM/dd/yyyy") + "','" + DupIndi.Text + "',0 )", con);
            con.Open();
            cmdinsert.CommandType = CommandType.Text;
            cmdinsert.ExecuteNonQuery();
            con.Close();
            Label1.Visible = true;
            

        }

       

       

       
    }
    
}