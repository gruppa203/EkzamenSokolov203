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
using EkzamenSokolov203.ApplicationData;
using EkzamenSokolov203.Pages;



namespace EkzamenSokolov203.Pages
{
    /// <summary>
    /// Логика взаимодействия для PolzovateliPage.xaml
    /// </summary>
    public partial class PolzovateliPage : Page
    {
        public PolzovateliPage()
        {
            InitializeComponent();
            DGridPolzovateli.ItemsSource = BDSokolovEntities.GetContext().Polzovateli.ToList();
        }
    }
}
