using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Apollo
{
    public partial class AddCourse : System.Web.UI.Page
    {
        string coursetypee = "";
        string prgam = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Load Program name from Database
            // to populate list from database prgramlist
            DBLayer obj = new DBLayer();
            List<string> ist = obj.loadProgramName();
            prgramlist.DataSource = ist;
            prgramlist.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            //Save new Course
            prgam = prgramlist.SelectedValue.ToString();
            Course c = new Course();
            c.coursecode = CourseCode.Text;
            c.coursename = coursename.Text;
            c.coursecreditHours = CourseCreditHours.Text;
            c.prequisteCode = coursepcode.Text;
            c.effectst = effctst.Text;
            c.effecten = effcten.Text;
            c.programname = prgam;
            c.coursetype = CourseTypelist.SelectedValue.ToString();
            DBLayer obj = new DBLayer();
            string result = obj.Save_Course(c);
            if(result.Equals("save"))
            {
                //message of successfully storage of data
                Response.Write("<script>alert('Course Save Sucessfully')</script>");
            }
            else if(result.Equals("not save"))
            {
                //message of not save course sucessfully
                Response.Write("<script>alert('Course not Sucessfully')</script>");
            }
            else
            {
                //show error message 
                Response.Write("<script>alert('Course Not Save Sucessfully')</script>");
                Response.Write("<script>alert('"+result+"')</script>");
            }
        }

        protected void CourseTypelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select selected list item
            coursetypee = CourseTypelist.SelectedValue.ToString();
        }

        protected void prgramlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select selected list item
            prgam = prgramlist.SelectedValue.ToString();
        }

        protected void filebutton_Click(object sender, EventArgs e)
        {
            //Import excel file and save these files into database.

        }
    }
}