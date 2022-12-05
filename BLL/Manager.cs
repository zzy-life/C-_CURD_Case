using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class Manager
    {
        public void StudentInsert(Student s)
        {
            StudentDAO sDAO = new StudentDAO();
            sDAO.Insert(s);
        }

        public void StudentUpdate(Student s)
        {
            StudentDAO sDAO = new StudentDAO();
            sDAO.Update(s);
        }

        public void StudentDelete(string no)
        {
            StudentDAO sDAO = new StudentDAO();
            sDAO.Delete(no);
        }

        public void CourseInsert(Course c)
        {
            CourseDAO cDAO = new CourseDAO();
            cDAO.Insert(c);
        }

        public void CourseUpdate(Course c)
        {
            CourseDAO cDAO = new CourseDAO();
            cDAO.Update(c);
        }

        public void CourseDelete(string no)
        {
            CourseDAO cDAO = new CourseDAO();
            cDAO.Delete(no);
        }
        public void ScDelete(SC sc)
        {
            SCDAO scDAO = new SCDAO();
            scDAO.Delete(sc);
        }

        public void ScInsert(SC sc)
        {
            SCDAO cDAO = new SCDAO();
            cDAO.Insert(sc);
        }

        public void ScUpdate(SC sc)
        {
            SCDAO cDAO = new SCDAO();
            cDAO.Update(sc);
        }
    }
}
