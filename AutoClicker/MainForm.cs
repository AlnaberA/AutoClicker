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
                // Set the Current cursor, move the cursor's Position,
                // and set its clipping rectangle to the form. 
                /*
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
                Cursor.Clip = new Rectangle(this.Location, this.Size);
                */

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
            //info2_richTextBox.Text = count;
            row.Cells[0].Value = id;

            if (setTimeDefault_radioButton.Checked)
            {
                row.Cells[1].Value = 100;
            }
            else
            {
                row.Cells[1].Value = 200;
            }
            


            row.Cells[2].Value = 2;
            row.Cells[3].Value = 3;
            row.Cells[4].Value = 4;
            mouseClicksInfo_dataGridView.Rows.Add(row);
            
        }
    }
}
