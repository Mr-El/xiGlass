using System;
using System.Windows;
using System.Windows.Controls.Ribbon;
using System.Drawing;
//using System.Windows.Forms;
using System.Windows.Controls;
using System.Linq;
//using SlimDX.DirectInput;

namespace xiGlass_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class XboxLayout : Window
    {
        internal Uri Source;

        //NotifyIcon nIcon = new NotifyIcon();
        public XboxLayout()
        {
            //nIcon.Icon = new Icon(@"Images\xiGlass_ico.ico");
            //nIcon.Visible = true;
            //nIcon.ShowBalloonTip(5000, "xiGlass", "Your controller is currently running", System.Windows.Forms.ToolTipIcon.Info);
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            OptionsForm exitOut = new OptionsForm();
            exitOut.Show();
            this.Hide();
        }

        //Experimental code for joysticks
        /*DirectInput input = new DirectInput();
        private JoystickState state;

        public class GameController
        {
            private Joystick joystick;
            private JoystickState state = new JoystickState();
        }

      
        public GameControllers(DirectInput directInput, Game game, int number)
        {
            var devices = directInput.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly);
            if (devices.Count == 0 || devices[number] == null)
            {
                // No Device
                return;
            }

            // Create Gamepad
            leftJoyStick = new Joystick(directInput, devices[number].InstanceGuid); //Basically WPF C# buttons are not compatible with direct input
            leftJoyStick.SetCooperativeLevel(game.Window.Handle, CooperativeLevel.Exclusive | CooperativeLevel.Foreground);

            // Set Axis Range for the Analog Sticks between -1000 and 1000 
            foreach (DeviceObjectInstance deviceObject in leftJoyStick.GetObjects())
            {
                if ((deviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                    leftJoyStick.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-1000, 1000);
            }
            leftJoyStick.Acquire();
        }

        public JoystickState GetState()
        {
            if (leftJoyStick.Acquire().IsFailure || leftJoyStick.Poll().IsFailure)
            {
                state = new JoystickState();
                return state;
            }

            state = leftJoyStick.GetCurrentState();

            return state;
        }*/
    }
}
