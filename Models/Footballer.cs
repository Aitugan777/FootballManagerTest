using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class Footballer
    {
        public int id { get; set; }

        public string FIO { get; set; }

        public string SNILS { get; set; }

        public int ClubId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return FIO;
        }
    }
}
