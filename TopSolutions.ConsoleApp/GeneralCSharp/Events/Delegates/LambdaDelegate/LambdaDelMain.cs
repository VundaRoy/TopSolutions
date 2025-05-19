using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Events.Delegates.LambdaDelegate
{
    public delegate bool CustomerEligibility(Customer customer);
    public class LambdaDelMain
    {
        public List<Customer> customerList;
        public LambdaDelMain()
        {
            customerList = new List<Customer>();
            Customer customer1 = new()
            {
                CustomerNumber = 1,
                CustomerName = "Herman",
                AnnualGiftVoucher = false,
                PurchaseLevel = 1
            };
            Customer customer2 = new()
            {
                CustomerNumber = 1,
                CustomerName = "Chelsea",
                AnnualGiftVoucher = false,
                PurchaseLevel = 3
            };
            Customer customer3 = new()
            {
                CustomerNumber = 1,
                CustomerName = "Les",
                AnnualGiftVoucher = false,
                PurchaseLevel = 2
            };
            Customer customer4 = new()
            {
                CustomerNumber = 1,
                CustomerName = "Jerry",
                AnnualGiftVoucher = false,
                PurchaseLevel = 3
            };
            Customer customer5 = new()
            {
                CustomerNumber = 1,
                CustomerName = "Seinfeld",
                AnnualGiftVoucher = false,
                PurchaseLevel = 3
            };
            Customer customer6 = new()
            {
                CustomerNumber = 1,
                CustomerName = "Manchu",
                AnnualGiftVoucher = false,
                PurchaseLevel = 4
            };
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            customerList.Add(customer4);
            customerList.Add(customer5);
            customerList.Add(customer6);
        }
        public static void RewardCustomer(List<Customer> cust, CustomerEligibility IsCustomerEligible)
        {
            foreach (Customer customer in cust)
            {
                if (IsCustomerEligible(customer))
                {
                    Console.WriteLine($"Employee {customer.CustomerName} gets voucher.");

                }
            }
        }
        public static void Main(string[] args)
        {
            LambdaDelMain func = new LambdaDelMain();
            RewardCustomer(func.customerList, x => x.PurchaseLevel > 2);
            RewardCustomer(func.customerList, x => x.PurchaseLevel < 2);
            RewardCustomer(func.customerList, y => y.CustomerName[..1] == "S" && y.PurchaseLevel > 3);
        }
    }
}
