using FootballManager.Models;
using FootballManager.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FootballManager
{
    /// <summary>
    /// Логика взаимодействия для SelectFootballClub.xaml
    /// </summary>
    public partial class SelectFootballClub : Window
    {
        public PageFootballFans pageFootballFans;

        public SelectFootballClub(PageFootballFans pageFootballFans)
        {
            InitializeComponent();

            this.pageFootballFans = pageFootballFans;

            foreach (FootballClub footballClubs in pageFootballFans.mainWindow.DataBase.FootballClubs)
            {
                lb_Content.Items.Add(footballClubs);
            }

        }

        private void OnBtnClick_AddFootballClub(object sender, RoutedEventArgs e)
        {
            if (lb_Content.SelectedItem != null)
            {
                FootballClub footballClub = (FootballClub)lb_Content.SelectedItem;

                pageFootballFans.lb_Clubs.Items.Add(footballClub);
                if (pageFootballFans.lb_Content.SelectedItem != null)
                {
                    FootballFan footballFan = (FootballFan)pageFootballFans.lb_Content.SelectedItem;
                    pageFootballFans.mainWindow.DataBase.AddClubForFan(footballFan.id, footballClub.id);
                    pageFootballFans.mainWindow.DataBase.SaveChanges();
                }
                this.Hide();
            }
            else
                MessageBox.Show("Клуб не выбран!");
        }
    }
}
