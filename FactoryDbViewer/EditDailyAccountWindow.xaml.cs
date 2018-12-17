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
using FactoryDbViewer.Tables;

namespace FactoryDbViewer
{
    /// <summary>
    /// Логика взаимодействия для EditDailyAccountWindow.xaml
    /// </summary>
    public partial class EditDailyAccountWindow : Window
    {
        public EditDailyAccountWindow(DailyAccount dailyAccount)
        {
            InitializeComponent();

            DataContext = dailyAccount;
        }

        private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
