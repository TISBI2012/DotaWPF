using Learn2012.Model;
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

namespace Learn2012.Pages
{
    /// <summary>
    /// Логика взаимодействия для KatkaPage.xaml
    /// </summary>
    public partial class KatkaPage : Page
    {
        Katka contextKatka;
        public KatkaPage()
        {
            InitializeComponent();
            CBUsers.ItemsSource = App.DB.User.ToList();
            contextKatka = new Katka();
        }

        private void BAddUser_Click(object sender, RoutedEventArgs e)
        {
            var selectedUser = CBUsers.SelectedItem as User;

            var userKatka = new UserKatka();
            userKatka.User = selectedUser;
            userKatka.TeamIndex = CBTeams.SelectedIndex;

            contextKatka.UserKatka.Add(userKatka);

            DGUsers.ItemsSource = contextKatka.UserKatka.ToList();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            if(contextKatka.UserKatka.Where(x => x.TeamIndex == 0).Count() != 5 && contextKatka.UserKatka.Where(x => x.TeamIndex == 1).Count() != 5)
            {
                MessageBox.Show("В каждой команде должно быть 5 челов");
                return;
            }
            contextKatka.Date = DPDate.SelectedDate.Value;
            contextKatka.StartTime = TimeSpan.Parse(TBStartTime.Text);
            App.DB.Katka.Add(contextKatka);
            App.DB.SaveChanges();
        }
    }
}
