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

namespace FinalPoeProg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Display display = new Display();
            display.DisplayExpensess(this);
            display.RemainingAmount(this);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ExpesenAmounts expesenAmount = new ExpesenAmounts();
            expesenAmount.ExpenseDatails(this);
        }

        private void BTnreset_Click(object sender, RoutedEventArgs e)
        {
            TBxdisplay.Text = "";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TXTdeposit.Visibility = Visibility.Hidden;
            TXTinterestRate.Visibility = Visibility.Hidden;
            TXTmonthlyrepay.Visibility = Visibility.Hidden;
            TXTpurchaseprice.Visibility = Visibility.Hidden;

            TBxdeposit.Visibility = Visibility.Hidden;
            TBxinterestRate.Visibility = Visibility.Hidden;
            TBxmonthlyrepay.Visibility = Visibility.Hidden;
            TBxpurchaseprice.Visibility = Visibility.Hidden;

            TXTmonthrentalMonth.Visibility = Visibility.Visible;
            TBxrenting.Visibility = Visibility.Visible;
          
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            TXTmonthrentalMonth.Visibility = Visibility.Hidden;
            TBxrenting.Visibility = Visibility.Hidden;

            TXTdeposit.Visibility = Visibility.Visible;
            TXTinterestRate.Visibility = Visibility.Visible;
            TXTmonthlyrepay.Visibility = Visibility.Visible;
            TXTpurchaseprice.Visibility = Visibility.Visible;

            TBxdeposit.Visibility = Visibility.Visible;
            TBxinterestRate.Visibility = Visibility.Visible;
            TBxmonthlyrepay.Visibility = Visibility.Visible;
            TBxpurchaseprice.Visibility = Visibility.Visible;
           
            Homeloan homeloan = new Homeloan();
            homeloan.HomeExpense(this);
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
