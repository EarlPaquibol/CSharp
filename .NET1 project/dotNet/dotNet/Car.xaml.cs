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
using System.Media;

namespace dotNet
{
    /// <summary>
    /// Interaction logic for Car.xaml
    /// </summary>
    public partial class Car : Window
    {
        SoundPlayer sp = new SoundPlayer();
        public Car(string content)
        {
            InitializeComponent();
            labelMessage.Content = content;
            sp.SoundLocation = "bmwsound.wav";
            sp.Play();
        }
    }
}
