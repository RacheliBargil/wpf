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
    /// Interaction logic for massageinfo.xaml
    /// </summary>
    public partial class massageinfo : Window
    {
        public massageinfo(string type)
        {
            InitializeComponent();
            typeimage(type);

        }
        public void typeimage(string type)
        {
            ImageBrush s = new ImageBrush();
            switch (type)
            {
                case "mg":
                    {

                        s.ImageSource = new BitmapImage(new Uri(@"../../IMG1/mginfo.png ", UriKind.Relative));
                        grid.Background = s;
                        break;
                    }
                case "hmechaber":
                    {
                        s.ImageSource = new BitmapImage(new Uri(@"../../IMG1/hmhbrinfo.png ", UriKind.Relative));
                        grid.Background = s;
                        break;
                    }
                case "mechaber":
                    {
                        s.ImageSource = new BitmapImage(new Uri(@"../../IMG1/mhbrinfo.png ", UriKind.Relative));
                        grid.Background = s;
                        break;
                    }

                case "merabev":
                    {
                        s.ImageSource = new BitmapImage(new Uri(@"../../IMG1/infomrbv.png ", UriKind.Relative));
                        grid.Background = s;
                        break;
                    }
                case "mefaaneah":
                    {
                        s.ImageSource = new BitmapImage(new Uri(@"../../IMG1/mfninfo.png ", UriKind.Relative));
                        grid.Background = s;
                        break;
                    }
                case "mkdd":
                    {
                        s.ImageSource = new BitmapImage(new Uri(@"../../IMG1/mkddinfo.png ", UriKind.Relative));
                        grid.Background = s;
                        break;
                    }
            }
        }

        private void close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
