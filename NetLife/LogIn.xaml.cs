﻿using NetLife.Entities;
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
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnEntranceClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbUserName.Text == "" || pbPassword.Password == "")
                {
                    MessageBox.Show("Please fill in the empty fields!");
                }
                else
                {
                    EFContext context = new EFContext();
                    List<User> users = context.Users.ToList();
                    bool IsFinded = false;
                    foreach (var el in users)
                    {
                        if (el.UserName == tbUserName.Text && el.Password == pbPassword.Password)
                        {
                            IsFinded = true;
                            UserHelper.Id = el.Id;  
                            Main main = new Main();
                            main.Show();
                            this.Close();
                            break;
                        }
                    }
                    if (!IsFinded)
                    {
                        MessageBox.Show("Enter your data again!");
                        tbUserName.Clear();
                        pbPassword.Clear();
                    }
                    
                }
            }
            catch (Exception) { }
        }

        private void btnCreateAccountClick(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }
    }
}
