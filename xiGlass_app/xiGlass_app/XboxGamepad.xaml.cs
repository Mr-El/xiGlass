using System;
using System.Windows;
using System.Windows.Controls.Ribbon;
using System.Drawing;
using System.Windows.Forms;

namespace xiGlass_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal Uri Source;

        NotifyIcon nIcon = new NotifyIcon();
        public MainWindow()
        {
            nIcon.Icon = new Icon(@"C:\Users\Mr_El\Pictures\xiGlass_ico.ico");
            nIcon.Visible = true;
            nIcon.ShowBalloonTip(5000, "xiGlass", "Your controller is currently running", System.Windows.Forms.ToolTipIcon.Info);
            InitializeComponent();
        }
    }
}
