using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities.Employees;

namespace PunchSystem
{
    public class ValidateEmployee
    {
        public static bool Validate(string number)
        {
            return EmployeeLogs.LogEmployee(number.Replace(".", ""));
        }
    }
}
