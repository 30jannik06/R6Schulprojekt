using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R6Schulprojekt.Models
{
    public class Operator
    {
        public string Name { get; set; }
        public List<Weapon> Weapons { get; set; }

        public Operator(string name, List<Weapon> weapons)
        {
            Name = name;
            Weapons = weapons;
        }
    }
}
