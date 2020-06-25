using System;
using System.Drawing;
using System.Windows.Forms;

namespace BmLauncherWForm
{
    /// <summary>
    ///     Small class for reading button/mouse input
    /// </summary>
    public partial class inputForm : Form
    {
        // keys that are banned from being read. Most of them would break UserInput.ini
        readonly string[] bannedKeys =
        {
            "OEM8", "LWIN", "RWIN", "OEM7", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D0", "SCROLL",
            "OEM1", "OEMTILDE", "OEM7", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12",
            "NUMLOCK", "Backslash", "BACK", "EQUALS", "MULTIPLY", "DIVIDE", "SUBTRACT", "ADD", "DECIMAL", "PAUSE",
            "OEMBACKSLASH", "MENU", "NUMPAD0", "NUMPAD1", "NUMPAD2", "NUMPAD3", "NUMPAD4", "NUMPAD5", "NUMPAD6",
            "NUMPAD7", "NUMPAD8", "NUMPAD9", "CLEAR"
        };

        // currently selected button
        readonly Button currentButton;

        // list of input keys that need to be corrected
        readonly string[] inputWrong =
        {
            "OEM5", "OEMOPENBRACKETS", "OEM6", "OEMQUESTION", "OEMMINUS", "OEMPLUS", "OEMCOMMA", "OEMPERIOD",
            "CAPITAL", "Left", "Right", "Middle", "SPACE", "LEFT", "RIGHT", "UP", "DOWN", "XButton1", "XButton2",
            "SHIFTKEY", "CONTROLKEY"
        };

        // list of corrected keys
        readonly string[] outputRight =
        {
            "Backslash", "LeftBracket", "RightBracket", "Slash", "Underscore", "Equals", "Comma", "Period",
            "CapsLock", "LeftMouseButton", "RightMouseButton", "MiddleMouseButton", "SpaceBar", "Left", "Right",
            "Up", "Down", "ThumbMouseButton", "ThumbMouseButton2", "LeftShift", "LeftAlt"
        };

        // key input as string value
        private string keyPressed;


        /// <summary>
        ///     Constructor for inputForm.
        /// </summary>
        /// <param name="bt">current button</param>
        public inputForm(Button bt)
        {
            currentButton = bt;
            InitializeComponent();
            modifierBox.SelectedIndex = 0;
            inputButton.MouseWheel += get_mwinput;
            inputButton.Focus();
            inputButton.Select();
            inputButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        /// <summary>
        ///     Sets the input of the keybind-buttons.
        ///     It checks if the keyinput is equivalent to a banned key (first foreach loop),
        ///     calls three other methods (compareKeys, setModifiers, detectDuplicate)
        ///     and finally sets the text of the button.
        /// </summary>
        private void setInput()
        {
            foreach (string line in bannedKeys)
            {
                if (keyPressed.Equals(line))
                {
                    MessageBox.Show("Key not valid", "Not a valid input!");
                    return;
                }
            }

            keyPressed = compareKeys(keyPressed);
            keyPressed = setModifiers(keyPressed, modifierBox.SelectedIndex);
            detectDuplicate(keyPressed);
            foreach (Button bt in Program.myFactory.keybinds.buttonList)
            {
                if (currentButton.Name.Equals(bt.Name))
                {
                    bt.Text = keyPressed;
                    bt.ForeColor = Color.Black;
                }
            }

            this.Close();
        }

        /// <summary>
        ///     Compares keys to inputWrong list, corrects them with outputRight list.
        /// </summary>
        /// <param name="lineToCheck">Line to check</param>
        /// <returns>Corrected string</returns>
        private string compareKeys(string lineToCheck)
        {
            for (int i = 0; i < inputWrong.Length; i++)
            {
                if (lineToCheck.Equals(inputWrong[i]))
                {
                    lineToCheck = outputRight[i];
                    Console.WriteLine(lineToCheck);
                    return lineToCheck;
                }
            }

            return lineToCheck;
        }

        /// <summary>
        ///     Used to detect duplicates. Respects the new input.
        ///     Old keybind will be set to 'Unbound'.
        /// </summary>
        /// <param name="lineToCheck">Line to check</param>
        private void detectDuplicate(string lineToCheck)
        {
            foreach (Button bt in Program.myFactory.keybinds.buttonList)
            {
                if (bt.Text.Equals(lineToCheck))
                {
                    bt.Text = "Unbound";
                    bt.ForeColor = Color.Red;
                }
            }
        }

        /// <summary>
        ///     Applies modifiers to keys.
        ///     Very important for GraphicsWriter
        /// </summary>
        /// <param name="lineToCheck">Line to check</param>
        /// <param name="thisCase">case number used for switch</param>
        /// <returns>string with modifier prefix</returns>
        private string setModifiers(string lineToCheck, int thisCase)
        {
            switch (thisCase)
            {
                case 0:
                    return lineToCheck;

                case 1:
                    return "S+" + lineToCheck;

                case 2:
                    return "A+" + lineToCheck;

                case 3:
                    return "C+" + lineToCheck;
            }

            return lineToCheck;
        }

        /// <summary>
        ///     After selecting a modifier, the inputbutton that is used to read inputs is highlighted again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputButton.Select();
            inputButton.Focus();
        }

        /// <summary>
        ///     Writes keyboard input to string. Pressing 'Esc' closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">input</param>
        private void inputButton_KeyDown(object sender, KeyEventArgs e)
        {
            keyPressed = e.KeyCode.ToString().ToUpper();

            if (keyPressed.Contains("ESCAPE"))
            {
                this.Close();
            }
            else
            {
                setInput();
            }
        }

        /// <summary>
        ///     MouseEvent that specifically reads mouse scroll inputs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void get_mwinput(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                keyPressed = "MouseScrollUp";
            }
            else
            {
                keyPressed = "MouseScrollDown";
            }

            setInput();
        }

        /// <summary>
        ///     MouseEvent that specifically reads mouse click inputs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputButton_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e);
            keyPressed = e.Button.ToString();
            setInput();
        }
    }
}