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

namespace PoEStreamLootOverlay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CurrencyList currencyList;
        public MainWindow()
        {
            InitializeComponent();
            currencyList = new CurrencyList();
            ExaltView.DataContext = CurrencyList.currencyList["Exalted Orb"];
            DivineView.DataContext = CurrencyList.currencyList["Divine Orb"];
            AnnulmentView.DataContext = CurrencyList.currencyList["Annulment Orb"];
            ChaosView.DataContext = CurrencyList.currencyList["Chaos Orb"];

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            currencyList.Reset();
        }
    }
}
