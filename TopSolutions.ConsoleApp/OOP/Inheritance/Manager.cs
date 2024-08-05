namespace TopSolutions.ConsoleApp.OOP.Inheritance
{
    public class Manager : IPersonalDetails
    {
        public Person GetPerson(int Id)
        {
            Person person = new Person();
           
            return person;
        }

        public void UpdatePerson(int Id)
        {
            //do managerial update
        }
    }
}
