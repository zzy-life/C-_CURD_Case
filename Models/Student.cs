using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models
{
    public class Student
    {
        public string Sno { get; set; }
        public string Sname { get; set; }
        public string Ssex { get; set; }
        public DateTime Sbirthday { get; set; }
        public string Sdept { get; set; }

        public Student()
        {
        }

        public Student(string sno, string sname, string ssex, DateTime sbirthday, string sdept)
        {
            Sno = sno;
            Sname = sname;
            Ssex = ssex;
            Sbirthday = sbirthday;
            Sdept = sdept;
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
