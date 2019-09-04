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
    /// Логика взаимодействия для News.xaml
    /// </summary>
    public partial class News : Window
    {
        EFContext context = new EFContext();
        List<Model> models = new List<Model>();
        public News()
        {
            InitializeComponent();

            foreach (var el in context.News)
            {
                Model model = new Model()
                {
                    Title = el.Title,
                    Description = el.Description
                };
                models.Add(model);
            }
            dgNews.ItemsSource = models;
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

        private void btnAddNewClick(object sender, RoutedEventArgs e)
        {
            CreateNew createNew = new CreateNew();
            createNew.Show();
            this.Close();
        }

        private void btnDeleteNewClick(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var el in models)
                {
                    models.Remove(el);
                    dgNews.Items.Remove(el.Description);
                }
            }
            catch (Exception) { }
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
    }
}
