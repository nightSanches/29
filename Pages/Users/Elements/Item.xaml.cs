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

namespace pr29savichev.Pages.Users.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public ClubContext AllClub = new ClubContext();
        Main Main;
        Models.Users User;
        public Item(Models.Users User, Main Main)
        {
            InitializeComponent();
            this.RentStart.Text = User.RentStart.ToString("yyyy-MM-dd");
            this.RentTime.Text = User.RentStart.ToString("HH:mm");
            this.Duration.Text = User.Duration.ToString();
            this.IdClub.Text = AllClub.Clubs.Where(x => x.Id == User.IdClub).First().Name;
            this.FIO.Text = User.FIO;
            this.Main = Main;
            this.User = User;
        }

        private void EditUser(object sender, RoutedEventArgs e) => MainWindow.init.OpenPages(new Pages.Users.Add(this.Main, this.User));

        private void DeleteUser(object sender, RoutedEventArgs e)
        {
            Main.AllUsers.Users.Remove(User);
            Main.AllUsers.SaveChanges();
            Main.parent.Children.Remove(this);
        }
    }
}
