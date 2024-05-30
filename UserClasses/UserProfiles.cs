namespace UserClasses
{
    public class UserProfiles : UserData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int Reputation {  get; set; }
        public int Selling {  get; set; }
        public string Location { get; set; }
        public string Joined { get; set; }
        public  string Description { get; set; }
        public int ProfileId { get; set; }
    }
}