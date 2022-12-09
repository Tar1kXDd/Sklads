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
    /// Логика взаимодействия для Sklad.xaml
    /// </summary>
    public partial class Sklad : Page
    {
        public Sklad()
        {
            InitializeComponent();
            var currentSklad = Test_zadanieEntities1.GetContext().Sklad.ToList();
            SDiewTours.ItemsSource = currentSklad;


        }


    }
}


    

