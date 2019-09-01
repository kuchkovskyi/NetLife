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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        bool check = false;
        public Registration()
        {
            InitializeComponent();
        }

        private void btnCreateAccountClick(object sender, RoutedEventArgs e)
        { 
                if (check == false)
                {
                    CheckDataOfReg();
                }
                else
                {
                    using (EFContext context = new EFContext())
                    {
                        context.Users.Add(new User
                        {
                            Name = tbName.Text,
                            Surname = tbSurname.Text,
                            Age = tbAge.Text,
                            Gender = (rbMale.IsChecked.HasValue&&rbMale.IsChecked.Value)?"Male":"Female",
                            UserName = tbUserName.Text,
                            Password = pbPassword.Password
                        });
                    }

                    MessageBox.Show("Your profile was created successfully!");
                    LogIn log = new LogIn();
                    log.Show();
                    this.Close();
                }
        }

        public void CheckDataOfReg()
        {
            if (tbName.Text == "" || tbSurname.Text == "" || tbAge.Text == "" ||
                rbMale.IsChecked == false && rbFemale.IsChecked == false ||
                tbUserName.Text == "" || pbPassword.Password == "")
            {
                MessageBox.Show("Please fill in the empty fields!");
            }
            else
            {
                check = true;
            }
        }

        private void btnBackClick(object sender, RoutedEventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Close();
        }
    }
}
