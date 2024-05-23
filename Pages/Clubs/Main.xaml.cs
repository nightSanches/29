﻿using pr29savichev.Classes;
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
using System.Xml.Linq;

namespace pr29savichev.Pages.Clubs
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public ClubsContext AllClub = new ClubsContext();
        public Main()
        {
            InitializeComponent();
            foreach (Models.Clubs Club in AllClub.Clubs)
                parent.Children.Add(new Elements.Item(Club, this));
        }

        private void AddClub(object sender, RoutedEventArgs e) => MainWindow.init.OpenPages(new Pages.Clubs.Add(this));
    }
}
