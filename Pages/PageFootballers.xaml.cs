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
    /// Логика взаимодействия для PageFootballers.xaml
    /// </summary>
    public partial class PageFootballers : Page
    {
        MainWindow mainWindow;
        public PageFootballers(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            cb_Clubs.Items.Clear();
            cb_Clubs.Items.Add(new FootballClub() { id = int.MaxValue, Name = "Все" });

            foreach (FootballClub footballClub in mainWindow.DataBase.FootballClubs)
            {
                cb_Clubs.Items.Add(footballClub);
            }

            cb_Clubs.SelectedIndex = 0;

            cb_Club.Items.Add(new FootballClub() { id = int.MaxValue, Name = "Нет" });
            foreach (FootballClub footballClub in mainWindow.DataBase.FootballClubs)
            {
                cb_Club.Items.Add(footballClub);
            }

            UpdateContent();
        }

        void UpdateContent()
        {
            FootballClub footballClub = cb_Clubs.SelectedItem as FootballClub;
            IEnumerable<Footballer> FootballersList = mainWindow.DataBase.GetFootballersClub(footballClub.id);

            if (footballClub.id == int.MaxValue)
                FootballersList = mainWindow.DataBase.Footballers;

            lb_Content.Items.Clear();
            foreach (Footballer footballer in FootballersList)
            {
                lb_Content.Items.Add(footballer);
            }
        }


        private void SelectionChangedClub(object sender, SelectionChangedEventArgs e)
        {
            UpdateContent();
        }


        private void OnBtnClick_SelectDate(object sender, RoutedEventArgs e)
        {
            SelectDate selectDate = new SelectDate(this);
            selectDate.ShowDialog();
        }


        private void SelectionChangedFootballer(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem != null)
            {
                Footballer footballer = listBox.SelectedItem as Footballer;
                tbx_Name.Text = footballer.FIO;
                tbx_SNILS.Text = footballer.SNILS;
                tbx_DateTime.Text = footballer.DateOfBirth.ToString("dd.MM.yyyy");

                btn_SaveOrEdit.Visibility = Visibility.Visible;
                btn_RemoveFootballer.Visibility = Visibility.Visible;
                btn_SaveOrEdit.Content = "Редактировать";

                cb_Club.SelectedItem = mainWindow.DataBase.GetFootballClub(footballer.ClubId);
            }
            else
            {
                tbx_Name.IsReadOnly = true;
                tbx_SNILS.IsReadOnly = true;
                tbx_Name.Text = "";
                tbx_SNILS.Text = "";
                tbx_DateTime.Text = "";

                btn_SelectDate.Visibility = Visibility.Collapsed;
                btn_SaveOrEdit.Visibility = Visibility.Collapsed;
                btn_RemoveFootballer.Visibility = Visibility.Collapsed;
                cb_Club.SelectedIndex = -1;
            }
        }
        private void OnBtnClick_AddFootballer(object sender, RoutedEventArgs e)
        {
            tbx_Name.Text = "";
            tbx_SNILS.Text = "";
            tbx_DateTime.Text = "";

            isEdit = false;
            tbx_Name.IsReadOnly = false;
            tbx_SNILS.IsReadOnly = false;
            btn_SelectDate.Visibility = Visibility.Visible;
            cb_Club.IsEnabled = true;

            lb_Content.IsEnabled = false;
            lb_Content.SelectedItem = null;
            btn_SaveOrEdit.Visibility = Visibility.Visible;
            btn_SaveOrEdit.Content = "Сохранить";
        }

        bool isEdit = true;
        private void OnBtnClick_SaveOrEdit(object sender, RoutedEventArgs e)
        {
            if (isEdit)
            {
                isEdit = false;
                tbx_Name.IsReadOnly = false;
                tbx_SNILS.IsReadOnly = false;
                cb_Club.IsEnabled = true;
                lb_Content.IsEnabled = false;
                btn_SelectDate.Visibility = Visibility.Visible;
                btn_SaveOrEdit.Content = "Сохранить";
            }
            else
            {

                if (string.IsNullOrEmpty(tbx_Name.Text))
                {
                    MessageBox.Show("Заполните ФИО!");
                    return;
                }
                if (string.IsNullOrEmpty(tbx_SNILS.Text))
                {
                    MessageBox.Show("Заполните СНИЛС!");
                    return;
                }

                DateTime dateTime = DateTime.Now;
                if (!DateTime.TryParse(tbx_DateTime.Text, out dateTime))
                {
                    MessageBox.Show("Выберите дату!");
                    return;
                }

                int clubId = int.MaxValue;
                if (cb_Club.SelectedItem != null)
                    clubId = ((FootballClub)cb_Club.SelectedItem).id;

                if (lb_Content.SelectedItem == null)
                {

                    mainWindow.DataBase.Footballers.Add(new Footballer() { FIO = tbx_Name.Text, SNILS = tbx_SNILS.Text, DateOfBirth = dateTime, ClubId = clubId });
                    mainWindow.DataBase.SaveChanges();
                    UpdateContent();

                    tbx_Name.Text = "";
                    tbx_SNILS.Text = "";
                    tbx_DateTime.Text = "";
                    tbx_Name.IsReadOnly = true;
                    tbx_SNILS.IsReadOnly = true;
                    btn_SelectDate.Visibility = Visibility.Collapsed;
                    btn_SaveOrEdit.Visibility = Visibility.Collapsed;
                }
                else
                {
                    Footballer footballer = lb_Content.SelectedItem as Footballer;

                    footballer.FIO = tbx_Name.Text;
                    footballer.SNILS = tbx_SNILS.Text;
                    footballer.DateOfBirth = dateTime;
                    footballer.ClubId = clubId;

                    mainWindow.DataBase.SaveChanges();
                    UpdateContent();
                }

                isEdit = true;
                tbx_Name.IsReadOnly = true;
                tbx_SNILS.IsReadOnly = true;
                cb_Club.IsEnabled = false;
                lb_Content.IsEnabled = true;
                btn_SelectDate.Visibility = Visibility.Collapsed;
                btn_SaveOrEdit.Content = "Редактировать";
            }
        }

        private void OnBtnClick_RemoveFootballer(object sender, RoutedEventArgs e)
        {
            if (lb_Content.SelectedItem != null)
            {
                mainWindow.DataBase.Footballers.Remove((Footballer)lb_Content.SelectedItem);
                mainWindow.DataBase.SaveChanges();
                lb_Content.Items.Remove(lb_Content.SelectedItem);
            }
        }
    }
}
