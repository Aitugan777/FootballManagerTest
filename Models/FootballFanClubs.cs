using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class FootballFanClubs
    {
        public int id { get; set; }

        public int IdFan { get; set; }

        public int IdClub { get; set; }
    }
}
