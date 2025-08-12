namespace TopSolutions.ConsoleApp.Patterns.Structural.Composite.Sample
{
    public class CompositeClientMain
    {
        static Component Pranaya, Rohit, Anurag, Priyanka, Sambit, Kausalya, Karthik, Govardhan;
        static void Main(string[] args)
        {
            // The client code works with all of the components (Both Leaf and Composite) via the base interface i.e. Component.
            // Component means the class that implements the Component abstract class
            // In our example Leaf and Composite classes implement the Component abstract class
            //Creating Leaf Objects or you can say child objects
            
            CreateComponentObjects( Pranaya,  Rohit,  Anurag,  Priyanka,  Sambit,  Kausalya,  Karthik,  Govardhan);
            //Creating Composite Objects
            CreateCompositeObjects(out Composite ITDepartment, out Composite HRDepartment,
                out Composite Directors, out Composite Company);
            //Creating Tree Structure i.e. Adding Child Components inside the Composite Component
            //Adding Pranaya, Rohit, and Anurag to ITDepartment Composite Object

            //create list of IT people
            List<Component> iTTeam = new();
            iTTeam.Add(Pranaya);iTTeam.Add(Rohit);iTTeam.Add(Anurag);
            CreateITDepartment(iTTeam, ITDepartment);
            //Adding Priyanka and Sambit in HRDepartment Composite Object
            HRDepartment.AddComponent(Priyanka);
            HRDepartment.AddComponent(Sambit);
            //Adding ITDepartment and HRDepartment inside Company Composite Object
            Directors.AddComponent(Kausalya);
            Directors.AddComponent(Karthik);
            Directors.AddComponent(Govardhan);

            Company.AddComponent(ITDepartment);
            Company.AddComponent(HRDepartment);
            Company.AddComponent(Directors);
            Console.WriteLine("All Employees of the Company");
            //To Display the Price of the Computer i.e. it will display the Price of all components
            Console.WriteLine($"Total Salary of the Company: {Company.GetSalary()}");
            //To display Salaries and Employees of the IT Department
            Console.WriteLine("\nIT Department Employees");
            Console.WriteLine($"Total Salary of IT Department: {ITDepartment.GetSalary()}");
            //To display Salaries and Employees of the HR Department
            Console.WriteLine("\nHR Department Employees");
            Console.WriteLine($"Total Salary of HR Department: {HRDepartment.GetSalary()}");
            //Directors
            Console.WriteLine("\nDirectors of company");
            Console.WriteLine($"Total Salary of Directors: {Directors.GetSalary()}");
            //To display Salaries and Employees of HR Department
            Console.WriteLine("\nSalary of Employee Pranaya:");
            Pranaya.GetSalary();
            Console.WriteLine($"\nSalary of Employee Anurag: ");
            Anurag.GetSalary();
            Console.Read();
        }

        private static void CreateITDepartment(List<Component> teamList, Composite ITDepartment)
        {
            foreach (Composite t in teamList)
            {
                ITDepartment.AddComponent(t);
            }
        }

        private static void CreateCompositeObjects(out Composite ITDepartment, out Composite HRDepartment, out Composite Directors, out Composite Company)
        {
            ITDepartment = new Composite("ITDepartment", "New Ward South");
            HRDepartment = new Composite("HRDepartment", "Raiwind East");
            Directors = new Composite("Directors", "Gulbarga");
            Company = new Composite("Company", "Central Zone");
        }

        private static void CreateComponentObjects( Component Pranaya,  Component Rohit,  Component Anurag,  Component Priyanka,  Component Sambit,  Component Kausalya,  Component Karthik,  Component Govardhan)
        {
            Pranaya = new Leaf("Pranaya", "12 Anderi West Mumbai", 22000);
            Rohit = new Leaf("Rohit", "2F 223 Manikkar rd North Bhiwandi", 33000);
            Anurag = new Leaf("Anurag", "1112/23 Jyothish str East Pune", 42000);
            Priyanka = new Leaf("Priyanka", "Haridwar city", 52000);
            Sambit = new Leaf("Sambit", "RB Patel stadium", 28000);
            Kausalya = new Leaf("Kausalya", "Secundarabad road Hyderabad", 58000);
            Karthik = new Leaf("Karthik", "Jhanvi street Chennai", 48000);
            Govardhan = new Leaf("Govardhan", "Tumkur district Karnataka", 41000);
        }
    }
}
