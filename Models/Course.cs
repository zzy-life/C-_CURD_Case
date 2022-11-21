using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models
{
    public class Course
    {
        public string Cno { get; set; }
        public string Cname { get; set; }
        public int Cpno { get; set; }
        public int Credit { get; set; }

        public Course()
        {
        }

        public Course(string cno, string cname, int cpno, int credit)
        {
            Cno = cno;
            Cname = cname;
            Cpno = cpno;
            Credit = credit;
        }
        public override string ToString()
        {
            return
"id:"
            +
Cno +
"name:"
+
Cname;
        }
    }
}
