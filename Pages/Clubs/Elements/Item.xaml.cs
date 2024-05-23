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

namespace pr29savichev.Pages.Clubs.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        Main Main;
        Models.Clubs Club;
        public Item(Models.Clubs Club, Main Main)
        {
            InitializeComponent();
            this.Name.Text = Club.Name;
            this.Address.Text = Club.Address;
            this.WorkTime.Text = Club.WorkTime;
            this.Main = Main;
            this.Club = Club;
        }

        private void EditClub(object sender, RoutedEventArgs e) => MainWindow.init.OpenPages(new Pages.Clubs.Add(this.Main, this.Club));

        private void DeleteClub(object sender, RoutedEventArgs e)
        {
            Main.AllClub.Clubs.Remove(Club);
            Main.AllClub.SaveChanges();
            Main.parent.Children.Remove(this);
        }
    }
}
