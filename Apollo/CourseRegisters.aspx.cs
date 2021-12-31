using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Apollo
{
    public partial class CourseRegisters : System.Web.UI.Page
    {
        string semester = "";
        string prog = "";
        DBLayer obj = new DBLayer();
        string cs1, cs2, cs3, mg1, mg2, mg3, ss1, ss2, ss3;
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> list = obj.loadProgramName();
                programlist.DataSource = list;
                programlist.DataBind();
                loadCore();
                string progid = obj.loadoneprogram(prog);
                string query = "select courseName from Course where coursetype='Elective' and courseCode like 'MG%' and programid='" + progid + "'"; ;
                List<string> mg11 = obj.loadspecificCourse(query);
                mg11.Add("Select Course");

                query = "select courseName from Course where coursetype='Elective' and courseCode like 'CS%' and programid='" + progid + "'";
                List<string> cs11 = obj.loadspecificCourse(query);
                            cs11.Add("Select Course");


                query = "select courseName from Course where coursetype='Elective' and courseCode like 'SS%' and programid='" + progid + "'";
                List<string> ss11 = obj.loadspecificCourse(query);
                          ss11.Add("Select Course");
                COS1.DataSource = cs11;
                COS1.DataBind();
                COS2.DataSource = cs11;
                COS2.DataBind();
                COS3.DataSource = cs11;
                COS3.DataBind();
                MOG1.DataSource = mg11;
                MOG1.DataBind();
                MOG2.DataSource = mg11;
                MOG2.DataBind();
                MOG3.DataSource = mg11;
                MOG3.DataBind();
                SOS1.DataSource = ss11;
                SOS1.DataBind();
                SOS2.DataSource = ss11;
                SOS2.DataBind();
                SOS3.DataSource = ss11;
                SOS3.DataBind();
            }
            
        }
        public void loadCore()
        {
            prog = programlist.SelectedValue.ToString();
            if (prog!=null)
            {

                List<CoreCourses> list = obj.loadcoreCourses(prog);
                count = list.Count;
                Session["Counter"] = count.ToString();
                if (list.Count==4)
                {
                    Code5.Visible = false;
                    Name5.Visible = false;
                    Crdit5.Visible = false;
                    check5.Visible = false;
                    Drop5.Visible = false;
                    Code1.Text = list[0].courseCode;
                    Code2.Text = list[1].courseCode;
                    Code3.Text = list[2].courseCode;
                    Code4.Text = list[3].courseCode;

                    Name1.Text = list[0].coursename;
                    Name2.Text = list[1].coursename;
                    Name3.Text = list[2].coursename;
                    Name4.Text = list[3].coursename;
                    Credit1.Text = list[0].coursecredithours;
                    Credit2.Text = list[1].coursecredithours;
                    Credit3.Text = list[2].coursecredithours;
                    Credit4.Text = list[3].coursecredithours;
                }
                else if (list.Count==3)
                {
                    Code5.Visible = false;
                    Name5.Visible = false;
                    Crdit5.Visible = false;
                    check5.Visible = false;
                    Drop5.Visible = false;

                    Code4.Visible = false;
                    Name4.Visible = false;
                    Credit4.Visible = false;
                    check4.Visible = false;
                    Drop4.Visible = false;
                    Code1.Text = list[1].courseCode;
                    Code2.Text = list[2].courseCode;
                    Code3.Text = list[3].courseCode;
                    Name1.Text = list[1].coursename;
                    Name2.Text = list[2].coursename;
                    Name3.Text = list[3].coursename;

                    Credit1.Text = list[1].coursecredithours;
                    Credit2.Text = list[2].coursecredithours;
                    Credit3.Text = list[3].coursecredithours;
                }
                else if(list.Count>=5)
                {
                    Code1.Text = list[0].courseCode;
                    Code2.Text = list[1].courseCode;
                    Code3.Text = list[2].courseCode;
                    Code4.Text = list[3].courseCode;
                    Code5.Text = list[4].courseCode;
                    

                    Name1.Text = list[0].coursename;
                    Name2.Text = list[1].coursename;
                    Name3.Text = list[2].coursename;
                    Name4.Text = list[3].coursename;
                    Name5.Text = list[4].coursename;

                    Credit1.Text = list[0].coursecredithours;
                    Credit2.Text = list[1].coursecredithours;
                    Credit3.Text = list[2].coursecredithours;
                    Credit4.Text = list[3].coursecredithours;
                    Crdit5.Text = list[4].coursecredithours;
                }
                else
                {

                }
            }
        }

        protected void FALL_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Selelctd semster
            semester = FALL.SelectedItem.Text;

        }

        protected void programlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Selected program 
            //prog = programlist.SelectedItem.Text;
            
        }

        protected void Drop1_Click(object sender, EventArgs e)
        {
            //drop 1 course

        }

        protected void Drop2_Click(object sender, EventArgs e)
        {
            //Drop 2 course
        }

        protected void Drop3_Click(object sender, EventArgs e)
        {
            //Drop 3 Course
        }

        protected void Drop4_Click(object sender, EventArgs e)
        {
            //Drop 4 Course
        }

        protected void Drop5_Click(object sender, EventArgs e)
        {
            //Drop 5 Course
        }
        protected void saveButton_Click(object sender, EventArgs e)
        {
            
            if (Session["Counter"] != null)
            {
                count=int.Parse(Session["Counter"].ToString());
            }
            cs1 = COS1.SelectedValue.ToString();
            cs2 = COS2.SelectedValue.ToString();
            cs3 = COS3.SelectedValue.ToString();
            mg1 = MOG1.SelectedValue.ToString();
            mg2 = MOG2.SelectedValue.ToString();
            mg3 = MOG3.SelectedValue.ToString();
            ss1 = SOS1.SelectedValue.ToString();
            ss2 = SOS2.SelectedValue.ToString();
            ss3 = SOS3.SelectedValue.ToString();
            List<string> list = new List<string>();
            List<CoreCourses> finalcorelist = new List<CoreCourses>();
            if (mg1.Equals("Select Course"))
            {

            }
            else
            {
                list.Add(mg1);
            }
            if (mg2.Equals("Select Course"))
            {

            }
            else
            {
                list.Add(mg2);
            }
            if (mg3.Equals("Select Course"))
            {

            }
            else
            {
                list.Add(mg3);
            }
            if (cs1.Equals("Select Course"))
            {

            }
            else
            {
                list.Add(cs1);
            }
            if (cs2.Equals("Select Course"))
            {

            }
            else
            {
                list.Add(cs2);
            }
            if (cs3.Equals("Select Course"))
            {

            }
            else
            {
                list.Add(cs3);
            }
            if (ss1.Equals("Select Course"))
            {

            }
            else
            {
                list.Add(ss1);
            }
            if (ss2.Equals("Select Course"))
            {

            }
            else
            {
                list.Add(ss2);
            }
            if (ss3.Equals("Select Course"))
            {

            }
            else
            {
                list.Add(ss3);
            }
            List<CoreCourses> ls = new List<CoreCourses>();
            CoreCourses c = new CoreCourses();
            if (count==5)
            {
                if (check1.Checked)
                {
                    c.courseCode = Code1.Text;
                    c.coursename = Name1.Text;
                    c.coursecredithours = Credit1.Text;
                    ls.Add(c);
                }
                if (check2.Checked)
                {
                    c.courseCode = Code2.Text;
                    c.coursename = Name2.Text;
                    c.coursecredithours = Credit2.Text;
                    ls.Add(c);
                }
                if (check3.Checked)
                {
                    c.courseCode = Code3.Text;
                    c.coursename = Name3.Text;
                    c.coursecredithours = Credit3.Text;
                    ls.Add(c);
                }
                if (check4.Checked)
                {
                    c.courseCode = Code4.Text;
                    c.coursename = Name4.Text;
                    c.coursecredithours = Credit4.Text;
                    ls.Add(c);
                }
                if (check5.Checked)
                {
                    c.courseCode = Code5.Text;
                    c.coursename = Name5.Text;
                    c.coursecredithours = Crdit5.Text;
                    ls.Add(c);
                }
            }
            else if (count==4)
            {
                if (check1.Checked)
                {
                    c.courseCode = Code1.Text;
                    c.coursename = Name1.Text;
                    c.coursecredithours = Credit1.Text;
                    ls.Add(c);
                }
                if (check2.Checked)
                {
                    c.courseCode = Code2.Text;
                    c.coursename = Name2.Text;
                    c.coursecredithours = Credit2.Text;
                    ls.Add(c);
                }
                if (check3.Checked)
                {
                    c.courseCode = Code3.Text;
                    c.coursename = Name3.Text;
                    c.coursecredithours = Credit3.Text;
                    ls.Add(c);
                }
                if (check4.Checked)
                {
                    c.courseCode = Code4.Text;
                    c.coursename = Name4.Text;
                    c.coursecredithours = Credit4.Text;
                    ls.Add(c);
                }
            }
            else if (count==3)
            {
                if (check1.Checked)
                {
                    c.courseCode = Code1.Text;
                    c.coursename = Name1.Text;
                    c.coursecredithours = Credit1.Text;
                    ls.Add(c);
                }
                if (check2.Checked)
                {
                    c.courseCode = Code2.Text;
                    c.coursename = Name2.Text;
                    c.coursecredithours = Credit2.Text;
                    ls.Add(c);
                }
                if (check3.Checked)
                {
                    c.courseCode = Code3.Text;
                    c.coursename = Name3.Text;
                    c.coursecredithours = Credit3.Text;
                    ls.Add(c);
                }
            }
            else if (count==2)
            {
                if (check1.Checked)
                {
                    c.courseCode = Code1.Text;
                    c.coursename = Name1.Text;
                    c.coursecredithours = Credit1.Text;
                    ls.Add(c);
                }
                if (check2.Checked)
                {
                    c.courseCode = Code2.Text;
                    c.coursename = Name2.Text;
                    c.coursecredithours = Credit2.Text;
                    ls.Add(c);
                }
            }
            else
            {
                if (check1.Checked)
                {
                    c.courseCode = Code1.Text;
                    c.coursename = Name1.Text;
                    c.coursecredithours = Credit1.Text;
                    ls.Add(c);
                }
           
            }
            List<int> myList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                //loop for collection of Crdit hours to find sum so that it will calculate totol hours..
                int tt = obj.loadcredit(list[i]);
                myList.Add(i);
            }
            for (int i = 0; i < ls.Count; i++)
            {
                myList.Add(int.Parse(ls[i].coursecredithours));
            }
            int sum = myList.Sum();
            if (sum>19)
            {
                Response.Write("<script>alert('Credit Hours in one semester cannot exceed 19')</script>");
            }
            else 
            {
                string rollnumber = "1";
                for (int i = 0; i < ls.Count; i++)
                {
                    string marks = obj.checkmarks_ParticularCourse_OrCGPA(ls[i].coursename,rollnumber);
                    double mark=0;
                    if (marks.Equals("Prequiste enrollment not Found"))
                    {

                    }
                    else if (marks.Equals("No Prequiste Found"))
                    {

                    }
                    else
                    {
                        mark = double.Parse(marks);
                    }
                    
                    if ((mark<=2.50)&&(mark>0))
                    {
                        Response.Write("<script>alert('You can not enroll in'"+ls[i].coursename+"' because your CGPA is low')</script>");
                    }
                    else
                    {
                        finalcorelist.Add(ls[i]);
                    }
                }
                List<string> finalelectivelist = new List<string>();
                finalelectivelist = list;
                string r=obj.Regsiter_Course_Student(finalcorelist, finalelectivelist, rollnumber);
                if (r.Equals("save"))
                {
                    Response.Write("<script>alert('You are Sucessfully Enrolled')</script>");
                    Response.Redirect("StudentDashboard.aspx");
                }
                else
                {
                    Response.Write("<script>alert('"+r+"')</script>");
                }
            }

        }
    }
}