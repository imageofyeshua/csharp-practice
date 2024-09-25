using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Convention
{
    public class Person
    {
        public string GivenName { get; private set; }
        public string FamilyName { get; private set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string familyName, string givenName)
        {
            FamilyName = familyName;
            GivenName = givenName;
        }

        public string Name => FamilyName + " " + GivenName;
    }
}