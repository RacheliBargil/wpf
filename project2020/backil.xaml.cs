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

namespace project2020
{
    /// <summary>
    /// Interaction logic for backil.xaml
    /// </summary>
    public partial class backil : Window
    {
        public backil()
        {
            InitializeComponent();
        }

        private void close_cc(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
