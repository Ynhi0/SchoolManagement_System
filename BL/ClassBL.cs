using DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL
{
    public class ClassBL
    {

        private ClassDL classDL;

        public ClassBL()
        {
            classDL = new ClassDL();
        }

        public Class GetClassDetails(int idClass)
        {
            return classDL.GetClassDetail(idClass);
        }
        public DataTable GetAllClass()
        {
            return classDL.GetAllClasses();
        }
        public void AddClassDetails(Class classes)
        {
            classDL.AddClass(classes);
        }
        public int GetClassCount()
        {
            return classDL.GetClassCount();
        }
        public int GetActiveClassCount()
        {
            return classDL.GetActiveClassCount();
        }
        public int GetInactiveClassCount()
        {
            return classDL.GetInactiveClassCount();
        }
        public void UpdateClassDetails(Class classes)
        {
            classDL.UpdateClass(classes);
        }
        public void DeleteClassDetails(string idClass)
        {
            classDL.DeleteClassDetail(idClass);
        }
        public int CheckExistClass(string idClass)
        {
            return classDL.ChecKClassExist(idClass);
        }

    }
}
