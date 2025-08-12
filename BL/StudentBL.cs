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
    public class StudentBL
    {
        private StudentDL studentDL;

        public StudentBL()
        {
            studentDL = new StudentDL();
        }

        public Student GetStudentDetails(string idUser)
        {
            return studentDL.GetStudentDetails(idUser);
        }
        public Student GetStudentDetailByID(string studentID)
        {
            return studentDL.GetStudentDetailByID(studentID);
        }

        public DataTable GetAllStudents()
        {
            return studentDL.GetAllStudents();
        }

        public void AddStudent(Student student)
        {
            studentDL.AddStudent(student);
        }
        public int GetTotalStudent()
        {
            return studentDL.GetTotalStudents();
        }

        public int GetTotalOnlStudents()
        {
            return studentDL.GetTotalOnlStudents();
        }
        public int GetTotalFemaleStudent()
        {
            return studentDL.GetTotalFemaleStudent();
        }
        public int GetTotalMaleStudent()
        {
            return studentDL.GetTotalMaleStudent();
        }
        public int GetTotalOffStudents()
        {
            return studentDL.GetTotalOffStudents();
        }
        public DataTable GetStudentAccount()
        {
            return studentDL.GetStudentAccount();
        }
        public void UpdateStudent(Student student)
        {
            studentDL.UpdateStudent(student);
        }

        public void DeleteStudent(string studentID)
        {
            try
            {
                studentDL.DeleteStudent(studentID);
                Console.WriteLine("Xóa sinh viên thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi: " + ex.Message);
            }
        }

        public void DeleteStudentAccount(string studentId)
        {
            studentDL.DeleteStudentAccount(studentId);
        }
        public DataTable GetAllStudentFee()
        {
            return studentDL.GetAllStudentFee();
        }
        public void AddStudentFee(Student studentFee)
        {
            studentDL.AddStudentFee(studentFee);
        }
        public int CountPassedStudent()
        {
            return studentDL.CountPassStudent();
        }
        public int CountFailedStudent()
        {
            return studentDL.CountFailStudent();
        }
        public string GetStudentState(string studentID)
        {
            return studentDL.GetStudentState(studentID);
        }
        public void UpdateStudentFee(Student student)
        {
            studentDL.UpdateStudentFee(student);
        }
        public int CheckIdStudent(string ids)
        {
           return  studentDL.CheckIdStudent(ids);
        }
    }
}
