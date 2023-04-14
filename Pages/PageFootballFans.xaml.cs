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
    /// Логика взаимодействия для PageFootballFans.xaml
    /// </summary>
    public partial class PageFootballFans : Page
    {
        public MainWindow mainWindow;
        public PageFootballFans(MainWindow mainWindow)
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

            UpdateContent();
        }

        void UpdateContent()
        {
            FootballClub footballClub = cb_Clubs.SelectedItem as FootballClub;
            IEnumerable<FootballFan> FootballFanList = mainWindow.DataBase.GetClubFans(footballClub.id);

            if (footballClub.id == int.MaxValue)
                FootballFanList = mainWindow.DataBase.FootballFans;

            lb_Content.Items.Clear();
            foreach (FootballFan footballFan in FootballFanList)
            {
                lb_Content.Items.Add(footballFan);
            }
        }

        private void OnBtnClick_AddClub(object sender, RoutedEventArgs e)
        {
            SelectFootballClub selectFootballClub = new SelectFootballClub(this);
            selectFootballClub.ShowDialog();
        }

        private void SelectionChangedClub(object sender, SelectionChangedEventArgs e)
        {
            if (lb_Clubs.SelectedItem != null)
                btn_RemoveClub.Visibility = Visibility.Visible;
            else
                btn_RemoveClub.Visibility = Visibility.Collapsed;
        }

        private void SelectionChangedFootballFan(object sender, SelectionChangedEventArgs e)
        {

            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem != null)
            {
                FootballFan footballFan = listBox.SelectedItem as FootballFan;
                tbx_Name.Text = footballFan.FIO;

                btn_SaveOrEdit.Visibility = Visibility.Visible;
                btn_SaveOrEdit.Content = "Редактировать"; ;
                btn_RemoveFootballFan.Visibility = Visibility.Visible;

                lb_Clubs.Items.Clear();
                foreach (FootballClub footballClub in mainWindow.DataBase.GetFanClubs(footballFan.id))
                {
                    lb_Clubs.Items.Add(footballClub);
                }
            }
            else
            {
                tbx_Name.IsReadOnly = true;
                tbx_Name.Text = "";

                lb_Clubs.Items.Clear();

                btn_AddClub.Visibility = Visibility.Collapsed;
                btn_RemoveFootballFan.Visibility = Visibility.Collapsed;
                btn_SaveOrEdit.Visibility = Visibility.Collapsed;
            }
        }



        //Событие при выборке клуба для сортировки
        private void SelectionChangedClubs(object sender, SelectionChangedEventArgs e)
        {
            UpdateContent();
        }

        private void OnBtnClick_AddFootballFan(object sender, RoutedEventArgs e)
        {
            lb_Content.IsEnabled = false;
            lb_Content.SelectedItem = null;

            tbx_Name.Text = "";

            isEdit = false;
            tbx_Name.IsReadOnly = false;
            btn_AddClub.Visibility = Visibility.Visible;

            btn_SaveOrEdit.Visibility = Visibility.Visible;
            btn_SaveOrEdit.Content = "Сохранить";

            lb_Clubs.Items.Clear();
        }

        bool isEdit = true;
        private void OnBtnClick_SaveOrEdit(object sender, RoutedEventArgs e)
        {
            if (isEdit)
            {
                isEdit = false;
                tbx_Name.IsReadOnly = false;
                cb_Clubs.IsEnabled = true;
                lb_Content.IsEnabled = false;
                btn_AddClub.Visibility = Visibility.Visible;
                btn_SaveOrEdit.Content = "Сохранить";
            }
            else
            {

                if (string.IsNullOrEmpty(tbx_Name.Text))
                {
                    MessageBox.Show("Заполните ФИО!");
                    return;
                }


                if (lb_Content.SelectedItem == null)
                {

                    FootballFan footballFan = mainWindow.DataBase.FootballFans.Add(new FootballFan() { FIO = tbx_Name.Text });
                    mainWindow.DataBase.SaveChanges();

                    foreach (FootballClub footballClub in lb_Clubs.Items)
                    {
                        mainWindow.DataBase.AddClubForFan(footballFan.id, footballClub.id);
                    }

                    mainWindow.DataBase.SaveChanges();
                    UpdateContent();
                    tbx_Name.Text = "";
                    tbx_Name.IsReadOnly = true;
                    btn_AddClub.Visibility = Visibility.Collapsed;
                    btn_SaveOrEdit.Visibility = Visibility.Collapsed;
                    lb_Clubs.Items.Clear();
                }
                else
                {
                    FootballFan footballFan = lb_Content.SelectedItem as FootballFan;

                    footballFan.FIO = tbx_Name.Text;

                    mainWindow.DataBase.SaveChanges();
                    UpdateContent();
                }

                isEdit = true;
                tbx_Name.IsReadOnly = true;
                lb_Content.IsEnabled = true;
                btn_AddClub.Visibility = Visibility.Collapsed;
                btn_SaveOrEdit.Content = "Редактировать";
            }
        }

        private void OnBtnClick_RemoveClub(object sender, RoutedEventArgs e)
        {
            if (lb_Clubs.SelectedItem != null)
            {
                if (lb_Content.SelectedItem != null)
                {
                    FootballFan footballFan = lb_Content.SelectedItem as FootballFan;
                    mainWindow.DataBase.RemoveClubForFun(footballFan.id, ((FootballClub)lb_Clubs.SelectedItem).id);
                    mainWindow.DataBase.SaveChanges();
                }

                lb_Clubs.Items.Remove(lb_Clubs.SelectedItem);
            }
        }

        private void OnBtnClick_RemoveFan(object sender, RoutedEventArgs e)
        {
            if (lb_Content.SelectedItem != null)
            {
                FootballFan footballFan = lb_Content.SelectedItem as FootballFan;
                mainWindow.DataBase.RemoveFootballFan(footballFan);
                mainWindow.DataBase.SaveChanges();
                lb_Content.Items.Remove(lb_Content.SelectedItem);
            }
        }
    }
}
