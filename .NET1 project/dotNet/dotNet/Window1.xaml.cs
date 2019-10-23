using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace dotNet
{
    /// <summary>;
    /// Interaction logic for Window1.xaml
    /// </summary>

    public partial class Window1 : Window
    {
        Random rng = new Random();
        string path = "PlayerData.txt";
        string playerName = "";
        public Window1(string name, string choice)
        {
            InitializeComponent();
            dispName.Content = $"Hello {name}!";
            playerName = name;
            userWant.Content = $"{name}, pick a door!\nRemember you wanted {choice}...";
            List<string> mylist = new List<string>();
            mylist.Add("Sports Car");
            mylist.Add("House and lot");
            mylist.Add("Goat");
            mylist = Shuffle(mylist);
            string[] pri = mylist.ToArray();
            priceOne.Content = pri[0];
            priceTwo.Content = pri[1];
            priceThree.Content = pri[2];
            userChoice.Content = choice;
            HideChoices();
        }
        private bool door1_clicked = false;
        private bool door2_clicked = false;
        private bool door3_clicked = false;
        private bool confirm_button = false;
       
        private void doorOne_Click(object sender, RoutedEventArgs e)
        {
            if (confirmButton.IsVisible == true && confirm_button == false)
            {
                string error = "Click on confirm first!";
                Window2 x = new Window2(error);
                x.ShowDialog();
            }
            else if (door1_clicked == true)
            {
                ShowPrices();
                changeSelection.Content = $"You won a {priceOne.Content.ToString()}!";
                writePlayer(playerName, priceOne.Content.ToString());
                ShowPriceOne(changeSelection.Content.ToString());
                this.Close();
            }
            else if (door2_clicked == true || door3_clicked == true)
            {
                ShowPrices();
                changeSelection.Content = $"You won a {priceOne.Content.ToString()}!";
                writePlayer(playerName, priceOne.Content.ToString());
                ShowPriceOne(changeSelection.Content.ToString());
                this.Close();
            }
            else if (priceOne.Content.ToString() == userChoice.Content.ToString())
            {
                priceThree.Visibility = Visibility.Visible;
                ShowPriceThree("Door three has opened...");
                ShowOptions();
            }
            else
            {
                if (priceTwo.Content.ToString() == userChoice.Content.ToString())
                {
                    priceThree.Visibility = Visibility.Visible;
                    ShowPriceThree("Door three has opened...");
                }
                else
                {
                    priceTwo.Visibility = Visibility.Visible;
                    ShowPriceTwo("Door two has opened...");
                }
                ShowOptions();
            }
            door1_clicked = true;
        }
        private void doorTwo_Click(object sender, RoutedEventArgs e)
        {
            if (confirmButton.IsVisible == true && confirm_button == false)
            {
                string error = "Click on confirm first!";
                Window2 x = new Window2(error);
                x.ShowDialog();
            }
            else if (door2_clicked == true)
            {
                ShowPrices();
                changeSelection.Content = $"You won a {priceTwo.Content.ToString()}!";
                writePlayer(playerName, priceTwo.Content.ToString());
                ShowPriceTwo(changeSelection.Content.ToString());
                this.Close();
            }
            else if (door1_clicked == true || door3_clicked == true)
            {
                ShowPrices();
                changeSelection.Content = $"You won a {priceTwo.Content.ToString()}!";
                writePlayer(playerName, priceTwo.Content.ToString());
                ShowPriceTwo(changeSelection.Content.ToString());
                this.Close();
            }
            else if (priceTwo.Content.ToString() == userChoice.Content.ToString())
            {
                priceThree.Visibility = Visibility.Visible;
                ShowPriceThree("Door three has opened...");
                ShowOptions();
            }
            else
            {
                if (priceOne.Content.ToString() == userChoice.Content.ToString())
                {
                    priceThree.Visibility = Visibility.Visible;
                    ShowPriceThree("Door three has opened...");
                }
                else
                {
                    priceOne.Visibility = Visibility.Visible;
                    ShowPriceOne("Door one has opened...");
                }
                ShowOptions();
            }
            door2_clicked = true;
        }

        private void doorThree_Click(object sender, RoutedEventArgs e)
        {
            if (confirmButton.IsVisible == true && confirm_button == false)
            {
                string error = "Click on confirm first!";
                Window2 x = new Window2(error);
                x.ShowDialog();
            }
            else if (door3_clicked == true)
            {
                ShowPrices();
                changeSelection.Content = $"You won a {priceThree.Content.ToString()}!";
                writePlayer(playerName, priceThree.Content.ToString());
                ShowPriceThree(changeSelection.Content.ToString());
                this.Close();
            }
            else if (door1_clicked == true || door2_clicked == true)
            {
                ShowPrices();
                changeSelection.Content = $"You won a {priceThree.Content.ToString()}!";
                writePlayer(playerName, priceThree.Content.ToString());
                ShowPriceThree(changeSelection.Content.ToString());
                this.Close();
            }
            else if (priceThree.Content.ToString() == userChoice.Content.ToString())
            {
                priceOne.Visibility = Visibility.Visible;
                ShowPriceOne("Door one has opened...");
                ShowOptions();
            }
            else
            {
                if (priceTwo.Content.ToString() == userChoice.Content.ToString())
                {
                    priceOne.Visibility = Visibility.Visible;
                    ShowPriceOne("Door one has opened...");
                }
                else
                {
                    priceTwo.Visibility = Visibility.Visible;
                    ShowPriceTwo("Door two has opened...");
                }
                ShowOptions();
            }
            door3_clicked = true;
        }

        public static List<T> Shuffle<T> (List<T> list)
        {
            Random rnd = new Random();
            for (int i =0; i<list.Count; ++i)
            {
                int k = rnd.Next(0, i);
                T value = list[k];
                list[k] = list[i];
                list[i] = value;
            }
            return list;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (choiceYes.IsChecked == true && choiceNoo.IsChecked == true)
            {
                string error = "Choose one option only!";
                Window2 x = new Window2(error);
                x.ShowDialog();
            }
            else if (choiceYes.IsChecked == false && choiceNoo.IsChecked == false)
            {
                string error = "Choose an option!";
                Window2 x = new Window2(error);
                x.ShowDialog();
            }
            else if (choiceYes.IsChecked == true)
            {
                changeSelection.Content = "Choose another door";
                HideOptions();
                confirm_button = true;
            }
            else if (choiceNoo.IsChecked == true)
            {
                ShowPrices();
                if (door1_clicked == true)
                {
                    HideOptions();
                    changeSelection.Content = $"You won a {priceOne.Content.ToString()}!";
                    writePlayer(playerName, priceOne.Content.ToString());
                    confirm_button = true;
                    ShowPriceOne(changeSelection.Content.ToString());
                    this.Close();
                }
                else if (door2_clicked == true)
                {
                    HideOptions();
                    changeSelection.Content = $"You won a {priceTwo.Content.ToString()}!";
                    writePlayer(playerName, priceTwo.Content.ToString());
                    confirm_button = true;
                    ShowPriceTwo(changeSelection.Content.ToString());
                    this.Close();
                }
                else
                {
                    HideOptions();
                    changeSelection.Content = $"You won a {priceThree.Content.ToString()}!";
                    writePlayer(playerName, priceThree.Content.ToString());
                    confirm_button = true;
                    ShowPriceThree(changeSelection.Content.ToString());
                    this.Close();
                }
            }
            
        }

        private void ShowPrices()
        {
            priceTwo.Visibility = Visibility.Visible;
            priceOne.Visibility = Visibility.Visible;
            priceThree.Visibility = Visibility.Visible;
        }

        private void HideOptions()
        {
            choiceYes.Visibility = Visibility.Hidden;
            choiceNoo.Visibility = Visibility.Hidden;
            confirmButton.Visibility = Visibility.Hidden;
        }

        private void ShowOptions()
        {
            changeSelection.Visibility = Visibility.Visible;
            choiceYes.Visibility = Visibility.Visible;
            choiceNoo.Visibility = Visibility.Visible;
            confirmButton.Visibility = Visibility.Visible;
        }
        public void HideChoices()
        {
            priceOne.Visibility = Visibility.Hidden;
            priceTwo.Visibility = Visibility.Hidden;
            priceThree.Visibility = Visibility.Hidden;
            userChoice.Visibility = Visibility.Hidden;
            changeSelection.Visibility = Visibility.Hidden;
            choiceYes.Visibility = Visibility.Hidden;
            choiceNoo.Visibility = Visibility.Hidden;
            confirmButton.Visibility = Visibility.Hidden;
        }

        private void ShowPriceOne(string message)
        {
            if (priceOne.Content.ToString() == "Sports Car")
            {
                Car x = new Car(message);
                x.ShowDialog();
            }
            else if (priceOne.Content.ToString() == "Goat")
            {
                Window3 x = new Window3(message);
                x.ShowDialog();
            }
            else
            {
                House x = new House(message);
                x.ShowDialog();
            }
        }

        private void ShowPriceTwo(string message)
        {
            if (priceTwo.Content.ToString() == "Sports Car")
            {
                Car x = new Car(message);
                x.ShowDialog();
            }
            else if (priceTwo.Content.ToString() == "Goat")
            {
                Window3 x = new Window3(message);
                x.ShowDialog();
            }
            else
            {
                House x = new House(message);
                x.ShowDialog();
            }
        }

        private void ShowPriceThree(string message)
        {
            if (priceThree.Content.ToString() == "Sports Car")
            {
                Car x = new Car(message);
                x.ShowDialog();
            }
            else if (priceThree.Content.ToString() == "Goat")
            {
                Window3 x = new Window3(message);
                x.ShowDialog();
            }
            else
            {
                House x = new House(message);
                x.ShowDialog();
            }
        }

        void writePlayer(string name, string prize) {
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine($"{name} won a {prize}");
                }

            }
            else if (File.Exists(path))
            {
                using (TextWriter tw = new StreamWriter(path,true))
                {
                    tw.WriteLine($"{name} won a {prize}");
                }
            }
        }
    }

   

}
