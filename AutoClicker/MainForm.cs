﻿using System;
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
        }

        private void setTimeDefault_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (setTimeDefault_radioButton.Checked == true)
            {
                start_textBox.Enabled = false;
                end_textBox.Enabled = false;
                hours_textBox.Enabled = true;
                minutes_textBox.Enabled = true;
                seconds_textBox.Enabled = true;
                milliseconds_textBox.Enabled = true;
            }
        }
    }
}
