using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_11
{
    internal class CalculateAdding
    {
        int Employees;
        int AddEmployees;

        public CalculateAdding(int employees, int addEmployees)
        {
            Employees = employees;
            AddEmployees = addEmployees;
        }
        public int CalculateCount()
        {
            int countEmployees = Employees + AddEmployees;
            return countEmployees;
        }
    }
}
