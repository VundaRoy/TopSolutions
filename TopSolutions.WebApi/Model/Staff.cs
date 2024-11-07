namespace TopSolutions.WebApi.Model
{
    public class Staff
    {
        public string UserName { get; set; }
        public int StaffId { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string SubNationalEntity  { get; set; }
        public string Country { get; set; }
        
    }
}
