using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP
{
    public class Delivery
    {
        public Delivery() 
        {
            SaveFile savedFile = new SaveFile();
            ISaveable saved = savedFile;
            saved.Save();
        
        }
        
    }
}
