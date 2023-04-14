using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class FootballClub
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public override string ToString()
        {
            if (id == int.MaxValue)
                return Name;
            return $"{Name} | {City}";
        }
    }
}
