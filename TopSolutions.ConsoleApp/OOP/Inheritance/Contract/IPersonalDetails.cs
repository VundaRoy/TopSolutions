namespace TopSolutions.ConsoleApp.OOP.Inheritance
{
    public interface IPersonalDetails
    {
        Person GetPerson(int Id, List<Person> person);
        void UpdatePerson(int Id);
    }
}
