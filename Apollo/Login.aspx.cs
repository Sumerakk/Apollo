using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Apollo
{
    public partial class Login : System.Web.UI.Page
    {
        string role = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    role = myDDL.SelectedValue.ToString();
        //}
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //Submit Button
            role = mylist.SelectedValue.ToString();
            DBLayer con = new DBLayer();
            if (role.Equals("TEACHER"))
            {
                string username = email.Text;
                string passwords = password.Text;
                string q = "select * from Teacher where TeacherUsername='" + username + "' and password='" + passwords + "'";
                string result = con.validate_User(q);
                if (result.Equals("valid"))
                {
                    Response.Redirect("TeacherDashboard.aspx");
                }
                else if (result.Equals("not valid"))
                {
                    Response.Write("<script>alert('Username and Password not Match')</script>");
                }
                else
                {
                    Response.Write("<script>alert('" + result + "')</script>");
                }
            }
            else if (role.Equals("ADMIN"))
            {
                string username = email.Text;
                string passwords = password.Text;
                string q = "select * from Admin where AdminUsername='" + username + "' and password='" + passwords+ "'";
                string result = con.validate_User(q);
                if (result.Equals("valid"))
                {
                    Response.Redirect("AdminDashboard.aspx");
                }
                else if (result.Equals("not valid"))
                {
                    Response.Write("<script>alert('Username and Password not Match')</script>");
                }
                else
                {
                    Response.Write("<script>alert('" + result + "')</script>");
                }
            }
            else if (role.Equals("STUDENT"))
            {
                string username = email.Text;
                string passwords = password.Text;
                string q = "select * from Student where StudentUsername='" + username + "' and password='" + passwords + "'";
                string result = con.validate_User(q);
                if (result.Equals("valid"))
                {
                    Response.Redirect("StudentDashboard.aspx");
                }
                else if (result.Equals("not valid"))
                {
                    Response.Write("<script>alert('Username and Password not Match')</script>");
                }
                else
                {
                    Response.Write("<script>alert('" + result + "')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Role')</script>");
            }


        }

        protected void mylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            role = mylist.SelectedValue.ToString();
        }
    }
}