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
using System.Data.SqlClient;

namespace MainScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection cn = new SqlConnection(Singleton.connectionStringGlobal);
        SqlCommand cmd;
        SqlDataReader dr;

        public MainWindow()
        {
            InitializeComponent();
            
        }


        // Form move
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


        // Exit Button
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        // Minimize Button
        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;  // minimize
        }



        // Glow Effect for continue button
        private void glassEffectLayer_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glowContinueButton.Opacity = .80;
        }

        private void glassEffectLayer_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glowContinueButton.Opacity = 0;
        }

        private void continueLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glowContinueButton.Opacity = 0.80;
        }

        private void continueLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glowContinueButton.Opacity = 0;
        }


        // Glow Effect for New Life Button
        private void glassEffectLayerForNewLife_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glowNewLifeButton.Opacity = 0.80;
        }

        private void glassEffectLayerForNewLife_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glowNewLifeButton.Opacity = 0;
        }

        private void newLifeLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glowNewLifeButton.Opacity = 0.80;
        }

        private void newLifeLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glowNewLifeButton.Opacity = 0;
        }

        // Glow Effect for Load Life Button*////////////////////////////////////////////////
        private void glassEffectLayerForLoadLife_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glowLoadLifeButton.Opacity = 0.80;
        }

        private void glassEffectLayerForLoadLife_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glowLoadLifeButton.Opacity = 0;
        }

        private void loadLifeLable_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glowLoadLifeButton.Opacity = 0.80;
        }

        private void loadLifeLable_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glowLoadLifeButton.Opacity = 0;
        }


        // Glow Effect for Exit Button*////////////////////////////////////////////////
        private void glassEffectLayerForExit_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glowExitButton.Opacity = 0.80;
        }

        private void glassEffectLayerForExit_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glowExitButton.Opacity = 0;
        }

        private void exitLable_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glowExitButton.Opacity = 0.80;
        }

        private void exitLable_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glowExitButton.Opacity = 0;
        }


        // Exit Button *//////////////////////////////////////
        private void glassEffectLayerForExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void exitLable_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }




        // Open CreateCharacterForm
        private void newLifeLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {

            CreateCharacterForm openCharacterForm = new CreateCharacterForm();
            this.Visibility = Visibility.Hidden;
            openCharacterForm.Show();
            
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Map openMapForm = new Map();
            openMapForm.Show();
            this.Close();
            
        }

        private void continueLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ViewManager form = new ViewManager();
            this.Close();
            form.Show();
        }

        private void loadLifeLable_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Load form = new Load();
            this.Close();
            form.Show();
        }






  

    }
}
