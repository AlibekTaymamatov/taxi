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
using WpfTaxi.Viwe_Model;
using WpfTaxi.Model;

namespace WpfTaxi.Viwe
{
    /// <summary>
    /// Логика взаимодействия для PageAddDrivers.xaml
    /// </summary>
    public partial class PageAddDrivers : Page
    {
        public PageAddDrivers(Model1 bd, windowcs win)
        {
            InitializeComponent();
            DataContext = new AddDrivers(bd, win);
        }
    }
}
