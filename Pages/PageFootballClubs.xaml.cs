using FootballManager.Models;
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

namespace FootballManager.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageFootballClubs.xaml
    /// </summary>
    public partial class PageFootballClubs : Page
    {
        public MainWindow mainWindow;
        public PageFootballClubs(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            UpdateContent();

        }

        void UpdateContent()
        {
            lb_Content.Items.Clear();
            foreach (FootballClub footballClub in mainWindow.DataBase.FootballClubs)
            {
                lb_Content.Items.Add(footballClub);
            }
        }


        private void OnBtnClick_AddClub(object sender, RoutedEventArgs e)
        {
            tbx_NameClub.Text = "";
            tbx_CityClub.Text = "";

            isEdit = false;
            tbx_NameClub.IsReadOnly = false;
            tbx_CityClub.IsReadOnly = false;
            lb_Footballers.IsEnabled = true;
            lb_Content.IsEnabled = false;
            lb_Content.SelectedItem = null;
            btn_AddFootballers.Visibility = Visibility.Visible;
            btn_SaveOrEdit.Visibility = Visibility.Visible;
            btn_SaveOrEdit.Content = "Сохранить";
        }

        private void OnBtnClick_AddFootballer(object sender, RoutedEventArgs e)
        {
            SelectFootballer selectFootballer = new SelectFootballer(this);
            selectFootballer.ShowDialog();
        }

        private void OnBtnClick_RemoveFootballer(object sender, RoutedEventArgs e)
        {
            if (lb_Footballers.SelectedItem != null)
            {
                ((Footballer)lb_Footballers.SelectedItem).ClubId = int.MaxValue;

                lb_Footballers.Items.Remove(lb_Footballers.SelectedItem);

                mainWindow.DataBase.SaveChanges();
            }
        }

        private void SelectionChangedFootballer(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem != null)
                btn_RemoveFootballers.Visibility = Visibility.Visible;
            else
                btn_RemoveFootballers.Visibility = Visibility.Collapsed;
        }

        private void SelectionChangedClub(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem != null)
            {
                FootballClub footballClub = listBox.SelectedItem as FootballClub;
                tbx_NameClub.Text = footballClub.Name;
                tbx_CityClub.Text = footballClub.City;
                btn_SaveOrEdit.Visibility = Visibility.Visible;
                btn_RemoveClub.Visibility = Visibility.Visible;

                lb_Footballers.Items.Clear();
                foreach (Footballer footballer in mainWindow.DataBase.GetFootballersClub(footballClub.id))
                {
                    lb_Footballers.Items.Add(footballer);
                }
            }
            else
            {
                tbx_NameClub.Text = "";
                tbx_CityClub.Text = "";
                btn_SaveOrEdit.Visibility = Visibility.Collapsed;
                btn_RemoveClub.Visibility = Visibility.Collapsed;
                lb_Footballers.Items.Clear();
            }
        }


        bool isEdit = true;
        private void OnBtnClick_SaveOrEdit(object sender, RoutedEventArgs e)
        {
            if (isEdit)
            {
                isEdit = false;
                tbx_NameClub.IsReadOnly = false;
                tbx_CityClub.IsReadOnly = false;
                lb_Footballers.IsEnabled = true;
                lb_Content.IsEnabled = false;
                btn_AddFootballers.Visibility = Visibility.Visible;
                btn_SaveOrEdit.Content = "Сохранить";

            }
            else
            {
                if (lb_Content.SelectedItem == null)
                {
                    if (string.IsNullOrEmpty(tbx_NameClub.Text))
                    {
                        MessageBox.Show("Заполните наименование!");
                        return;
                    }
                    if (string.IsNullOrEmpty(tbx_CityClub.Text))
                    {
                        MessageBox.Show("Заполните город!");
                        return;
                    }


                    FootballClub footballClub = mainWindow.DataBase.FootballClubs.Add(new FootballClub() { Name = tbx_NameClub.Text, City = tbx_CityClub.Text });
                    mainWindow.DataBase.SaveChanges();

                    foreach (Footballer footballer in lb_Footballers.Items)
                    {
                        footballer.ClubId = footballClub.id;
                    }

                    mainWindow.DataBase.SaveChanges();
                    UpdateContent();

                    tbx_NameClub.Text = "";
                    tbx_CityClub.Text = "";
                    tbx_NameClub.IsReadOnly = true;
                    tbx_CityClub.IsReadOnly = true;
                    btn_SaveOrEdit.Visibility = Visibility.Collapsed;
                    lb_Footballers.Items.Clear();
                }
                else
                {
                    FootballClub footballClub = lb_Content.SelectedItem as FootballClub;

                    footballClub.Name = tbx_NameClub.Text;
                    footballClub.City = tbx_CityClub.Text;

                    mainWindow.DataBase.SaveChanges();
                    UpdateContent();
                }

                isEdit = true;
                tbx_NameClub.IsReadOnly = true;
                tbx_CityClub.IsReadOnly = true;
                lb_Footballers.IsEnabled = true;
                lb_Content.IsEnabled = true;
                btn_AddFootballers.Visibility = Visibility.Collapsed;
                btn_RemoveFootballers.Visibility = Visibility.Collapsed;
                btn_SaveOrEdit.Content = "Редактировать";
            }
        }

        private void OnBtnClick_RemoveClub(object sender, RoutedEventArgs e)
        {
            if (lb_Content.SelectedItem != null)
            {
                FootballClub footballClub = lb_Content.SelectedItem as FootballClub;

                mainWindow.DataBase.FootballClubs.Remove(footballClub);
                mainWindow.DataBase.SaveChanges();

                lb_Content.Items.Remove(lb_Content.SelectedItem);
            }
        }
    }
}

