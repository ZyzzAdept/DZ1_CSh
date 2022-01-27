using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    internal class User
    {
        internal string Name { set; get; }
        internal string Password { set; get; }
        internal bool IsAdmin { set; get; }
        internal int Balance { set; get; } 

        internal User(string name, string password, bool isAdmin, int balance)
        {
            Name = name;
            Password = password;
            Balance = balance;
            IsAdmin = isAdmin;
        }
    }
}
