using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_IceTask3
{
    public class RoyalMember
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsAlive { get; set; }

        public RoyalMember() { }

        public RoyalMember(string name, DateTime dob, bool isAlive)
        {
            Name = name;
            DateOfBirth = dob;
            IsAlive = isAlive;
        }

        public override string ToString()
        {
            return $"{Name} (Born {DateOfBirth.ToShortDateString()}, Alive: {IsAlive})";
        }
    }
}