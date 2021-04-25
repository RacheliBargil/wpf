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
    /// Interaction logic for instructions.xaml
    /// </summary>
    public partial class instructions : Window
    {
        public instructions()
        {
            InitializeComponent();
        }

        private void close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();

        }
    }
}
