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
            CBAttackTypes.ItemsSource = App.DB.AttackType.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void BAddHero_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HeroPage());
        }

        private void Refresh()
        {
            var filtred = App.DB.Hero.ToList();
            var searchText = TBSearch.Text.ToLower();
            AttackType selectedAttackType = CBAttackTypes.SelectedItem as AttackType;

            if (string.IsNullOrWhiteSpace(searchText) == false)
            {
                filtred = filtred.Where(x => x.Name.ToLower().Contains(searchText) ||
                                             x.Lore.ToLower().Contains(searchText)).ToList();
            }

            if (selectedAttackType != null)
                filtred = filtred.Where(x => x.AttackTypeId == selectedAttackType.Id).ToList();


            DGHeroes.ItemsSource = filtred.ToList();
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void CBAttackTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
