using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.FactoryModel.Banking
{
    public interface IBank
    {
        void ProcessPayment(decimal amount);
        void ProcessDeposit(decimal amount);
        void GetTotalBalance();
    }
}
