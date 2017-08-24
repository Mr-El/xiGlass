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
using System.Windows.Navigation;
using System.Windows.Shapes;
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
