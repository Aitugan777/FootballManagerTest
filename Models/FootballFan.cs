using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class FootballFan
    {
        public int id { get; set; }

        public string FIO { get; set; }

        public override string ToString()
        {
            return FIO;
        }

        /*public List<FootballClub> Clubs()
        {
            List<FootballClub> list = new List<FootballClub>();
            using (ApplicationContext database = new ApplicationContext())
            {
                foreach (FootballFanClubs footballFanClubs in database.FootballFansClubs)
                {
                    if (footballFanClubs.IdFan == Id)
                        list.Add(database.GetFootballClub(footballFanClubs.IdClub));
                }
            }
            return list;
        }*/
    }
}
