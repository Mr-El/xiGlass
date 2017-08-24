using System;
using System.Windows;
using System.Windows.Forms;

namespace xiGlass_app
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OptionsWindow : Window
    {
        
        public OptionsWindow()
        {
            InitializeComponent();
        }

        public void startGamepad_Click (object sender, RoutedEventArgs e)
        {
            
        }
        public Uri Source { get; set; }
        private void startGamePad_Click_1(object sender, RoutedEventArgs e)
        {
            selectController.SelectedIndex = 0;
            if(selectController.SelectedIndex == 0)
            {
                MainWindow xboxLayout = new MainWindow();
                xboxLayout.Show();
                this.Hide();
            }
            if(selectController.SelectedIndex == 1)
            {
                MainWindow playstationLayout = new MainWindow();
                playstationLayout.Show();
                this.Hide();
            }
            
        }

        private void selectController_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
