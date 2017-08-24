using System;
using System.Windows;

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
            MainWindow changeWindow = new MainWindow();
            changeWindow.Show();
            this.Hide();
        }
    }
}
