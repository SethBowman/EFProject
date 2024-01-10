using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    public class User
    {
        public User()
        {
            
        }
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
