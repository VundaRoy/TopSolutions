namespace TopSolutions.ConsoleApp.OOP.Inheritance
{
    public class Employee : IPersonalDetails
    {
        public Person GetPerson(int Id)
        {
            Person person = new Person();
            return person;
        }

        public void UpdatePerson(int Id)
        {
            //update person
        }
    }
}
