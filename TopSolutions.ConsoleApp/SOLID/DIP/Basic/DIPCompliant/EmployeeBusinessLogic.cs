﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant.Contract;

namespace TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant
{
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccessLogic _IEmployeeDataAccessLogic;
        IEmployeeOverseas _IOverseasEmployee;
        public EmployeeBusinessLogic()
        {
            _IEmployeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
            _IOverseasEmployee = DataAccessFactory.GetEmployeeOverseasObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _IEmployeeDataAccessLogic.GetEmployeeDetails(id);
        }
        public void UpdateEmployee(int id, Employee employee) 
        { 
            _IEmployeeDataAccessLogic.UpdateEmployee(id, employee);
        }
        public void NotifyEmployee(int id) 
        {  
            _IEmployeeDataAccessLogic.NotifyEmployee(id);
        }
        public bool ValidateOverseasEmployee(string country)
        {
            return _IOverseasEmployee.IsAForeignCountry(country);
        }
        public double GetOverseasEmployeePay(int id, string country, double pay)
        {
            return _IOverseasEmployee.ProcessForeignPay(id, country, pay);
        }
        public void RegisterStudentWithConsulate(int studentId, string country)
        {
            _IOverseasEmployee.RegisterWithConsulate(studentId, country);
        }
        public void CreateNewEmloyee()
        {
            _IEmployeeDataAccessLogic.CreateEmployee();
        }
        public void CheckEmployeeVisaStatus(int EmpID)
        {
            _IOverseasEmployee.CheckVisaStatus(EmpID);
        }
    }
}
