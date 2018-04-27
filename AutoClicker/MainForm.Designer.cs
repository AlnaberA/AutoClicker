namespace AutoClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addEdit_groupBox = new System.Windows.Forms.GroupBox();
            this.delay_groupBox = new System.Windows.Forms.GroupBox();
            this.setTimeDefault_radioButton = new System.Windows.Forms.RadioButton();
            this.milliseconds_textBox = new System.Windows.Forms.TextBox();
            this.setTimeRand_radioButton = new System.Windows.Forms.RadioButton();
            this.milliseconds_label = new System.Windows.Forms.Label();
            this.start_textBox = new System.Windows.Forms.TextBox();
            this.end_label = new System.Windows.Forms.Label();
            this.range_label = new System.Windows.Forms.Label();
            this.start_label = new System.Windows.Forms.Label();
            this.end_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.mouseBtn_comboBox = new System.Windows.Forms.ComboBox();
            this.mouseBtn_label = new System.Windows.Forms.Label();
            this.clickOptions_groupBox = new System.Windows.Forms.GroupBox();
            this.repeatCount_textBox = new System.Windows.Forms.TextBox();
            this.repeatCount_label = new System.Windows.Forms.Label();
            this.x_label = new System.Windows.Forms.Label();
            this.xPos_textBox = new System.Windows.Forms.TextBox();
            this.y_label = new System.Windows.Forms.Label();
            this.yPos_textBox = new System.Windows.Forms.TextBox();
            this.XYPos_groupBox = new System.Windows.Forms.GroupBox();
            this.addEdit_groupBox.SuspendLayout();
            this.delay_groupBox.SuspendLayout();
            this.clickOptions_groupBox.SuspendLayout();
            this.XYPos_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEdit_groupBox
            // 
            this.addEdit_groupBox.Controls.Add(this.XYPos_groupBox);
            this.addEdit_groupBox.Controls.Add(this.repeatCount_label);
            this.addEdit_groupBox.Controls.Add(this.repeatCount_textBox);
            this.addEdit_groupBox.Controls.Add(this.delay_groupBox);
            this.addEdit_groupBox.Controls.Add(this.add_button);
            this.addEdit_groupBox.Controls.Add(this.clickOptions_groupBox);
            this.addEdit_groupBox.Location = new System.Drawing.Point(12, 12);
            this.addEdit_groupBox.Name = "addEdit_groupBox";
            this.addEdit_groupBox.Size = new System.Drawing.Size(440, 426);
            this.addEdit_groupBox.TabIndex = 0;
            this.addEdit_groupBox.TabStop = false;
            this.addEdit_groupBox.Text = "Add/Edit Mouse Click";
            // 
            // delay_groupBox
            // 
            this.delay_groupBox.Controls.Add(this.setTimeDefault_radioButton);
            this.delay_groupBox.Controls.Add(this.milliseconds_textBox);
            this.delay_groupBox.Controls.Add(this.setTimeRand_radioButton);
            this.delay_groupBox.Controls.Add(this.milliseconds_label);
            this.delay_groupBox.Controls.Add(this.start_textBox);
            this.delay_groupBox.Controls.Add(this.end_label);
            this.delay_groupBox.Controls.Add(this.range_label);
            this.delay_groupBox.Controls.Add(this.start_label);
            this.delay_groupBox.Controls.Add(this.end_textBox);
            this.delay_groupBox.Location = new System.Drawing.Point(15, 19);
            this.delay_groupBox.Name = "delay_groupBox";
            this.delay_groupBox.Size = new System.Drawing.Size(271, 123);
            this.delay_groupBox.TabIndex = 17;
            this.delay_groupBox.TabStop = false;
            this.delay_groupBox.Text = "Delay Before Click";
            // 
            // setTimeDefault_radioButton
            // 
            this.setTimeDefault_radioButton.AutoSize = true;
            this.setTimeDefault_radioButton.Checked = true;
            this.setTimeDefault_radioButton.Location = new System.Drawing.Point(6, 19);
            this.setTimeDefault_radioButton.Name = "setTimeDefault_radioButton";
            this.setTimeDefault_radioButton.Size = new System.Drawing.Size(110, 17);
            this.setTimeDefault_radioButton.TabIndex = 14;
            this.setTimeDefault_radioButton.TabStop = true;
            this.setTimeDefault_radioButton.Text = "Set Time(Default):";
            this.setTimeDefault_radioButton.UseVisualStyleBackColor = true;
            this.setTimeDefault_radioButton.CheckedChanged += new System.EventHandler(this.setTimeDefault_radioButton_CheckedChanged);
            // 
            // milliseconds_textBox
            // 
            this.milliseconds_textBox.Location = new System.Drawing.Point(145, 39);
            this.milliseconds_textBox.Name = "milliseconds_textBox";
            this.milliseconds_textBox.Size = new System.Drawing.Size(45, 20);
            this.milliseconds_textBox.TabIndex = 7;
            this.milliseconds_textBox.Text = "0";
            // 
            // setTimeRand_radioButton
            // 
            this.setTimeRand_radioButton.AutoSize = true;
            this.setTimeRand_radioButton.Location = new System.Drawing.Point(6, 65);
            this.setTimeRand_radioButton.Name = "setTimeRand_radioButton";
            this.setTimeRand_radioButton.Size = new System.Drawing.Size(116, 17);
            this.setTimeRand_radioButton.TabIndex = 15;
            this.setTimeRand_radioButton.Text = "Set Time(Random):";
            this.setTimeRand_radioButton.UseVisualStyleBackColor = true;
            this.setTimeRand_radioButton.CheckedChanged += new System.EventHandler(this.setTimeRand_radioButton_CheckedChanged);
            // 
            // milliseconds_label
            // 
            this.milliseconds_label.AutoSize = true;
            this.milliseconds_label.Location = new System.Drawing.Point(35, 39);
            this.milliseconds_label.Name = "milliseconds_label";
            this.milliseconds_label.Size = new System.Drawing.Size(63, 13);
            this.milliseconds_label.TabIndex = 8;
            this.milliseconds_label.Text = "milliseconds";
            // 
            // start_textBox
            // 
            this.start_textBox.Enabled = false;
            this.start_textBox.Location = new System.Drawing.Point(145, 85);
            this.start_textBox.Name = "start_textBox";
            this.start_textBox.Size = new System.Drawing.Size(45, 20);
            this.start_textBox.TabIndex = 9;
            this.start_textBox.Text = "0";
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Location = new System.Drawing.Point(206, 69);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(29, 13);
            this.end_label.TabIndex = 13;
            this.end_label.Text = "End:";
            // 
            // range_label
            // 
            this.range_label.AutoSize = true;
            this.range_label.Location = new System.Drawing.Point(35, 88);
            this.range_label.Name = "range_label";
            this.range_label.Size = new System.Drawing.Size(107, 13);
            this.range_label.TabIndex = 10;
            this.range_label.Text = "Range(milliseconds) -";
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Location = new System.Drawing.Point(142, 69);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(32, 13);
            this.start_label.TabIndex = 12;
            this.start_label.Text = "Start:";
            // 
            // end_textBox
            // 
            this.end_textBox.Enabled = false;
            this.end_textBox.Location = new System.Drawing.Point(209, 85);
            this.end_textBox.Name = "end_textBox";
            this.end_textBox.Size = new System.Drawing.Size(45, 20);
            this.end_textBox.TabIndex = 11;
            this.end_textBox.Text = "0";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(359, 397);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 16;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(713, 389);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(713, 418);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 3;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            // 
            // mouseBtn_comboBox
            // 
            this.mouseBtn_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mouseBtn_comboBox.FormattingEnabled = true;
            this.mouseBtn_comboBox.Items.AddRange(new object[] {
            "Single Left Click",
            "Single Right Click",
            "Double Left Click",
            "Double Right Click"});
            this.mouseBtn_comboBox.Location = new System.Drawing.Point(98, 19);
            this.mouseBtn_comboBox.Name = "mouseBtn_comboBox";
            this.mouseBtn_comboBox.Size = new System.Drawing.Size(167, 21);
            this.mouseBtn_comboBox.TabIndex = 0;
            // 
            // mouseBtn_label
            // 
            this.mouseBtn_label.AutoSize = true;
            this.mouseBtn_label.Location = new System.Drawing.Point(6, 22);
            this.mouseBtn_label.Name = "mouseBtn_label";
            this.mouseBtn_label.Size = new System.Drawing.Size(76, 13);
            this.mouseBtn_label.TabIndex = 1;
            this.mouseBtn_label.Text = "Mouse Button:";
            // 
            // clickOptions_groupBox
            // 
            this.clickOptions_groupBox.Controls.Add(this.mouseBtn_label);
            this.clickOptions_groupBox.Controls.Add(this.mouseBtn_comboBox);
            this.clickOptions_groupBox.Location = new System.Drawing.Point(15, 148);
            this.clickOptions_groupBox.Name = "clickOptions_groupBox";
            this.clickOptions_groupBox.Size = new System.Drawing.Size(271, 60);
            this.clickOptions_groupBox.TabIndex = 2;
            this.clickOptions_groupBox.TabStop = false;
            this.clickOptions_groupBox.Text = "Click Options";
            // 
            // repeatCount_textBox
            // 
            this.repeatCount_textBox.Location = new System.Drawing.Point(374, 26);
            this.repeatCount_textBox.Name = "repeatCount_textBox";
            this.repeatCount_textBox.Size = new System.Drawing.Size(45, 20);
            this.repeatCount_textBox.TabIndex = 16;
            this.repeatCount_textBox.Text = "0";
            // 
            // repeatCount_label
            // 
            this.repeatCount_label.AutoSize = true;
            this.repeatCount_label.Location = new System.Drawing.Point(292, 29);
            this.repeatCount_label.Name = "repeatCount_label";
            this.repeatCount_label.Size = new System.Drawing.Size(76, 13);
            this.repeatCount_label.TabIndex = 16;
            this.repeatCount_label.Text = "Repeat Count:";
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Location = new System.Drawing.Point(6, 26);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(38, 13);
            this.x_label.TabIndex = 18;
            this.x_label.Text = "X-Pos:";
            // 
            // xPos_textBox
            // 
            this.xPos_textBox.Location = new System.Drawing.Point(50, 23);
            this.xPos_textBox.Name = "xPos_textBox";
            this.xPos_textBox.Size = new System.Drawing.Size(45, 20);
            this.xPos_textBox.TabIndex = 19;
            this.xPos_textBox.Text = "0";
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Location = new System.Drawing.Point(6, 60);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(38, 13);
            this.y_label.TabIndex = 20;
            this.y_label.Text = "Y-Pos:";
            // 
            // yPos_textBox
            // 
            this.yPos_textBox.Location = new System.Drawing.Point(50, 57);
            this.yPos_textBox.Name = "yPos_textBox";
            this.yPos_textBox.Size = new System.Drawing.Size(45, 20);
            this.yPos_textBox.TabIndex = 21;
            this.yPos_textBox.Text = "0";
            // 
            // XYPos_groupBox
            // 
            this.XYPos_groupBox.Controls.Add(this.y_label);
            this.XYPos_groupBox.Controls.Add(this.xPos_textBox);
            this.XYPos_groupBox.Controls.Add(this.yPos_textBox);
            this.XYPos_groupBox.Controls.Add(this.x_label);
            this.XYPos_groupBox.Location = new System.Drawing.Point(15, 214);
            this.XYPos_groupBox.Name = "XYPos_groupBox";
            this.XYPos_groupBox.Size = new System.Drawing.Size(271, 100);
            this.XYPos_groupBox.TabIndex = 4;
            this.XYPos_groupBox.TabStop = false;
            this.XYPos_groupBox.Text = "XY-Position";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.addEdit_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AutoClicker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.addEdit_groupBox.ResumeLayout(false);
            this.addEdit_groupBox.PerformLayout();
            this.delay_groupBox.ResumeLayout(false);
            this.delay_groupBox.PerformLayout();
            this.clickOptions_groupBox.ResumeLayout(false);
            this.clickOptions_groupBox.PerformLayout();
            this.XYPos_groupBox.ResumeLayout(false);
            this.XYPos_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addEdit_groupBox;
        private System.Windows.Forms.Label range_label;
        private System.Windows.Forms.TextBox start_textBox;
        private System.Windows.Forms.Label milliseconds_label;
        private System.Windows.Forms.TextBox milliseconds_textBox;
        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.Label start_label;
        private System.Windows.Forms.TextBox end_textBox;
        private System.Windows.Forms.RadioButton setTimeRand_radioButton;
        private System.Windows.Forms.RadioButton setTimeDefault_radioButton;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.GroupBox delay_groupBox;
        private System.Windows.Forms.GroupBox clickOptions_groupBox;
        private System.Windows.Forms.Label mouseBtn_label;
        private System.Windows.Forms.ComboBox mouseBtn_comboBox;
        private System.Windows.Forms.Label repeatCount_label;
        private System.Windows.Forms.TextBox repeatCount_textBox;
        private System.Windows.Forms.GroupBox XYPos_groupBox;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.TextBox xPos_textBox;
        private System.Windows.Forms.TextBox yPos_textBox;
        private System.Windows.Forms.Label x_label;
    }
}

