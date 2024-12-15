﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.Interface.Contract;

namespace TopConsoleNunit.Test.OOP.Inheritance
{
    [TestFixture]
    public class LanguageTest
    {
        private ILanguageInfo _languageInfo;
        private List<Language> languages;

        [SetUp]
        public void Setup() => languages = new List<Language>
        {
            new Language { Name = "en", Description = "English", LanguageId = 1, NumberOfSpeakers = 1120000000, OfficialScript = "Latin" },
            new Language { Name = "fr", Description = "French", LanguageId = 2, NumberOfSpeakers = 540000000, OfficialScript = "Latin" },
            new Language { Name = "es", Description = "Spanish", LanguageId = 3, NumberOfSpeakers = 640000000, OfficialScript = "Latin" },
            new Language { Name = "zh", Description = "Mandarin", LanguageId = 4, NumberOfSpeakers = 1340000000, OfficialScript = "Simplified Chinese" },
            new Language { Name = "hi", Description = "Hindi", LanguageId = 5, NumberOfSpeakers = 850000000, OfficialScript = "Devanagari" }
        };
        [SetUp]
        public void Init()
        {
            _languageInfo = new LanguageInfoDesk();
        }

        [Test]
        public void GetLanguageTest()
        {
            //act
            var res = _languageInfo.GetLanguage(2,languages);
            //assert
            Assert.IsTrue(res.Name.Equals("fr"));

        }
    }
}