namespace TestVS2015
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
