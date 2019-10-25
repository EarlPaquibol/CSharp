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

namespace BreezyViewApartments
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            dispPrice.Content = "";
            Apartment ey = new Apartment();
            if (numRooms.SelectedIndex == 0)
            {
                ey.Room = 1;
            }
            else if (numRooms.SelectedIndex == 1)
            {
                ey.Room = 2;
            }
            else
            {
                ey.Room = 3;
            }
            if (checkYes.IsChecked == true)
            {
                ey.Bath = 1;
            }
            if (selectView.SelectedIndex == 0)
            {
                ey.View = 0;
            }
            else
            {
                ey.View = 1;
            }
            if(numRooms.SelectedIndex == -1 || checkYes.IsChecked == false && checkNo.IsChecked == false || selectView.SelectedIndex == -1)
            {
                dispPrice.Content = "ERROR! \nIncomplete inputs!";
            }
            else if (checkYes.IsChecked == true && checkNo.IsChecked == true)
            {
                dispPrice.Content = "ERROR! \nPlease check yes or no only!";
            }
            else
            {
                dispPrice.Content = $"Total price is: {ey.Price.ToString("C")}";
            }
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void numRooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    class Apartment
    {
        private int room;
        private int bath;
        private int view;
        private double price;
        public int Room
        {
            get
            {
                return room;
            }
            set
            {
                room = value;
            }
        }
        public int Bath
        {
            get
            {
                return bath;
            }
            set
            {
                bath = value;
            }
        }
        public int View
        {
            get
            {
                return view;
            }
            set
            {
                view = value;
                CalcPrice();
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
        }

        private double CalcPrice()
        {
            if (room == 1)
            {
                if(bath == 1)
                {
                    if (view == 0)
                    {
                        price = 450 + 75;
                    }
                    else
                    {
                        price = 450 + 75 + 50;
                    }
                }
                else
                {
                    if (view == 0)
                    {
                        price = 450;
                    }
                    else
                    {
                        price = 450 + 50;
                    }

                }
            }
            else if(room == 2)
            {
                if (bath == 1)
                {
                    if (view == 0)
                    {
                        price = 550 + 75;
                    }
                    else
                    {
                        price = 550 + 75 + 50;
                    }
                }
                else
                {
                    if (view == 0)
                    {
                        price = 550;
                    }
                    else
                    {
                        price = 550 + 50;
                    }

                }
            }
            else
            {
                if (bath == 1)
                {
                    if (view == 0)
                    {
                        price = 700 + 75;
                    }
                    else
                    {
                        price = 700 + 75 + 50;
                    }
                }
                else
                {
                    if (view == 0)
                    {
                        price = 700;
                    }
                    else
                    {
                        price = 700 + 50;
                    }

                }

            }
            return price;
        }
    }
}
