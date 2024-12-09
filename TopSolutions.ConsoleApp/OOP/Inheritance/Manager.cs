namespace TopSolutions.ConsoleApp.OOP.Inheritance
{
    public class Manager : IPersonalDetails
    {
        public Person GetPerson(int Id, List<Person> person)
        {
            foreach (var personItem in person) 
            {
                if(personItem.Id == Id)
                return personItem;
            }
           
            return new Person();
        }

        public void UpdatePerson(int Id)
        {
            //do managerial update
        }
    }
}
