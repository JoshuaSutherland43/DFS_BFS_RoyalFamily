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

        public RoyalMember() { }

        public RoyalMember(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}