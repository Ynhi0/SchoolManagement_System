using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DL;
using System.Data;

namespace BL
{
    public class SalaryBL
    {
        SalaryDL salaryDL = new SalaryDL();

        public DataTable workingDetails()
        {
            return salaryDL.WorkingDetail();
        }

        public bool addSalaryDetails(Salary salary)
        {
            if(string.IsNullOrEmpty(salary.ID) || string.IsNullOrEmpty(salary.IDTEACHER) || salary.Month == 0 || salary.Year == 0 || salary.WorkingHours == 0)
            {
                return false;
            }
            else
            {
                return salaryDL.AddSalaryDetails(salary);
            }
        }

        public bool updSalaryDetails(Salary salary)
        {
            if(string.IsNullOrEmpty(salary.ID) || string.IsNullOrEmpty (salary.IDTEACHER) || salary.Month == 0 || salary.Year == 0 || salary.WorkingHours == 0 || string.IsNullOrEmpty(salary.Status))
            {
                return false;
            }
            else
            {
                return salaryDL.UpdSalaryDetails(salary);
            }
        }

        public int salaryExecute(Salary salary)
        {
            if(string.IsNullOrEmpty(salary.IDTEACHER) || salary.Month == 0 || salary.Year == 0)
            {
                return 0;
            }
            else
            {
                return salaryDL.SalaryExecute(salary);
            }
        }

        public DataTable searching(string filtertext)
        {
            return salaryDL.Searching(filtertext);
        }

        public DataTable searchingByMonth(Salary salary)
        {
            return salaryDL.SearchingByMonth(salary);
        }

        public DataTable searchingByYear(Salary salary)
        {
            return salaryDL.SearchingByYear(salary);
        }

        public bool solveSalaryReport(Salary salary)
        {
            return salaryDL.SolveSalaryReport(salary);
        }
    }
}
