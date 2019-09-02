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
        public DeleteProfile()
        {
            InitializeComponent();
        }

        private void btnYesClick(object sender, RoutedEventArgs e)
        {

        }

        private void btnNoClick(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }
    }
}
