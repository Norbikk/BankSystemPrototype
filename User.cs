using System;
using System.Collections.Generic;

namespace BankSystemPrototype
{
    class User
        
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Secondname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public List<Account> Accounts { get; set; } = new List<Account>();


        public User()
        { 
        }

        public override string ToString() => $"{Surname} {Name} {Secondname}";

    }
}
