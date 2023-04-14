using FootballManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FootballManager
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection") { }

        /// <summary>
        /// Возвращает футбольный клуб
        /// </summary>
        /// <param name="id">Ид клуба</param>
        /// <returns></returns>
        public FootballClub GetFootballClub(int id) => FootballClubs.Where(f => f.id == id).FirstOrDefault();

        /// <summary>
        /// Возвращает фаната
        /// </summary>
        /// <param name="id">Ид фаната</param>
        /// <returns></returns>
        public FootballFan GetFootballFan(int id) => FootballFans.Where(f => f.id == id).FirstOrDefault();

        /// <summary>
        /// Возвращает список футболистов клуба
        /// </summary>
        /// <param name="id">Ид футбольного клуба</param>
        /// <returns></returns>
        public List<Footballer> GetFootballersClub(int id) => Footballers.Where(f => f.ClubId == id).ToList();

        /// <summary>
        /// Возвращает список клубов за которое болеет фанат
        /// </summary>
        /// <param name="id">Ид фаната</param>
        public List<FootballClub> GetFanClubs(int id)
        {
            List<FootballClub> footballClubs = new List<FootballClub>();

            foreach (FootballFanClubs footballFanClubs in FootballFansClubs)
            {
                if (id == footballFanClubs.IdFan)
                    footballClubs.Add(GetFootballClub(footballFanClubs.IdClub));
            }
            return footballClubs;
        }

        /// <summary>
        /// Возвращает список болельщиков клуба
        /// </summary>
        /// <param name="id">Ид клуба</param>
        /// <returns></returns>
        public List<FootballFan> GetClubFans(int id)
        {
            List<FootballFan> footballFans = new List<FootballFan>();

            foreach (FootballFanClubs footballFanClubs in FootballFansClubs)
            {
                if (id == footballFanClubs.IdClub)
                    footballFans.Add(GetFootballFan(footballFanClubs.IdFan));
            }
            return footballFans;
        }

        /// <summary>
        /// Добавляет футбольный клуб для фаната
        /// </summary>
        /// <param name="idFan">Ид фаната</param>
        /// <param name="idClub">Ид клуба</param>
        public void AddClubForFan(int idFan, int idClub)
        {
            FootballFansClubs.Add(new FootballFanClubs() { IdFan = idFan, IdClub = idClub });
        }

        /// <summary>
        /// Удаляет футбольный клуб для фаната
        /// </summary>
        /// <param name="idFan">Ид фаната</param>
        /// <param name="idClub">Ид клуба</param>
        public void RemoveClubForFun(int idFan, int idClub)
        {
            FootballFansClubs.Remove(FootballFansClubs.Where(f => f.IdFan == idFan && f.IdClub == idClub).FirstOrDefault());
        }

        /// <summary>
        /// Удаляет фаната и связи с футбольными клубами
        /// </summary>
        /// <param name="footballFan">Фанат</param>
        public void RemoveFootballFan(FootballFan footballFan)
        {
            List<FootballFanClubs> footballFanClubsForRemove = new List<FootballFanClubs>();
            foreach (FootballFanClubs footballFanClubs in FootballFansClubs)
                if (footballFanClubs.IdFan == footballFan.id)
                    footballFanClubsForRemove.Add(footballFanClubs);

            foreach (FootballFanClubs footballFanClubs in footballFanClubsForRemove)
                FootballFansClubs.Remove(footballFanClubs);

            FootballFans.Remove(footballFan);
            this.SaveChanges();
        }

        public DbSet<FootballClub> FootballClubs { get; set; }
        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<FootballFan> FootballFans { get; set; }
        public DbSet<FootballFanClubs> FootballFansClubs { get; set; }

    }
}
