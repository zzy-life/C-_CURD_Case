using Models;
using MyDbHelper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class SCDAO
    {
        public List<SC> GetSC()
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = "SELECT\r\n\tSC.Sno,\r\nSC.Cno,\r\n\tStudent.Sname,\r\n\tCourse.Cname,\r\n\tSC.Grade\r\nFROM\r\n\tSC\r\nLEFT JOIN Student ON SC.Sno = Student.Sno\r\nLEFT JOIN Course ON Course.Cno = SC.Cno";
            SqlDataReader reader = dbHelper.ExecuteReader(sql);
            List<SC> scs = new List<SC>();
            while (reader.Read())
            {
                String sno = reader["Sno"].ToString();
                String cno = reader["Cno"].ToString();
                string sname = reader["Sname"].ToString().Trim();
                String cname = reader["Cname"].ToString().Trim();
                int grade = Convert.ToInt32(reader["Grade"]);
                scs.Add(new SC(sno, cno, sname, cname, grade));
            }
            reader.Close();
            Console.WriteLine(scs.ToString());
            return scs;
        }

       public void Insert(SC c)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("INSERT INTO Course VALUES({0}, '{1}', {2}, {3})", c.Cno, c.Cname);
            dbHelper.ExecuteNonQuery(sql);
        }

        public void Update(SC sc)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("UPDATE [DBS].[dbo].[SC] SET [Grade]={0} WHERE ([Sno]={1}) AND ([Cno]={2})", sc.Grade, sc.Sno,sc.Cno);
            dbHelper.ExecuteNonQuery(sql);
        }

        public void Delete(SC sc)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("DELETE FROM SC WHERE Sno = {0} AND Cno = {1}", sc.Sno,sc.Cno);
            dbHelper.ExecuteNonQuery(sql);
        }
        public List<SCAll> GetSCAlls()
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = "SELECT S.Sno, S.Sname, S.Ssex, S.Sbirthday, S.Sdept, " +
                "C.Cno, C.Cname, C.Cpno, C.Credit, SC.Grade " +
                "FROM Student S INNER JOIN SC ON S.Sno=SC.Sno " +
                "INNER JOIN Course C ON SC.Cno=C.Cno";
            SqlDataReader reader = dbHelper.ExecuteReader(sql);
            List<SCAll> scAlls = new List<SCAll>();
            while (reader.Read())
            {
                string sno = reader["Sno"].ToString().Trim();
                string sname = reader["Sname"].ToString().Trim();
                string ssex = reader["Ssex"].ToString().Trim();
                DateTime sbirthday = DateTime.Parse(reader["Sbirthday"].ToString());
                string sdept = reader["Sdept"].ToString().Trim();
                Student s = new Student(sno, sname, ssex, DateTime.Parse(sbirthday.ToString()), sdept);

                int cno = Convert.ToInt32(reader["Cno"]);
                string cname = reader["Cname"].ToString().Trim();
                int cpno = Convert.IsDBNull(reader["Cpno"]) ? -1 : Convert.ToInt32(reader["Cpno"]);
                int credit = Convert.ToInt32(reader["Credit"]);
                Course c = new Course(cno.ToString(), cname, cpno, credit);

                double grade = Convert.ToDouble(reader["Grade"]);
                SC sc = new SC(sno, cno.ToString(), grade);

                scAlls.Add(new SCAll(s, c, sc));
            }
            reader.Close();

            return scAlls;
        }
    }
}
