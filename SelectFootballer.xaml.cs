using FootballManager.Models;
using FootballManager.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для SelectFootballer.xaml
    /// </summary>
    public partial class SelectFootballer : Window
    {
        PageFootballClubs pageFootballClubs;
        public SelectFootballer(PageFootballClubs pageFootballClubs)
        {
            InitializeComponent();
            this.pageFootballClubs = pageFootballClubs;
            UpdateContent();
        }

        void UpdateContent()
        {
            lb_Content.Items.Clear();
            if (pageFootballClubs != null)
            {
                foreach (Footballer footballer in pageFootballClubs.mainWindow.DataBase.Footballers)
                {
                    if (cb_busy.SelectedIndex == 1)
                    {
                        if (footballer.id == int.MaxValue)
                            lb_Content.Items.Add(footballer);
                    }
                    else
                        lb_Content.Items.Add(footballer);
                }
            }
        }


        private void OnBtnClick_AddFootballer(object sender, RoutedEventArgs e)
        {
            if (lb_Content.SelectedItem != null)
            {
                Footballer footballer = (Footballer)lb_Content.SelectedItem;

                pageFootballClubs.lb_Footballers.Items.Add(footballer);
                if (pageFootballClubs.lb_Content.SelectedItem != null)
                {
                    footballer.ClubId = ((FootballClub)pageFootballClubs.lb_Content.SelectedItem).id;
                    pageFootballClubs.mainWindow.DataBase.SaveChanges();
                }
                this.Hide();
            }
            else
                MessageBox.Show("Футболист не выбран!");
        }

        private void SelectionChangedClub(object sender, SelectionChangedEventArgs e)
        {
            UpdateContent();
        }
    }
}
