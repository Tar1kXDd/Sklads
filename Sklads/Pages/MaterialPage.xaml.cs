using Sklads.DataAp;
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

namespace Sklads.Pages
{
    /// <summary>
    /// Логика взаимодействия для MaterialPage.xaml
    /// </summary>
    public partial class MaterialPage : Page
    {
        public MaterialPage()
        {
            InitializeComponent();
            var currentMaterial = Test_zadanieEntities1.GetContext().Materiale.ToList();
            LViewTours.ItemsSource=currentMaterial;
        }

        private void EditMaterialNavigate(object sender, MouseButtonEventArgs e)
        {
            Materiale SelestMaterial = (sender as Grid).DataContext as Materiale;
            MainWindow.MainFrame.Content = new Pages.PageAd(SelestMaterial);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Domat(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Content = new Pages.PageAd(null);


        }
    }
}
