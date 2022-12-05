using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SCAll
    {
        public string Sno { get; set; }
        public string Sname { get; set; }
        public string Ssex { get; set; }
        public DateTime Sbirthday { get; set; }
        public string Sdept { get; set; }

        public int Cno { get; set; }
        public string Cname { get; set; }
        public int Cpno { get; set; }
        public int Credit { get; set; }

        public double Grade { get; set; }

        public SCAll(Student s, Course c, SC sc)
        {
            Sno = s.Sno;
            Sname = s.Sname;
            Ssex = s.Ssex;
            Sbirthday = s.Sbirthday;
            Sdept = s.Sdept;

            Cno = int.Parse(c.Cno.ToString());
            Cname = c.Cname;
            Cpno = c.Cpno;
            Credit = int.Parse(c.Credit.ToString());

            Grade = sc.Grade;
        }
    }
    public class SC 
    {
        public string Sno { get; set; }
        public string Cno { get; set; }
        public double Grade { get; set; }
        public string Sname { get; set; }

        public string Cname { get; set; }

        public SC()
        {
        }
        public SC(string sno,string cno, string sname,string cname, double grade)
        {
            Sno = sno;
            Cno = cno;
            Sname = sname;
            Cname = cname;
            Grade = grade;
        }
        public SC(string sno, string cno, double grade)
        {
            Sno = sno;
            Cno = cno;
            Grade = grade;
        }
        public override string ToString()
        {
            return
"id:"
            +
Sno +
"name:"
+
Sname;
        }
    }
}
