using NetLife.Entities;
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
using System.Windows.Shapes;

namespace NetLife
{
    /// <summary>
    /// Логика взаимодействия для DeleteProfile.xaml
    /// </summary>
    public partial class DeleteProfile : Window
    {
        EFContext context = new EFContext();
        public DeleteProfile()
        {
            InitializeComponent();
        }

        private void btnYesClick(object sender, RoutedEventArgs e)
        {
            int userId = UserHelper.Id;
            foreach (var el in context.Users)
            {
                if (el.Id == userId)
                {
                    context.Users.Remove(el);
                    //context.SaveChanges();
                    LogIn logIn = new LogIn();
                    logIn.Show();
                    this.Close();
                }
            }
        }

        private void btnNoClick(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }
    }
}
