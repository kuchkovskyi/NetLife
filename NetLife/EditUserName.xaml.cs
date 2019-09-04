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
    /// Логика взаимодействия для EditUserName.xaml
    /// </summary>
    public partial class EditUserName : Window
    {
        EFContext context = new EFContext();
        int userId = UserHelper.Id;

        public EditUserName()
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
            tbUN.Clear();
            tbNewUN.Clear();
        }

        private void btnEditClick(object sender, RoutedEventArgs e)
        {
            if(tbNewUN.Text=="" || tbUN.Text == "")
            {
                MessageBox.Show("Please fill in the empty fields!");
            }
            else
            {
                foreach(var el in context.Users)
                {
                    if(tbUN.Text != el.UserName)
                    {
                        MessageBox.Show("Your username is incorrect!");
                        tbUN.Clear();
                        break;
                    }

                    else if(el.Id == userId)
                    { 
                        el.UserName.Insert(userId, tbNewUN.Text);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
