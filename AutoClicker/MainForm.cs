using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        //https://ourcodeworld.com/articles/read/573/how-to-register-a-single-or-multiple-global-hotkeys-for-a-single-key-in-winforms
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        private bool flag;

        public MainForm()
        {
            InitializeComponent();
            //Sets default select box items
            mouseBtn_comboBox.SelectedItem = "Single Left Click";

            // 3. Register HotKey

            // Set an unique id to your Hotkey, it will be used to
            // identify which hotkey was pressed in your code to execute something
            int UniqueHotkeyId = 1;
            // Set the Hotkey triggerer the F9 key 
            // Expected an integer value for F9: 0x78, but you can convert the Keys.KEY to its int value
            // See: https://msdn.microsoft.com/en-us/library/windows/desktop/dd375731(v=vs.85).aspx
            int HotKeyCode = (int)Keys.F9;
            // Register the "F9" hotkey
            Boolean F9Registered = RegisterHotKey(
                this.Handle, UniqueHotkeyId, 0x0000, HotKeyCode
            );

            // 4. Verify if the hotkey was succesfully registered, if not, show message in the console
            if (F9Registered)
            {
                Console.WriteLine("Global Hotkey F9 was succesfully registered");
            }
            else
            {
                Console.WriteLine("Global Hotkey F9 couldn't be registered !");
            }

            this.flag = false;
        }

        private void setTimeDefault_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Enabled text fields for time default
            if (setTimeDefault_radioButton.Enabled == true)
            {
                start_textBox.Enabled = false;
                end_textBox.Enabled = false;
                milliseconds_textBox.Enabled = true;
            }
        }

        private void setTimeRand_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Enabled text fields for time rand
            if (setTimeRand_radioButton.Enabled == true)
            {
                start_textBox.Enabled = true;
                end_textBox.Enabled = true;
                milliseconds_textBox.Enabled = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                xPos_textBox.Text = Cursor.Position.X.ToString();
                yPos_textBox.Text = Cursor.Position.Y.ToString();
            }
            

        }

        private void repeatCount_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (repeatCount_radioButton.Enabled == true)
            {
                repeatCount_textBox.Enabled = true;
            }
        }

        private void keyPressStop_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (keyPressStop_radioButton.Enabled == true)
            {
                repeatCount_textBox.Enabled = false;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)mouseClicksInfo_dataGridView.Rows[0].Clone();
            string id = mouseClicksInfo_dataGridView.RowCount.ToString(); //Row Count is the ID - id starts at 1
            row.Cells[0].Value = id;
            row.Cells[1].Value = mouseBtn_comboBox.Text;
            row.Cells[2].Value = xPos_textBox.Text;
            row.Cells[3].Value = yPos_textBox.Text;
     
            mouseClicksInfo_dataGridView.Rows.Add(row);
        }
        BackgroundWorker BackgroundWorker;
        private void run_button_Click(object sender, EventArgs e)
        {
            BackgroundWorker = new BackgroundWorker();
            BackgroundWorker.DoWork += (obj, ea) => TaskAsync(1);
            BackgroundWorker.RunWorkerAsync();
        }

        private async void TaskAsync(int times)
        {
            this.flag = true;
            while (this.flag)
            {
                // Set the Current cursor, move the cursor's Position
                foreach (DataGridViewRow row in mouseClicksInfo_dataGridView.Rows)
                {
                    //Ignore last row
                    if (row.IsNewRow)
                    {
                        continue;
                    }

                    if (setTimeDefault_radioButton.Enabled == true)
                    {
                        if (Convert.ToInt16(milliseconds_textBox.Text) != 0)
                        {
                            System.Threading.Thread.Sleep(Convert.ToInt16(milliseconds_textBox.Text));
                        }
                    }
                    else if (setTimeRand_radioButton.Enabled == true)
                    {
                        System.Threading.Thread.Sleep(RandomNumber(Convert.ToInt16(start_textBox.Text), Convert.ToInt16(end_textBox.Text)));
                    }

                    Mouse.SetCursorPosition(Convert.ToInt16(row.Cells[2].Value), Convert.ToInt16(row.Cells[3].Value));

                    if (row.Cells[1].Value.ToString() == "Single Left Click")
                    {
                        Mouse.MouseEvent(Mouse.MouseEventFlags.LeftDown);
                        Mouse.MouseEvent(Mouse.MouseEventFlags.LeftUp);
                    }
                    else if (row.Cells[1].Value.ToString() == "Single Right Click")
                    {
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightDown);
                        Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                    }
                }
            }
        }
        protected override void WndProc(ref Message m)
        {
            // 5. Catch when a HotKey is pressed !
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                // MessageBox.Show(string.Format("Hotkey #{0} pressed", id));

                if (id == 1)
                {
                    //MessageBox.Show("F9 Was pressed !");
                    this.flag = false;
                }
            }
            base.WndProc(ref m);
        }

        private int RandomNumber(int startNumber, int endNumber)
        {
            Random rnd = new Random();
            int number = rnd.Next(startNumber, endNumber); // creates a number between start and end
            return number;
        }
    }
}
