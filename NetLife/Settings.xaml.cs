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
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnProfileClick(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }

        private void btnNewsClick(object sender, RoutedEventArgs e)
        {
            News news = new News();
            news.Show();
            this.Close();
        }
        private void btnSettingsClick(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }

        private void btnPowerClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogoutClick(object sender, RoutedEventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Close();
        }

        private void btnFAQClick(object sender, RoutedEventArgs e)
        {
            FAQ faq = new FAQ();
            faq.Show();
            this.Close();
        }

        private void MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnDeleteProfileClick(object sender, RoutedEventArgs e)
        {
            DeleteProfile deleteProfile = new DeleteProfile();
            deleteProfile.Show();
            this.Close();
        }

        private void btnEditUserNameClick(object sender, RoutedEventArgs e)
        {
            EditUserName editUserName = new EditUserName();
            editUserName.Show();
            this.Close();
        }

        private void btnEditPasswordClick(object sender, RoutedEventArgs e)
        {
            EditPassword editPassword = new EditPassword();
            editPassword.Show();
            this.Close();
        }
    }
}
