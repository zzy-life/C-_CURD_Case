using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SC
    {
        public string Sno { get; set; }
        public string Cno { get; set; }
        public double Grade { get; set; }

        public SC()
        {
        }
        public SC(string sno, string cno, double grade)
        {
            Sno = sno;
            Cno = cno;
            Grade = grade;
        }
    }
}
