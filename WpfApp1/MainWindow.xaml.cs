﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Xps.Packaging;
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ButtonMy_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("авыаыв");
        }

        private void ButtonBestMy_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("dsdf");
        }
    }
}
