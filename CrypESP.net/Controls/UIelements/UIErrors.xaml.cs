﻿using System;
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

namespace CrypESP.net.Controls.UIelements
{
    /// <summary>
    /// Логика взаимодействия для UIErrors.xaml
    /// </summary>
    public partial class UIErrors : UserControl
    {
        public UIErrors()
        {
            InitializeComponent();
        }
        public void adderrors(string error)
        {
            Label l = new Label();
            l.setText(error);
            // HorizontalAlignment="Left" HorizontalContentAlignment="Center"
            l.HorizontalAlignment = HorizontalAlignment.Left;
            l.HorizontalContentAlignment = HorizontalAlignment.Center;

            StackPanel_ScrollViewer.Children.Add(l);
        }
    }
}
