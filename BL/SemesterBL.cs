using DL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SemesterBL
    {
        private SemesterDL semesterDL = new SemesterDL();
        public DataTable getSemesterDate()
        {
            return semesterDL.GetSemesterDetail();
        }
        public bool AddSemesterDate(Semester semester)
        {
            return semesterDL.AddSemesterDate(semester);
        }
        public string GetClassNameByID(string idClass)
        {
            return semesterDL.GetClassNameByID(idClass);
        }
        public DataTable GetIdClass()
        {
            return semesterDL.GetActiveClass();
        }
        public void DeleteExamDate(string idClass)
        {
            semesterDL.DeleteSemester(idClass);
        }
        public void UpdateSemesterDate(Semester semester)
        {
            semesterDL.EditSemester(semester);
        }
    }
}
