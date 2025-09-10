using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Structs.Inherit
{
    public struct ShoppingCart : ICheckList
    {
        public string GetInfoByFormId(int FormId)
        {
            string info = "";
            return info = FormId > 2 ? "over rated" : "under rated";
        }
    }
}
