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
    /// Логика взаимодействия для CreateNew.xaml
    /// </summary>
    public partial class CreateNew : Window
    {
        bool check = false;

        public CreateNew()
        {
            InitializeComponent();
        }

        private void btnBackClick(object sender, RoutedEventArgs e)
        {
            News news = new News();
            news.Show();
            this.Close();
        }

        private void btnLoadClick(object sender, RoutedEventArgs e)
        {
            if(tbTitle.Text == "" || tbDescription.Text == "")
            {
                MessageBox.Show("Please fill in the empty fields!");
            }
            else
            {
                using (EFContext context = new EFContext())
                {
                    int Id = UserHelper.Id;
                    context.News.Add(new New
                    {
                        Title = tbTitle.Text,
                        Description = tbDescription.Text,
                        IdUser = Id
                    });
                    context.SaveChanges();
                }

                MessageBox.Show("Your news created and added succesfull!");
                News news = new News();
                news.Show();
                this.Close();
            }
        }

        private void btnClearClick(object sender, RoutedEventArgs e)
        {
            tbTitle.Clear();
            tbDescription.Clear();
        }
    }
}
