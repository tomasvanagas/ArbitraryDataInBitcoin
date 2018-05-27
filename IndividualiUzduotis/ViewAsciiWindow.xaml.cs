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
    /// Interaction logic for ViewAsciiWindow.xaml
    /// </summary>
    public partial class ViewAsciiWindow : Window
    {
        public ViewAsciiWindow(Transaction transaction)
        {
            InitializeComponent();
            textBlock.Text =  transaction.TransactionToAscii();
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
    }
}
