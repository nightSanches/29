using pr29savichev.Classes;
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

namespace pr29savichev.Pages.Users
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        public ClubContext AllClub = new ClubContext();
        public Models.Users User;
        public Main Main;
        public Add(Main Main, Models.Users User = null)
        {
            InitializeComponent();
            this.Main = Main;
            foreach (Models.Clubs Club in AllClub.Clubs)
                IdClub.Items.Add(Club.Name);
            IdClub.Items.Add("Выберете...");
            if (User != null)
            {
                this.User = User;
                this.RentStart.Text = User.RentStart.ToString("yyyy-MM-dd");
                this.RentTime.Text = User.RentStart.ToString("HH:mm");
                this.Duration.Text = User.Duration.ToString();
                IdClub.SelectedItem = AllClub.Clubs.Where(x => x.Id == User.IdClub).First().Name;
                this.FIO.Text = User.FIO;
                BthAdd.Content = "Изменить";
            }
        }

        private void AddUser(object sender, RoutedEventArgs e)
        {
            DateTime DTRentStart = new DateTime();
            DateTime.TryParse(this.RentStart.Text, out DTRentStart);
            DTRentStart = DTRentStart.Add(TimeSpan.Parse(this.RentTime.Text));
            if (this.User == null)
            {
                User = new Models.Users();
                User.RentStart = DTRentStart;
                User.Duration = Convert.ToInt32(this.Duration.Text);
                User.IdClub = AllClub.Clubs.Where(x => x.Name == IdClub.SelectedItem.ToString()).First().Id;
                User.FIO = this.FIO.Text;
                this.Main.AllUsers.Users.Add(this.User);
            }
            else
            {
                User.RentStart = DTRentStart;
                User.Duration = Convert.ToInt32(this.Duration.Text);
                User.IdClub = AllClub.Clubs.Where(x => x.Name == IdClub.SelectedItem.ToString()).First().Id;
                User.FIO = this.FIO.Text;
            }
            this.Main.AllUsers.SaveChanges();
            MainWindow.init.OpenPages(new Pages.Users.Main());
        }
    }
}
