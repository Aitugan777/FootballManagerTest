using FootballManager.Pages;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для SelectDate.xaml
    /// </summary>
    public partial class SelectDate : Window
    {
        PageFootballers pageFootballers;
        public SelectDate(PageFootballers pageFootballers)
        {
            InitializeComponent();
            this.pageFootballers = pageFootballers;
        }

        private void OnBtnClick_Select(object sender, RoutedEventArgs e)
        {
            if (c_SelectDate.SelectedDate != null)
            {
                DateTime dateTime = (DateTime)c_SelectDate.SelectedDate;
                pageFootballers.tbx_DateTime.Text = dateTime.ToString("dd.MM.yyyy", new CultureInfo("ru-RU"));
                this.Close();
            }
            else
                MessageBox.Show("Дата не выбрана!");
        }
    }
}
