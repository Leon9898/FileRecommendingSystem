using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RocommendingSystemSolution
{
    public class NewAccount
    {
        public NewAccount(string email, string firstName, string lastName, int identificator)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Identificator = identificator;
        }

        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Identificator { get; private set; }

        










    }
}
