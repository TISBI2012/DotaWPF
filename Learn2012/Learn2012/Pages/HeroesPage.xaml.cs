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
    public partial class HeroesPage : Page
    {
        public HeroesPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGHeroes.ItemsSource = App.DB.Hero.ToList();
        }

        private void BAddHero_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HeroPage());
        }
    }
}
