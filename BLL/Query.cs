using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class Query
    {
        public List<Student> GetStudents()
        {
            StudentDAO sDAO = new StudentDAO();
            List<Student> students0 = sDAO.GetStudents();
            return students0;
        }

        public List<Student> GetStudentsByNo(string no)
        {
            StudentDAO sDAO = new StudentDAO();
            List<Student> students = sDAO.GetStudentsByNo(no);
            return students;
        }

        public List<Student> GetStudentsBySexDept(string sex, string dept)
        {
            StudentDAO sDAO = new StudentDAO();
            List<Student> students = sDAO.GetStudentsBySexDept(sex, dept);
            return students;
        }

        public List<Course> GetCourses()
        {
            CourseDAO cDAO = new CourseDAO();
            List<Course> courses = cDAO.GetCourses();
            return courses;
        }
    }
}
