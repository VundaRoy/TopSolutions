﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant.Contract
{
    public interface IEmployeeOverseas
    {
        bool ForeignValidation(string country);
        double ProcessForeignPay(int EmployeeID, string country, double pay);
    }
}