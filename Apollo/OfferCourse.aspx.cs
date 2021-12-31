using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Apollo
{
    public partial class OfferCourse : System.Web.UI.Page
    {
        List<CoreCourses> myofferlist = new List<CoreCourses>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //courses load from Database into gridview
            DBLayer obj = new DBLayer();
            List<CoreCourses> list = obj.loadAllCourses();
            corelist.DataSource = list;
            corelist.DataBind();
        }
        public void loaddata()
        {
            selectedlist.DataSource = myofferlist;
            selectedlist.DataBind();
        }
        protected void corelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //row is selected
            CoreCourses c = new CoreCourses();
            c.courseCode = corelist.SelectedRow.Cells[1].Text;
            c.coursename = corelist.SelectedRow.Cells[2].Text;
            c.coursecredithours = corelist.SelectedRow.Cells[3].Text;
            DBLayer obj = new DBLayer();
            obj.Saveselectedcourses_toOffer(c);
            List<CoreCourses> lists = obj.getselectedoffering();
            selectedlist.DataSource = lists;
            selectedlist.DataBind();
        }

        protected void selectedlist_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
            string coursecode = corelist.SelectedRow.Cells[0].ToString();
            string url = "";
            Response.Redirect("EditCourse.aspx");

        }

        protected void corelist_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
            string coursecode = corelist.SelectedRow.Cells[0].ToString();

        }

        protected void corelist_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            string coursecode = corelist.SelectedRow.Cells[0].ToString();
        }

        protected void newCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCourse.aspx");
        }

        protected void OfferCour_Click(object sender, EventArgs e)
        {
            //Offer Courses to be used...
            DBLayer obj = new DBLayer();
            obj.delete();
            Response.Write("<script>alert('Courses Offer sucessfully...')</script>");
        }
    }
}