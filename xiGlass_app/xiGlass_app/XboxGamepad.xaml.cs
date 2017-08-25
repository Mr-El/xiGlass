using System;
using System.Windows;
using System.Windows.Controls.Ribbon;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Linq;

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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            OptionsForm exitOut = new OptionsForm();
            exitOut.Show();
            this.Hide();
        }

        public class CanvasAutoSize : Canvas
        {
            protected override System.Windows.Size MeasureOverride(System.Windows.Size constraint)
            {
                base.MeasureOverride(constraint);
                double width = base
                    .InternalChildren
                    .OfType<UIElement>()
                    .Max(i => i.DesiredSize.Width + (double)i.GetValue(Canvas.LeftProperty));

                double height = base
                    .InternalChildren
                    .OfType<UIElement>()
                    .Max(i => i.DesiredSize.Height + (double)i.GetValue(Canvas.TopProperty));

                return new System.Windows.Size(width, height);
            }
        }
    }
}
