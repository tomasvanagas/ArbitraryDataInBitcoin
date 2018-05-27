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
    /// Interaction logic for HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            InitializeComponent();
            StringBuilder helpText = new StringBuilder();
            helpText.AppendLine("");
            helpText.AppendLine("AUTHOR:");
            helpText.AppendLine(" --------");
            helpText.AppendLine("    Tomas Vanagas < tomasvanagas@ymail.com >");
            helpText.AppendLine("    Vilniaus Universitetas Kauno Fakultetas");
            helpText.AppendLine("");
            helpText.AppendLine("MOTYVATION:");
            helpText.AppendLine(" --------");
            helpText.AppendLine("This software was created to explore arbitrary data on the bitcoin blockchain.");
            helpText.AppendLine("");
            helpText.AppendLine("USAGE:");
            helpText.AppendLine(" --------");
            helpText.AppendLine("Using main window you can analyze bitcoin blockchain by pressing menu button \"Analyze\"");
            helpText.AppendLine("then you will get JSON data file with all the data that matched criteria while analyzing.");
            helpText.AppendLine("(This needs whole blockchain on your disk!)");
            helpText.AppendLine("");
            helpText.AppendLine("Using main window press \"File\" -> \"Import JSON data\" to import previous scan.");
            helpText.AppendLine("Then you will see all blocks that contain valuable information in your main window,");
            helpText.AppendLine("use search tool on the top of the screen to search for matching characters - you will get");
            helpText.AppendLine("block numbers.");
            helpText.AppendLine("");
            helpText.AppendLine("Double click on block row - will open another window which shows transactions in the block.");
            helpText.AppendLine("Double click on transaction - will open another window which shows transaction outputs both");
            helpText.AppendLine("in hex and in bitcoin scripts.");
            helpText.AppendLine("");
            helpText.AppendLine("Press button on top to see hashes from transaction outputs apended and converted to readable text.");
            helpText.AppendLine("");
            helpText.AppendLine("Thank you for using this software!");

            HelpTextBlock.Text = helpText.ToString();
        }
    }
}
