using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    internal class LibraryManagment : LibraryManagmentCore
    {
        public void RegisterUser(string firstName, string LastName)
        {

        }

        public void RegisterUser(string firstName, string LastName, string userName)
        {
            var foundUser = false;

            foreach (var user in Store.Users)
            {
                if (user.UserName == userName)
                    {
                    foundUser = true;
                    break;
                }

            }

            if (foundUser)
                return;


            Store.Users.Add(new User(firstName, LastName, userName));
     
        
        }
    }
}
