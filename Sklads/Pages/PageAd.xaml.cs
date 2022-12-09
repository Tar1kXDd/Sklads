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
    /// Логика взаимодействия для PageAd.xaml
    /// </summary>
    public partial class PageAd : Page
    {
        private Materiale MainMateriale = new Materiale();
        private bool isAdd = true;
        public PageAd(Materiale SelectMaterial)
        {
            InitializeComponent();
            VIDid.ItemsSource = Test_zadanieEntities1.GetContext().Edinica_izmerenia.ToList();
            NRSklad.ItemsSource = Test_zadanieEntities1.GetContext().Sklad.ToList();
            VIDid.SelectedIndex = 0;
            if (SelectMaterial!=null)
            {
                DataContext = SelectMaterial;
                isAdd = false;
            }
        }

        private void TxtTitle_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            MainMateriale.Nomer = int.Parse(TxtTitle.Text);
            MainMateriale.name = Txtcost.Text;
            MainMateriale.ostatok = int.Parse(TxtOstatok.Text);
            MainMateriale.sklad = int.Parse (NRSklad.Text);
            if (isAdd==true)
            {
                Test_zadanieEntities1.GetContext().Materiale.Add(MainMateriale);
            }
            Test_zadanieEntities1.GetContext().SaveChanges();
            MainWindow.MainFrame.Content = new Pages.MaterialPage();
        }
    }
}
