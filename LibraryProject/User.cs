namespace LibraryProject
{
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        private User(string firstname, string lastname)
        {
            Id = Guid.NewGuid();
            FirstName = firstname;
            LastName = lastname;
        }

        public User(string firstname, string lastname, string username) : this(firstname, lastname)
        {
            Email = username;
        }

        public override string ToString()
        {
            return $"Foydalanuvchi" +
            $"\n id : {Id}, " +
                $"\n ismi : {FirstName}, " +
                $"\n familyasi : {LastName}" +
                $"\n sharifi : {Email}\n";

        }
    }
}
