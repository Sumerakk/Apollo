using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apollo
{
    public class Course
    {
        public string coursecode
        {
            get;
            set;
        }
        public string coursename
        {
            get;
            set;
        }
        //coursecode,coursename,CourseCreditHours,coursepcode,effctst,effcten
        public string coursecreditHours
        {
            get;
            set;
        }
        public string prequisteCode
        {
            get;
            set;
        }
        public string effectst
        {
            get;
            set;
        }
        public string effecten
        {
            get;
            set;
        }
        public  string programname
        {
            get;
            set;
        }
        public string coursetype
        {
            get;
            set;
        }
    }
}