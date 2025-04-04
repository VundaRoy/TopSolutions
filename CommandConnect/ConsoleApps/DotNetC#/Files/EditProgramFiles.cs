using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandConnect.ConsoleApps.DotNetC_.Files
{
    public class EditProgramFiles
    {
        public void ReplaceTextWith(string oldText, string newText, string fileName)
        {
            string content = File.ReadAllText(fileName);
            content = content.Replace(oldText, newText);
            File.WriteAllText(fileName, content);
            
        }
    }
}
