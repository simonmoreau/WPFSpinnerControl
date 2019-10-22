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

namespace WPFSpinnerControl.Chip
{
    /// <summary>
    /// Interaction logic for ChipView.xaml
    /// </summary>
    public partial class ChipView : UserControl
    {
        public ChipView()
        {
            InitializeComponent();
            ChipViewModel chipViewModel = new ChipViewModel();
            this.DataContext = chipViewModel;
        }
    }
}
