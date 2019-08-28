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
using System.Windows.Shapes;

namespace NetLife
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        bool check = false;
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnEntranceClick(object sender, RoutedEventArgs e)
        {
            if (check == false)
            {
                CheckDataOfLogIn();
            }
            else
            {
                Main main = new Main();
                main.Show();
                this.Close();
            }
        }

        public void CheckDataOfLogIn()
        {
            if(tbUserName.Text == "" || pbPassword.Password == "")
            {
                MessageBox.Show("Please fill in the empty fields!");
            }
            else { check = true; }
        }

        private void btnCreateAccountClick(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }
    }
}
