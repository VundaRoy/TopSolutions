using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Encapsulation
{
    public class MillStaff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        private int staffType;
        private int StaffType
        {
            get { return staffType; }
            set { staffType = value; }
        }

    }
}
