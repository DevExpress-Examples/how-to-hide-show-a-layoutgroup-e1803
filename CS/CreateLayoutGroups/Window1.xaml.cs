﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CreateLayoutGroups {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            RootGroup.Items.Remove(LayoutGroup3);
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            RootGroup.Items.Add(LayoutGroup3);
        }
    }
}
