using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Apollo
{
    public partial class AssignTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //load data in teachername list
            //load data in coursename list
            DBLayer obj = new DBLayer();
            List<string> myListCourse = obj.loadalllistCourses();
            List<string> mylist2Teacher = obj.loadTeacherName();
            teacherlist1.DataSource = mylist2Teacher;
            teacherlist1.DataBind();
            teacherlist2.DataSource = mylist2Teacher;
            teacherlist2.DataBind();
            teacherlist3.DataSource = mylist2Teacher;
            teacherlist3.DataBind();
            teacherlist4.DataSource = mylist2Teacher;
            teacherlist4.DataBind();
            coursesname1.DataSource = myListCourse;
            coursesname1.DataBind();
            coursesname2.DataSource = myListCourse;
            coursesname2.DataBind();
            coursesname3.DataSource = myListCourse;
            coursesname3.DataBind();
            coursesname4.DataSource = myListCourse;
            coursesname4.DataBind();
        }
    }
}