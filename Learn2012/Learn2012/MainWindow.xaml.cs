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
using Learn2012.AppWindows;
using Learn2012.Pages;

namespace Learn2012
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new MainMenuPage());

        }
        //метод для кнопки
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }

        private void ListPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            //закрытие приложения
            App.Current.Shutdown();
        }

        private void BMessage_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Вы отправили: " + TBMessage.Text);
        }

        private void BProfile_Click(object sender, RoutedEventArgs e)
        {
            //1. прописать using если это необходимо
            //2. создать переменную для окна
            ProfileWindow profileWindow = new ProfileWindow();
            //3. вызвать на переменной метод Show() или ShowDialog()
            //profileWindow.Show();
            profileWindow.ShowDialog();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoginPage());
        }

        private void BUsers_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HeroesPage());
        }

        private void BSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BMainMenu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
