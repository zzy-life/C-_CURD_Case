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
    public class StudentDAO
    {
        public List<Student> GetStudents()
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = "SELECT * FROM Student";
            SqlDataReader reader = dbHelper.ExecuteReader(sql);
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                string no = reader["Sno"].ToString().Trim();
                string name = reader["Sname"].ToString().Trim();
                string sex = reader["Ssex"].ToString().Trim();
                DateTime birthday = Convert.ToDateTime(reader["Sbirthday"]);
                string dept = reader["Sdept"].ToString().Trim();
                students.Add(new Student(no, name, sex, birthday, dept));
            }
            reader.Close();
            return students;
        }

        public void Insert(Student s)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("INSERT INTO Student VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", s.Sno, s.Sname, s.Ssex, s.Sbirthday.ToString(), s.Sdept);
            dbHelper.ExecuteNonQuery(sql);
        }

        public void Update(Student s)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("UPDATE Student SET Sname='{1}', Ssex='{2}', SBirthday='{3}', Sdept='{4}' WHERE Sno='{0}'", s.Sno, s.Sname, s.Ssex, s.Sbirthday.ToString(), s.Sdept);
            dbHelper.ExecuteNonQuery(sql);
        }

        public void Delete(string sno)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("DELETE FROM Student WHERE Sno='{0}'", sno);
            dbHelper.ExecuteNonQuery(sql);
        }

        public List<Student> GetStudentsByNo(string no)
        {
            
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("SELECT * FROM Student Where Sno = '{0}'", no);
            SqlDataReader reader = dbHelper.ExecuteReader(sql);
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                string name = reader["Sname"].ToString().Trim();
                string sex = reader["Ssex"].ToString().Trim();
                DateTime birthday = Convert.ToDateTime(reader["Sbirthday"]);
                string dept = reader["Sdept"].ToString().Trim();
                students.Add(new Student(no, name, sex, birthday, dept));
            }
            reader.Close();
            return students;
        }

        public List<Student> GetStudentsBySexDept(string sex, string dept)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("SELECT * FROM Student Where Ssex = '{0}' And Sdept= '{1}'", sex, dept);
            SqlDataReader reader = dbHelper.ExecuteReader(sql);
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                string name = reader["Sname"].ToString().Trim();
                string no = reader["Sno"].ToString().Trim();
                DateTime birthday = Convert.ToDateTime(reader["Sbirthday"]);
                students.Add(new Student(no, name, sex, birthday, dept));
            }
            reader.Close();
            return students;
        }
    }
}
