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
    /// Interaction logic for TransactionsInBlockWindow.xaml
    /// </summary>
    public partial class TransactionsInBlockWindow : Window
    {
        Block block;
        public TransactionsInBlockWindow(Block block)
        {
            InitializeComponent();
            this.block = block;
            BlockTextBlock.Text = "Block Number: " + block.BlockNumber + "\nBlock Hash: " + block.BlockHash + "\nBlockVersion: " + block.BlockVersion;
            blockDataGrid.ItemsSource = block.TransactionList;
            this.Title = "Block No: " + block.BlockNumber;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ViewHelp_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow dgr = blockDataGrid.ItemContainerGenerator.ContainerFromItem(blockDataGrid.SelectedItem) as DataGridRow;
            TransactionWindow transactionWindow = new TransactionWindow((Transaction)dgr.Item);
            transactionWindow.ShowDialog();
        }
    }
}
