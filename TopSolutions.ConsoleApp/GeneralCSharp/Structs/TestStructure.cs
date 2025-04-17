﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Structs
{
    public class TestStructure
    {
        public static void Main(string[] args)
        {
            BooksStruct book1 = new();
            BooksStruct book2 = new();
            BooksStruct cantonese = new();

            book1.getBookInfo("French English Phrases", "A full on language book", "Harrap Editors", "Language learning");
            book2.getBookInfo("Structural Pattern", "Go4 typical books for engineers", "Keith Reigh", "Software engineering");
            cantonese.getBookInfo("Streetwise Cantonese", "Learn like a Hongkonger", "Sidney Lau", "Language Learning");
            book1.displayBook();
            book2.displayBook();
            cantonese.displayBook();

            Console.ReadKey();

        }
    }
}
