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
using System.IO;

namespace dotNet
{
    /// <summary>
    /// Interaction logic for viewPlayers.xaml
    /// </summary>
    public partial class viewPlayers : Window
    {
        public viewPlayers()
        {
            InitializeComponent();
            rtb.Document.Blocks.Clear();
            string path = "PlayerData.txt";
            
            


            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
                string textFile = File.ReadAllText(path);
                rtb.Selection.Text = textFile;

            }
            else if (File.Exists(path))
            {
                string textFile = File.ReadAllText(path);
                rtb.Selection.Text = textFile;
            }
        }

        
    }
}
