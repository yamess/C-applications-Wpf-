using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSqlite.Models;

namespace EmployeeSqlite.ViewModels
{
    public class EmployeeViewModel
    {
        public EmployeeModel EmpModel { get; set; }
        public EmployeeViewModel()
        {
            EmpModel = new EmployeeModel();
        }
    }
}
