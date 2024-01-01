using DLL.EF.Models;
using DLL.Interfaces;
using DLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public  class DataAccessFactory
    {
        public static  IRepo<Employee, string, Employee,int> EmployeeData()
        {
            return new EmployeeRepo();
        }
        public static IPRepo<UserQuestions, int, UserQuestions> EmpMgsData()
        {
            return new EmpMgsRepo();
        }
    }
}
