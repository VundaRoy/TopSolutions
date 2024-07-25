using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Misc.MyGen.Model
{
    public class RegularUser<T> : UniversalUser<T>  where T : class
    {
        public string PostMemes(string userName)
        {
            string meme = "Posting meme under " + userName;
            return meme;
        }
    }
}
