using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static R6Schulprojekt.BaseWindow;

namespace R6Schulprojekt.Models
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Recoil { get; set; }

        public Weapon(string name, int recoil)
        {
            Name = name;
            Recoil = recoil;
        }
    }
}
