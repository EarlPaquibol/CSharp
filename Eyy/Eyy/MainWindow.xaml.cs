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

namespace Eyy
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
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2, sum;
            num1 = Convert.ToInt32(InputBox.Text);
            num2 = Convert.ToInt32(OutputBox.Text);
            sum = num1 + num2;
            AnswerBox.Content = "Sum is " + sum;


        }

        private void Input(object sender, TextChangedEventArgs e)
        {

        }

        private void Output(object sender, TextChangedEventArgs e)
        {

        }

        private void Add(object sender, RoutedEventArgs e)
        {

        }
    }
}
