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
using System.Windows.Shapes;

namespace _27._11._20_Zoo
{
    public partial class AviaryWindow : Window
    {
        public AviaryWindow()
        {
            InitializeComponent();
        }

        private void ListBoxItem_MouseDoubleClick_BuyAnimals(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            BuyAnimalsWindow animalsWindow = new BuyAnimalsWindow();
            animalsWindow.ShowDialog();
           
        }
    }
}
