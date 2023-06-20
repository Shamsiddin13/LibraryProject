namespace LibraryProject
{
    internal class LibraryManagment : LibraryManagmentCore
    {
        private EmailService emailService;
        public void RegisterUser(string firstName, string LastName)
        {
            emailService = new EmailService();
        }

        public void RegisterUser(string firstName, string LastName, string userName)
        {
            var foundUser = false;

            foreach (var user in Store.Users)
            {
                if (user.Email == userName)
                {
                    foundUser = true;
                    break;
                }

            }

            if (foundUser)
                return;


            Store.Users.Add(new User(firstName, LastName, userName));
            emailService.SendEmail(userName);

        }
    }
}
