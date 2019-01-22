using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Sets default select box items
            mouseBtn_comboBox.SelectedItem = "Single Left Click";
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

        private void run_button_Click(object sender, EventArgs e)
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

        private int RandomNumber(int startNumber, int endNumber)
        {
            Random rnd = new Random();
            int number = rnd.Next(startNumber, endNumber); // creates a number between start and end
            return number;
        }
    }
}
