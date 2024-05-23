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

namespace pr29savichev.Pages.Users
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public UserContext AllUsers = new UserContext();
        public Main()
        {
            InitializeComponent();
            foreach (Models.Users User in AllUsers.Users)
                parent.Children.Add(new Elements.Item(User, this));
        }

        private void AddUser(object sender, RoutedEventArgs e) => MainWindow.init.OpenPages(new Pages.Users.Add(this));
    }
}
