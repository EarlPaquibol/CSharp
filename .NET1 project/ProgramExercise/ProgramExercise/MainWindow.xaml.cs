using System;
using System.Windows;
using System.Windows.Controls;


namespace ProgramExercise
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

        double oneRoom = 450;
        double twoRoom = 550;
        double threeRoom = 700;
        double addBathroom = 75;
        double addLakeview = 50;

        private void numBathroom_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numBathroom.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                numBathroom.Text = numBathroom.Text.Remove(numBathroom.Text.Length - 1);
            }

        }

        private void numRoom_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numRoom.Text, "[^1-3]"))
            {
                MessageBox.Show("Please enter a number from 1 to 3 only");
                numRoom.Text = numRoom.Text.Remove(numRoom.Text.Length - 1);
            }

        }

        private void bookButton_Click(object sender, RoutedEventArgs e)
        {
            int room = 0;
            int bathroom = 0;
            if (numRoom.Text == "")
            {
                MessageBox.Show("Please enter number of rooms.");
            }
            else
            {
                room = Convert.ToInt32(numRoom.Text);
            }
            if (numBathroom.Text == "")
            {
                MessageBox.Show("Please enter number of bathrooms.");
            }
            else
            {
                bathroom = Convert.ToInt32(numBathroom.Text);
            }
            if (lakeView.IsChecked == true)
            {
                CalcPrice(room, bathroom, lakeView.Content.ToString());
            }
            else if (viewStreet.IsChecked == true)
            {
                CalcPrice(room, bathroom, viewStreet.Content.ToString());
            }
            else
            {
                MessageBox.Show("Please choose a view");
            }
        }

        private void CalcPrice(int room,int bathroom, string view)
        {
            double total = 0;
            if (room == 1)
            {
                if (bathroom > 1)
                {
                    if (view == "Lake view")
                    {
                        total = oneRoom + ((bathroom-1) * addBathroom) + addLakeview;
                        price.Content = $"Total price is {total.ToString("C")}";
                    }
                    else
                    {
                        total = oneRoom + ((bathroom-1) * addBathroom);
                        price.Content = $"Total price is {total.ToString("C")}";
                    }
                }
                else
                {
                    if(view == "Lake view")
                    {
                        total = oneRoom +  addLakeview;
                        price.Content = $"Total price is {total.ToString("C")}";
                    }
                    else
                    {
                        total = oneRoom;
                        price.Content = $"Total price is {total.ToString("C")}";
                    }
                }
            }
            else if (room == 2)
            {
                if (bathroom > 1)
                {
                    if (view == "Lake view")
                    {
                        total = twoRoom + ((bathroom - 1) * addBathroom) + addLakeview;
                        price.Content = $"Total price is {total.ToString("C")}";
                    }
                    else
                    {
                        total = twoRoom + ((bathroom - 1) * addBathroom);
                        price.Content = $"Total price is {total.ToString("C")}";
                    }
                }
                else
                {
                    if (view == "Lake view")
                    {
                        total = twoRoom + addLakeview;
                        price.Content = $"Total price is {total.ToString("C")}";
                    }
                    else
                    {
                        total = twoRoom;
                        price.Content = $"Total price is {total.ToString("C")}";
                    }
                }
            }
            else
            {
                if (bathroom > 1)
                {
                    if (view == "Lake view")
                    {
                        total = threeRoom + ((bathroom - 1) * addBathroom) + addLakeview;
                        price.Content = $"Total price is {total.ToString("C")}";
                    }
                    else
                    {
                        total = threeRoom + ((bathroom - 1) * addBathroom);
                        price.Content = $"Total price is {total.ToString("C")}";
                    }
                }
                else
                {
                    if (view == "Lake view")
                    {
                        total = threeRoom + addLakeview;
                        price.Content = $"Total price is {total.ToString("C")}";
                    }
                    else
                    {
                        total = threeRoom;
                        price.Content = $"Total price is {total.ToString("C")}";
                    }
                }
            }
        }
    }
}
