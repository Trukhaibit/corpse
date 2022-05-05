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

namespace corpse
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

        private void hideShow1(object sender, RoutedEventArgs e)
        {
            if (canvas1.Visibility == Visibility.Visible)
            {
                canvas1.Visibility = Visibility.Hidden;
            }
            else
            {
                canvas1.Visibility = Visibility.Visible;
            }
        }

        private void hideShow2(object sender, RoutedEventArgs e)
        {
            if (canvas2.Visibility == Visibility.Visible)
            {
                canvas2.Visibility = Visibility.Hidden;
            }
            else
            {
                canvas2.Visibility = Visibility.Visible;
            }
        }

        private void hideShow3(object sender, RoutedEventArgs e)
        {
            if (canvas3.Visibility == Visibility.Visible)
            {
                canvas3.Visibility = Visibility.Hidden;
            }
            else
            {
                canvas3.Visibility = Visibility.Visible;
            }
        }

        private void clearOne(object sender, RoutedEventArgs e)
        {
            canvas1.Strokes.Clear();
        }

        private void clearTwo(object sender, RoutedEventArgs e)
        {
            canvas2.Strokes.Clear();
        }

        private void clearThree(object sender, RoutedEventArgs e)
        {
            canvas3.Strokes.Clear();
        }
    }
}
