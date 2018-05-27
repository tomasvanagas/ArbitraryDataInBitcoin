using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

namespace IndividualiUzduotis
{
    public partial class MainWindow : Window
    {
        public ChainAnalysis chainAnalysisObject;
        List<Block> blockList = new List<Block>();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void ImportJson_Click(object sender, RoutedEventArgs e)
        {
            
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                ImportJson.ImportScan(dlg.FileName, blockList);
            }
            blockchainDataGrid.ItemsSource = blockList;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for using this software!", "Bye!");
            this.Close();
        }

        private void BlockchainAnalysis_Click(object sender, RoutedEventArgs e)
        {
            ChainAnalysisWindow chainAnalysisWindow = new ChainAnalysisWindow(this);
            chainAnalysisWindow.ShowDialog();
        }

        private void ViewHelp_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow dgr = blockchainDataGrid.ItemContainerGenerator.ContainerFromItem(blockchainDataGrid.SelectedItem) as DataGridRow;
            try
            {
                Block block = (Block)dgr.Item;
                if (block.TransactionList.Count>1)
                {
                    TransactionsInBlockWindow transactionsInBlockWindow = new TransactionsInBlockWindow(block);
                    transactionsInBlockWindow.ShowDialog();
                }
                else
                {
                    foreach(Transaction transaction in block.TransactionList)
                    {
                        TransactionWindow transactionWindow = new TransactionWindow(transaction);
                        transactionWindow.ShowDialog();
                    }
                }
                
            }
            catch { }
            
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("Blocks that contain string: " + SearchText.Text);
            foreach(int blockNumber in Find.String(blockList, SearchText.Text))
            {
                text.AppendLine(blockNumber.ToString());
            }
            MessageBox.Show(text.ToString(), "Search");
        }
    }
}
