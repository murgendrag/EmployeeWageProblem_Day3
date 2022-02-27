using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class EmployeeAttendance
    {
        int Emplopee_Present = 1;
        public static void Employeeattcheck()
        {
            Random random = new Random();
            int number = random.Next(2);
            if (number == 1)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
