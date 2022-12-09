using Sklads.DataAp;
using Sklads.Pages;
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

namespace Sklads
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame MainFrame;
        public MainWindow(string txt)
        {
            InitializeComponent();
            MainFrame = frmMain;
            if (txt == "45")
            {

                FrameObj.frameMain = frmMain;
                frmMain.Content = new Page2();
            }
            else
            {

            }
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void NavigateMaterial(object sender, RoutedEventArgs e)
        {

            MainFrame.Content = new Pages.MaterialPage();
        }

        private void NavigateSklad(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Pages.Sklad();


        }

        private void NavigateMainWin(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page2();

        }
    }
}

