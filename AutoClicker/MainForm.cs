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
            //ctrl+z runs this command
            /*
            if (e.Control == true && e.KeyCode == Keys.Z)
            {
                xPos_textBox.Text = "test";
            }*/
            if (e.KeyCode == Keys.Z)
            {
                xPos_textBox.Text = "test";
            }
            

        }
    }
}
