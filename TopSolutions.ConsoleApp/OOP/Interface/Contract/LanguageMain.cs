using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Interface.Contract
{
    public class LanguageMain
    {
        static List<Language> languages;
        public LanguageMain()
        {
            languages = new List<Language>();

            languages.AddRange(new List<Language>{
               new Language { Name = "en", Description = "English", LanguageId = 1, NumberOfSpeakers = 1120000000, OfficialScript = "Latin" },
               new Language { Name = "fr", Description = "French", LanguageId = 2, NumberOfSpeakers = 540000000, OfficialScript = "Latin" },
               new Language { Name = "es", Description = "Spanish", LanguageId = 3, NumberOfSpeakers = 640000000, OfficialScript = "Latin" },
               new Language { Name = "zh", Description = "Mandarin", LanguageId = 4, NumberOfSpeakers = 1340000000, OfficialScript = "简体中文 (Simplified Chinese)" },
               new Language { Name = "hi", Description = "Hindi", LanguageId = 5, NumberOfSpeakers = 850000000, OfficialScript = "देवनागरी (Devanagari)" }
});

        }
        public static void Main(string[] args)
        {
            LanguageMain lm = new LanguageMain();
            ILanguageInfo _langInfo = new LanguageInfoDesk();
            var res = _langInfo.GetLanguage(3, languages);
            Console.WriteLine($"Name is {res.Name} and description is {res.Description}");

            var scriptList = languages.Select(lang => lang.OfficialScript).ToList();
        }
    }
}
