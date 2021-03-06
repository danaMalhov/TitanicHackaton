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

namespace TitanicSurvivalProbability
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SimpleGUI Simple { get; set; }
        public ComplexGUI Complex { get; set; }

        public MainWindow()
        {
            Simple = new SimpleGUI();
            Complex = new ComplexGUI();        

            InitializeComponent();
        }
    }
}
