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
using System.Windows.Shapes;

namespace IndividualiUzduotis
{
    /// <summary>
    /// Interaction logic for TransactionWindow.xaml
    /// </summary>
    public partial class TransactionWindow : Window
    {
        Transaction transaction;
        public TransactionWindow(Transaction transaction)
        {
            this.transaction = transaction;
            InitializeComponent();
            TransactionTextBlock.Text = "Transaction Hash: " + transaction.TransactionHash + "\nNumber Of Outputs: " + transaction.TransactionOutputList.Count;
            this.Title = "Transaction: " + transaction.TransactionHash;
            transactionDataGrid.ItemsSource = transaction.TransactionOutputList;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ViewHelp_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewAsciiWindow viewAsciiWindow = new ViewAsciiWindow(transaction);
            viewAsciiWindow.ShowDialog();
        }
    }
}
