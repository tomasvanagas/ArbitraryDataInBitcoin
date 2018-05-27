using System;
using System.Windows;

namespace IndividualiUzduotis
{
    /// <summary>
    /// Interaction logic for ChainAnalysisWindow.xaml
    /// </summary>
    public partial class ChainAnalysisWindow : Window
    {
        public MainWindow mainWindow;

        public ChainAnalysisWindow(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainWindow.Close();
        }

        private void HelpAnalysingChain_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void BrowseBlockchain_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BrowseJson_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private async void StartAnalysis_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.chainAnalysisObject = new ChainAnalysis();
            await mainWindow.chainAnalysisObject.AnalyseChain(blockchainPath.Text.ToString(), jsonPath.Text.ToString(), Convert.ToInt32(maxOutputs.Text), this);
        }

        private void StopAnalysis_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
        }
    }
}
