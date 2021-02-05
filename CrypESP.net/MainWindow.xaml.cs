using CrypESP.net.Controls;
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

namespace CrypESP.net
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ControlsLib.EE = PanelERRORS;
        }


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();


        }

        private void border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MouseClickPassword(object sender, MouseButtonEventArgs e)
        {
            switch (PanelPass.Visibility)
            {
                case Visibility.Visible:
                    PanelPass.Visibility = Visibility.Hidden;
                    BorderGridColumn1.Opacity = 0.8;
                    break;
                case Visibility.Hidden:
                    PanelPass.Visibility = Visibility.Visible;
                    PanelERRORS.Visibility = Visibility.Hidden;
                    BorderGridColumn1.Opacity = 1;
                    break;
                case Visibility.Collapsed:
                    break;
                default:
                    break;
            }
        }

        private void MouseClickErrors(object sender, MouseButtonEventArgs e)
        {
            switch (PanelERRORS.Visibility)
            {
                case Visibility.Visible:
                    PanelERRORS.Visibility = Visibility.Hidden;
                    
                    BorderGridColumn1.Opacity = 0.8;
                    break;
                case Visibility.Hidden:
                    PanelERRORS.Visibility = Visibility.Visible;
                    PanelPass.Visibility = Visibility.Hidden;
                    BorderGridColumn1.Opacity = 1;
                    break;
                case Visibility.Collapsed:
                    break;
                default:
                    break;
            }
        }
    }
}
