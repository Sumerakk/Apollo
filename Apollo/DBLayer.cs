using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Web;

namespace Apollo
{
    public class DBLayer
    {
        static string constr = "Data Source=PKI-LP-230;Initial Catalog=Apollo;Integrated Security=True";
       // static string constr = "Data Source=MUHAMMAD-LUQMAN\\SQLEXPRESS;Initial Catalog=Apollo;Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        public List<string> loadProgramName()
        {
            List<string> list = new List<string>();
            con.Open();
            string q = "select programname from program";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                string s = sdr[0].ToString();
                list.Add(s);
            }
            con.Close();
            return list;
        }

        public List<string> loadTeacherName()
        {
            List<string> mylist = new List<string>();
            con.Open();
            string q = "select TeacherUsername from Teacher";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                mylist.Add(sdr[0].ToString());
            }
            sdr.Close();
            con.Close();
            return mylist;
        }

        public List<string> loadalllistCourses()
        {
            List<string> mylist = new List<string>();
            con.Open();
            string q = "select courseName from course";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                mylist.Add(sdr[0].ToString());
            }
            sdr.Close();
            con.Close();
            return mylist;
        }

        public List<CoreCourses> loadAllCourses()
        {
            //load all courses from database
            con.Open();
            List<CoreCourses> list = new List<CoreCourses>();
            string q = "select coursecode,courseName,crditHours from course";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                CoreCourses c = new CoreCourses();
                c.courseCode = sdr[0].ToString();
                c.coursename = sdr[1].ToString();
                c.coursecredithours = sdr[2].ToString();
                list.Add(c);
            }
            sdr.Close();
            con.Close();
            return list;
        }

        public List<string> loadspecificCourse(string q)
        {
            List<string> li = new List<string>();
            con.Open();
            //here q is program name...
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                string name = sdr[0].ToString();
                li.Add(name);
            }
            sdr.Close();
            con.Close();
            return li;
        }

        public void Saveselectedcourses_toOffer(CoreCourses c) 
        {
            con.Open();
            string q = "insert into offering (CourseCode,CourseName,CourseCrdeitHours) values ('" + c.courseCode + "','"+c.coursename+"','"+c.coursecredithours+"')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete()
        {
            con.Open();
            string q = "delete from offering";
            SqlCommand cmd = new SqlCommand(q,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<CoreCourses> getselectedoffering()
        {
            List<CoreCourses> mylist = new List<CoreCourses>();
            con.Open();
            string q = "select * from offering";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                CoreCourses c = new CoreCourses();
                c.courseCode = sdr[0].ToString();
                c.coursename = sdr[1].ToString();
                c.coursecredithours = sdr[2].ToString();
                mylist.Add(c);
            }
            sdr.Close();
            con.Close();
            return mylist;
        }
        public string Save_Course(Course s)
        {
            try
            {
                
                int ii = 0;
                con.Open();
                string i = "select programid from program where programname='" + s.programname + "'";
                SqlCommand cmd = new SqlCommand(i, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    ii = int.Parse(sdr[0].ToString());
                }
                sdr.Close();
                string q = "insert into course(courseCode,courseName,crditHours,coursetype,programid,efeectivestartdate,efectivelastdate) values ('" + s.coursecode + "','" + s.coursename + "','" + s.coursecreditHours + "','" + s.coursetype + "','" + ii + "','" + s.effectst + "','" + s.effecten + "')";
                cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return "save";
            }
            catch (Exception e)
            {

                return e.ToString();
            }


        }

        public List<CoreCourses> loadcoreCourses(string pro)
        {
           
            string programid = loadoneprogram(pro);
            con.Open();
            List<CoreCourses> list = new List<CoreCourses>();
            string q = "select courseCode,courseName,crditHours from course where coursetype='Core' and programid='"+programid+"'";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                CoreCourses c = new CoreCourses();
                c.courseCode = sdr[0].ToString();
                c.coursename = sdr[1].ToString();
                c.coursecredithours = sdr[2].ToString();
               
                list.Add(c);
            }
            sdr.Close();
            con.Close();
            return list;
        }
        public string loadoneprogram(string pro)
        {
            con.Open();
            string query = "select programid from program where programname='" + pro + "'";
            SqlCommand cm = new SqlCommand(query, con);
            string programid = "";
            SqlDataReader sdr1 = cm.ExecuteReader();
            if (sdr1.Read())
            {
                programid = sdr1[0].ToString();
            }
            sdr1.Close();
            con.Close();
            return programid;

        }
        public void Update_Course(Course s)
        {
            //Update Course

        }
        public string loadCourseID(string courseName)
        {
            con.Open();
            string q = "select courseId from course where courseName='"+courseName+"'";
            SqlCommand cmd = new SqlCommand(q,con);
            SqlDataReader sdr = cmd.ExecuteReader();
            string result = "";
            if (sdr.Read())
            {
                result = sdr[0].ToString();
            }
            sdr.Close();
            con.Close();
            return result;
        }
        public string Regsiter_Course_Student(List<CoreCourses> list1, List<string> list2, string rollnumber)
        {
            try
            {
                List<string> courseID_list = new List<string>();
                
                for (int i = 0; i < list1.Count; i++)
                {
                    courseID_list.Add(loadCourseID(list1[i].coursename));
                }
                for (int i = 0; i < list2.Count; i++)
                {
                    courseID_list.Add(loadCourseID(list2[i]));
                }
                con.Open();
                string q = null;
                string message = "";
                bool res = false;
                if (courseID_list.Count>=6)
                {

                    q = "insert into Enrollment (Student_Roll,Course1,Course2,Course3,Course4,Course5,Course6) values ('"+rollnumber+"','"+courseID_list[0]+"','"+ courseID_list[1] + "','"+ courseID_list[2] + "','"+ courseID_list[3] + "','"+ courseID_list[4] + "','"+ courseID_list[5] + "'')";
                    res = true;
                }
                else if (courseID_list.Count==5)
                {
                    q = "insert into Enrollment (Student_Roll,Course1,Course2,Course3,Course4,Course5) values ('" + rollnumber + "','" + courseID_list[0] + "','" + courseID_list[1] + "','" + courseID_list[2] + "','" + courseID_list[3] + "','" + courseID_list[4] + "')";
                    res = true;
                }
                else if (courseID_list.Count<5)
                {
                    message = "Mimimun 5 courses must be registered";
                    res = false;
                }

                if (res)
                {
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "save";
                }
                else
                {
                    return message;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
                
            }
        }
        public string loadAllCourses(string programName)
        {
            return "loaded";
        }
        public string offerCourse()
        {
            return "save";
        }
        public string validate_User(string q)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    if (sdr[0] != null)
                    {
                        sdr.Close();
                        con.Close();
                        return "valid";
                    }
                }
                sdr.Close();
                con.Close();
                return "not valid";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }
        public int loadcredit(string v)
        {
            int i = 0;
            con.Open();
            string q = "select crditHours from course where courseName='"+v+"'";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                i = int.Parse(sdr[0].ToString());
            }
            sdr.Close();
            con.Close();
            return i;
        }

        public string checkmarks_ParticularCourse_OrCGPA(string coursename,string rollnumber)
        {
            con.Open();
            string remarks = "";
            string q = "select distinct prerequistecourseid from CoursePrerequsite cP INNER JOIN course c ON cp.courseid=(select courseID from course where courseName='"+coursename+"')" ;
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            string codes=null;
            if (sdr.Read())
            {
                codes = sdr[0].ToString();
            }
            sdr.Close();
            if (codes!=null)
            {
                q = "select * from Enrollment where Student_Roll='" + rollnumber + "' and (course1='" + codes + "' OR course2='" + codes + "' OR course3='" + codes + "' OR course4='" + codes + "' OR course5='" + codes + "' OR course6='" + codes + "')";
                cmd = new SqlCommand(q, con);
                sdr = cmd.ExecuteReader();
                bool res = false;
                if (sdr.Read())
                {
                    res = true;
                }
                sdr.Close();
                if (res)
                {
                    q = "select marks from Student_Result where Student_Roll='"+rollnumber+"' and courseId='"+codes+"'";
                    cmd = new SqlCommand(q,con);
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        remarks = sdr[0].ToString();
                    }
                    sdr.Close();
                }
                else
                {
                    remarks = "Prequiste enrollment not Found";
                }
            }
            else
            {
                remarks = "No Prequiste Found";
            }
            con.Close();
            return remarks;
        }
    }
}