using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Interface.Contract
{
    public class LanguageInfoDesk : ILanguageInfo
    {
        public Language GetLanguage(int langId, List<Language> languageList)
        {
            if (languageList != null)
            {
                foreach (Language lang in languageList)
                {
                    if (lang.LanguageId == langId)
                    {
                        return lang;
                    }
                }
            }
            return new Language();
        }

        public void SetLanguage(Language language, List<Language> languageList)
        {
            foreach(Language lang in languageList)
            {
                if(language.LanguageId == lang.LanguageId)
                {
                    lang.Name = language.Name;
                    lang.Description = language.Description;
                    lang.OfficialScript = language.OfficialScript;
                    lang.NumberOfSpeakers = language.NumberOfSpeakers;
                    
                }
            }
        }
    }
}
