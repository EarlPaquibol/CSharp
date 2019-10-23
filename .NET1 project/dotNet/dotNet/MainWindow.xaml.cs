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

namespace dotNet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string nameF = "";
        string file = "PlayerData.txt";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string userChoice;
            if (conName.Text == "")
            {
                string error = "Please enter a name!";
                Window2 x = new Window2(error);
                x.ShowDialog();
            }
            else if (CheckMultiple() == true)
            {
                string error = "Choose one prize only!";
                Window2 x = new Window2(error);
                x.ShowDialog();
            }
            else if (car.IsChecked == false && cash.IsChecked == false && house.IsChecked == false)
            {
                string error = "Choose a prize!";
                Window2 x = new Window2(error);
                x.ShowDialog();
            }
            else
            {
                userChoice = SetChosenPrize();
                Window1 open = new Window1(conName.Text, userChoice);
                open.ShowDialog();
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        public bool CheckMultiple()
        {
            bool multiple = false;
            if (car.IsChecked == true && house.IsChecked == true)
            {
                multiple = true;
            }
            else if (car.IsChecked == true && cash.IsChecked == true)
            {
                multiple = true;
            }
            else if (house.IsChecked == true && cash.IsChecked == true)
            {
                multiple = true;
            }
            return multiple;
        }

        public string SetChosenPrize()
        {
            string userChoice;
            if (car.IsChecked == true)
            {
                userChoice = car.Content.ToString();
                return userChoice;
            }
            else if (house.IsChecked == true)
            {
                userChoice = house.Content.ToString();
                return userChoice;
            }
            else
            {
                userChoice = cash.Content.ToString();
                return userChoice;
            }

        }

        private void played_Click(object sender, RoutedEventArgs e)
        {
            viewPlayers vWindow = new viewPlayers();
            vWindow.ShowDialog();

        }
    }
}
