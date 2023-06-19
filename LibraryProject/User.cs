namespace LibraryProject
{
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public User(string firstname, string lastname)
        {
            Id = Guid.NewGuid();
            FirstName = firstname;
            LastName = lastname;
        }

        public User(string firstname, string lastname, string username) : this(firstname, lastname)
        {
            UserName = username;
        }

        public override string ToString()
        {
            return $"Foydalanuvchi" +
            $"\n id : {Id}, " +
                $"\n ismi : {FirstName}, " +
                $"\n familyasi : {LastName}" +
                $"\n sharifi : {UserName}\n";

        }
    }
}
