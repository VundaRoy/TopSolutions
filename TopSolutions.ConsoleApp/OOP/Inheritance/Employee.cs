namespace TopSolutions.ConsoleApp.OOP.Inheritance
{
    public class Employee : IPersonalDetails
    {
        public Person GetPerson(int Id, List<Person> person)
        {
            foreach (var p in person)
            {
                if (p.Id == Id)
                 return p; 
            }
            return new Person();
        }

        public void UpdatePerson(int Id)
        {
            //update person
        }
    }
}
