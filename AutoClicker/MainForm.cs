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
            //Sets default select box item
            mouseBtn_comboBox.SelectedItem = "Left";
        }

        private void setTimeDefault_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Enabled text fields for time default
            if (setTimeDefault_radioButton.Enabled == true)
            {
                start_textBox.Enabled = false;
                end_textBox.Enabled = false;
                hours_textBox.Enabled = true;
                minutes_textBox.Enabled = true;
                seconds_textBox.Enabled = true;
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
                hours_textBox.Enabled = false;
                minutes_textBox.Enabled = false;
                seconds_textBox.Enabled = false;
                milliseconds_textBox.Enabled = false;
            }
        }
    }
}
