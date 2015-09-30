using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MainScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        DispatcherTimer f = new DispatcherTimer();
     
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
        
                f.Interval = new TimeSpan(0, 0, 5);
                f.Start();

                f.Tick += timerfunc;
            
        }
        public void timerfunc(object sender, object e)
        {
            closeSplashScreen();          
        }

        private void rectangle1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            closeSplashScreen();
        }

        public void closeSplashScreen()
        {
            MainWindow Mainscreen = new MainWindow();
            Mainscreen.Show();
            this.Close();
            f.Stop();
            f.Equals(null);
         }
    }
}
