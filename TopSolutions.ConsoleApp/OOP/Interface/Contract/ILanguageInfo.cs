using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Interface.Contract
{
    public interface ILanguageInfo
    {
        Language GetLanguage(int LanguageId, List<Language> languageList);
        void SetLanguage(Language language, List<Language> languageList);

    }
}
