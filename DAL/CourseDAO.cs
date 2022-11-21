using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MyDbHelper;

namespace DAL
{
    public class CourseDAO
    {
        public List<Course> GetCourses()
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = "SELECT * FROM Course";
            SqlDataReader reader = dbHelper.ExecuteReader(sql);
            List<Course> courses = new List<Course>();
            while (reader.Read())
            {
                String no = reader["Cno"].ToString();
                string name = reader["Cname"].ToString().Trim();
                int pno = Convert.IsDBNull(reader["Cpno"]) ? -1 : Convert.ToInt32(reader["Cpno"]);
                int credit = Convert.ToInt32(reader["Credit"]);
                courses.Add(new Course(no, name, pno, credit));
            }
            reader.Close();
            return courses;
        }

        public void Insert(Course c)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("INSERT INTO Course VALUES({0}, '{1}', {2}, {3})", c.Cno, c.Cname, c.Cpno, c.Credit);
            dbHelper.ExecuteNonQuery(sql);
        }

        public void Update(Course c)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("UPDATE Course SET Cname='{1}', Cpno={2}, Credit={3} " + "WHERE Cno={0}", c.Cno, c.Cname, c.Cpno, c.Credit);
            dbHelper.ExecuteNonQuery(sql);
        }

        public void Delete(string cno)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("DELETE FROM Course WHERE Cno={0}", cno);
            dbHelper.ExecuteNonQuery(sql);
        }
    }
}
