using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Sealed
{
    public class SealedMain 
    {
        public static void Main()
        {
            SealedClass sealedObj = new SealedClass();
            sealedObj.DisplayMessage();
            //using virtual method
            OverrideClass overrideObj = new();
            overrideObj.MethodA();
            //using subclass that overrides the virtual method
            SubClassOverride subClassOverrideObj = new();
            subClassOverrideObj.MethodA();
            
        }
    }
}
