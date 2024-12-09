using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance
{
    public class InheritanceMain
    {
        static List<Person> persons;
        public static void Main(string[] args)
        {
            var personList = InitList();
            IPersonalDetails _deptEmployee = new Employee();
            IPersonalDetails _regionalManager = new Employee();
            var deptEmp = _deptEmployee.GetPerson(123, personList);
            Console.WriteLine(deptEmp.Name);
            var manager = _regionalManager.GetPerson(124, personList);
            Console.WriteLine(manager.Name);

        }

        public static List<Person> InitList()
        {
            persons = new List<Person>();
            for (int i = 0; i < 5; i++)
            {
                var p = new Person()
                {
                    Name = "Graindler"+ i,
                    Id = 123 + i,
                    Age = 23 + i,
                    Position = "Foreman"

                };
                persons.Add(p);
            }
           
            return persons;

        }
    }
}
