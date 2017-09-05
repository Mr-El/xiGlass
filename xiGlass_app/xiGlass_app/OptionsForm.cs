using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xiGlass_app
{
    public partial class OptionsForm: Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (controllerList.SelectedIndex < controllerList.SelectedIndex - 1)
            {
                MainWindow xboxLayout = new MainWindow();
                xboxLayout.Show();
                this.Hide();
            }
            else
            {
                PlayStationLayout playstationLayout = new PlayStationLayout();
                playstationLayout.Show();
                this.Hide();
            }
        }

        private void controllerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(((ComboBox)sender).SelectedItem as string)
            {
                case "Xbox 360/One":
                    controllerList.SelectedIndex = 0;
                    break;
                case "PlayStation 4":
                    controllerList.SelectedIndex = 1;
                    break;
            }
        }
    }
}
