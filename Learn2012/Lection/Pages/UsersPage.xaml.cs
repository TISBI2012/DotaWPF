using Lection.Model;
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

namespace Lection.Pages
{
    /// <summary>
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
        }

        private void BAddUser_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserPage(new User()));
        }

        private void BEditUser_Click(object sender, RoutedEventArgs e)
        {
            var selectedUser = DGUsers.SelectedItem as User;
            if (selectedUser == null)
            {
                MessageBox.Show("Выберите пользователя");
                return;
            }
            NavigationService.Navigate(new UserPage(selectedUser));
        }

        private void Refresh()
        {
            DGUsers.ItemsSource = App.DB.User.ToList();

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void BRemove_Click(object sender, RoutedEventArgs e)
        {
            var selectedUser = DGUsers.SelectedItem as User;
            if (selectedUser == null)
            {
                MessageBox.Show("Выберите пользователя");
                return;
            }
            App.DB.User.Remove(selectedUser);
            App.DB.SaveChanges();
            Refresh();
        }
    }
}
