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
    /// Interaction logic for HeroPage.xaml
    /// </summary>
    public partial class HeroPage : Page
    {
        Hero contextHero;
        public HeroPage()
        {
            InitializeComponent();
            CBAttackType.ItemsSource = App.DB.AttackType.ToList();
            contextHero = new Hero();
            DataContext = contextHero;
        }

        private void BAddHero_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";
            //различные проверки на валидность
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            //добавление и сохранение в бд
            App.DB.Hero.Add(contextHero);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
