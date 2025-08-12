using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using DTO;

namespace BL
{
    public class TeacherBL
    {
        TeacherDL teacherDL = new TeacherDL();
        Users users = new Users();

        public DataTable getTeacher()
        {
            return teacherDL.GetTeacher();
        }

        public bool updTeacher(Teacher teacher)
        {
            if(string.IsNullOrEmpty(teacher.NAMEOFTEACHER) || teacher.SALARY == 0 || teacher.SALARYCOEFFICIENT == 0)
            {
                return false;
            }
            else
            {
                return teacherDL.UpdTeacher(teacher);
            }
        }

        public bool addTeacher(Teacher teacher)
        {
            if(teacher.IDUSER == 0 || string.IsNullOrEmpty(teacher.IDTEACHER) || string.IsNullOrEmpty(teacher.NAMEOFTEACHER) || string.IsNullOrEmpty(teacher.STATUS) || teacher.SALARY == 0 || teacher.SALARYCOEFFICIENT == 0)
            {
                return false;
            }
            else
            {
                return teacherDL.AddTeacher(teacher);
            }
        }

        public DataTable searchTeacher(string filtertext)
        {
            return teacherDL.SearchTeacher(filtertext);
        }

        public int totalTeacher()
        {
            return teacherDL.TotalTeacher();
        }

        public int workingTeacher()
        {
            return teacherDL.WorkingTeacher();
        }
        
        public TeacherBL()
        {
            teacherDL = new TeacherDL();
        }

        public int GetTotalTeacher()
        {
            return teacherDL.GetTotalTeacher();

        }
        public int GetTotalFemaleTeacher()
        {
            return teacherDL.GetTotalFemaleTeacher();
        }
        public int GetTotalMaleTeacher()
        {
            return teacherDL.GetTotalMaleTeacher();

        }
        public string GetTeacherNameByID(string idTeacher)
        {
            return teacherDL.GetTeacherNameByID(idTeacher);
        }
        public DataTable getIDTeacherList()
        {
            return teacherDL.getIdTeacherList();
        }
    }
}
