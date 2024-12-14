using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Interface.Contract
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long NumberOfSpeakers { get; set; }
        public string OfficialScript { get; set; }  
    }
}
