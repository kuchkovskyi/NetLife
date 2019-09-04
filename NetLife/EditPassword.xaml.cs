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
    /// Логика взаимодействия для EditPassword.xaml
    /// </summary>
    public partial class EditPassword : Window
    {
        EFContext context = new EFContext();
        int userId = UserHelper.Id;

        public EditPassword()
        {
            InitializeComponent();
        }

        private void btnBackClick(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }

        private void btnClearClick(object sender, RoutedEventArgs e)
        {
            tbP.Clear();
            tbNewP.Clear();
        }

        private void btnEditClick(object sender, RoutedEventArgs e)
        {
            if (tbP.Text == "" || tbNewP.Text == "")
            {
                MessageBox.Show("Please fill in the empty fields!");
            }
            else
            {
                foreach (var el in context.Users)
                {
                    if (tbP.Text != el.Password)
                    {
                        MessageBox.Show("Your password is incorrect!");
                        tbP.Clear();
                        break;
                    }

                    else if (el.Id == userId)
                    {
                        el.UserName.Insert(userId, tbNewP.Text);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
