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

namespace lesson1205
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Car car;
        CarButton car1;
        public MainWindow()
        {
            InitializeComponent();
            car = new Car("hello", 100);
            txtBlock.DataContext = car;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            car.Speed += 10;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            car.Speed -= 10;
        }
    }
}
