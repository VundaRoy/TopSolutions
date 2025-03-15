using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Exceptions.Cascading
{
    public class CascadingException
    {
        public void FirstCall()
        {
            try
            {
                SecondCall();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void SecondCall()
        {
            AlternateThirdCall();
            //ThirdCall();
        }
        private void ThirdCall()
        {
            //try
            //{
                var terminal = Rebooted(null);
            //}
            //catch (Exception ex) 
            //{
            //    throw;
            //}
        }
        private void AlternateThirdCall()
        {
            var terminal = Rebooted(null);  //throws exception to grand-parent
        }
        private bool Rebooted(string TerminalId)
        {
            if ("0".Equals(TerminalId.Trim()))
                return false;
            else
                return true;
        }
        public static void Main(string[] args)
        {
            CascadingException ce = new();
            ce.FirstCall();
        }
    }
}
