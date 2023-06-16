using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            return $"User" +
                $"\n id : {Id}, " +
                $"\n FirstName : {FirstName}, " +
                $"\n LastName : {LastName}, " +
                $"\n UserName : {UserName}, ";

        }
    }
}
