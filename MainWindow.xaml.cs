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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FootballManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ApplicationContext DataBase = new ApplicationContext();
        PageFootballClubs footballClubsPage;
        PageFootballers footballersPage;
        PageFootballFans footballerFansPage;

        public MainWindow()
        {
            InitializeComponent();
            footballClubsPage = new PageFootballClubs(this);
            footballersPage = new PageFootballers(this);
            footballerFansPage = new PageFootballFans(this);
            f_Content.Content = footballClubsPage;
        }

        private void OnBtnClick_Clubs(object sender, RoutedEventArgs e)
        {
            f_Content.Content = footballClubsPage;
        }

        private void OnBtnClick_Footballers(object sender, RoutedEventArgs e)
        {
            f_Content.Content = footballersPage;
        }

        private void OnBtnClick_Fans(object sender, RoutedEventArgs e)
        {
            f_Content.Content = footballerFansPage;
        }
    }
}
