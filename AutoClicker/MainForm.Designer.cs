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
            this.clickInterval_groupBox = new System.Windows.Forms.GroupBox();
            this.setTimeRand_radioButton = new System.Windows.Forms.RadioButton();
            this.setTimeDefault_radioButton = new System.Windows.Forms.RadioButton();
            this.end_label = new System.Windows.Forms.Label();
            this.start_label = new System.Windows.Forms.Label();
            this.end_textBox = new System.Windows.Forms.TextBox();
            this.range_label = new System.Windows.Forms.Label();
            this.start_textBox = new System.Windows.Forms.TextBox();
            this.milliseconds_label = new System.Windows.Forms.Label();
            this.milliseconds_textBox = new System.Windows.Forms.TextBox();
            this.seconds_label = new System.Windows.Forms.Label();
            this.seconds_textBox = new System.Windows.Forms.TextBox();
            this.minutes_label = new System.Windows.Forms.Label();
            this.minutes_textBox = new System.Windows.Forms.TextBox();
            this.hours_label = new System.Windows.Forms.Label();
            this.hours_textBox = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.clickOptions_groupBox = new System.Windows.Forms.GroupBox();
            this.mouseBtn_comboBox = new System.Windows.Forms.ComboBox();
            this.mouseBtn_label = new System.Windows.Forms.Label();
            this.clickInterval_groupBox.SuspendLayout();
            this.clickOptions_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickInterval_groupBox
            // 
            this.clickInterval_groupBox.Controls.Add(this.setTimeRand_radioButton);
            this.clickInterval_groupBox.Controls.Add(this.setTimeDefault_radioButton);
            this.clickInterval_groupBox.Controls.Add(this.end_label);
            this.clickInterval_groupBox.Controls.Add(this.start_label);
            this.clickInterval_groupBox.Controls.Add(this.end_textBox);
            this.clickInterval_groupBox.Controls.Add(this.range_label);
            this.clickInterval_groupBox.Controls.Add(this.start_textBox);
            this.clickInterval_groupBox.Controls.Add(this.milliseconds_label);
            this.clickInterval_groupBox.Controls.Add(this.milliseconds_textBox);
            this.clickInterval_groupBox.Controls.Add(this.seconds_label);
            this.clickInterval_groupBox.Controls.Add(this.seconds_textBox);
            this.clickInterval_groupBox.Controls.Add(this.minutes_label);
            this.clickInterval_groupBox.Controls.Add(this.minutes_textBox);
            this.clickInterval_groupBox.Controls.Add(this.hours_label);
            this.clickInterval_groupBox.Controls.Add(this.hours_textBox);
            this.clickInterval_groupBox.Location = new System.Drawing.Point(12, 12);
            this.clickInterval_groupBox.Name = "clickInterval_groupBox";
            this.clickInterval_groupBox.Size = new System.Drawing.Size(299, 239);
            this.clickInterval_groupBox.TabIndex = 0;
            this.clickInterval_groupBox.TabStop = false;
            this.clickInterval_groupBox.Text = "Click Interval";
            // 
            // setTimeRand_radioButton
            // 
            this.setTimeRand_radioButton.AutoSize = true;
            this.setTimeRand_radioButton.Location = new System.Drawing.Point(39, 188);
            this.setTimeRand_radioButton.Name = "setTimeRand_radioButton";
            this.setTimeRand_radioButton.Size = new System.Drawing.Size(116, 17);
            this.setTimeRand_radioButton.TabIndex = 15;
            this.setTimeRand_radioButton.Text = "Set Time(Random):";
            this.setTimeRand_radioButton.UseVisualStyleBackColor = true;
            this.setTimeRand_radioButton.CheckedChanged += new System.EventHandler(this.setTimeRand_radioButton_CheckedChanged);
            // 
            // setTimeDefault_radioButton
            // 
            this.setTimeDefault_radioButton.AutoSize = true;
            this.setTimeDefault_radioButton.Checked = true;
            this.setTimeDefault_radioButton.Location = new System.Drawing.Point(39, 31);
            this.setTimeDefault_radioButton.Name = "setTimeDefault_radioButton";
            this.setTimeDefault_radioButton.Size = new System.Drawing.Size(110, 17);
            this.setTimeDefault_radioButton.TabIndex = 14;
            this.setTimeDefault_radioButton.TabStop = true;
            this.setTimeDefault_radioButton.Text = "Set Time(Default):";
            this.setTimeDefault_radioButton.UseVisualStyleBackColor = true;
            this.setTimeDefault_radioButton.CheckedChanged += new System.EventHandler(this.setTimeDefault_radioButton_CheckedChanged);
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Location = new System.Drawing.Point(239, 192);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(29, 13);
            this.end_label.TabIndex = 13;
            this.end_label.Text = "End:";
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Location = new System.Drawing.Point(175, 192);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(32, 13);
            this.start_label.TabIndex = 12;
            this.start_label.Text = "Start:";
            // 
            // end_textBox
            // 
            this.end_textBox.Enabled = false;
            this.end_textBox.Location = new System.Drawing.Point(242, 208);
            this.end_textBox.Name = "end_textBox";
            this.end_textBox.Size = new System.Drawing.Size(45, 20);
            this.end_textBox.TabIndex = 11;
            this.end_textBox.Text = "0";
            // 
            // range_label
            // 
            this.range_label.AutoSize = true;
            this.range_label.Location = new System.Drawing.Point(68, 211);
            this.range_label.Name = "range_label";
            this.range_label.Size = new System.Drawing.Size(107, 13);
            this.range_label.TabIndex = 10;
            this.range_label.Text = "Range(milliseconds) -";
            // 
            // start_textBox
            // 
            this.start_textBox.Enabled = false;
            this.start_textBox.Location = new System.Drawing.Point(178, 208);
            this.start_textBox.Name = "start_textBox";
            this.start_textBox.Size = new System.Drawing.Size(45, 20);
            this.start_textBox.TabIndex = 9;
            this.start_textBox.Text = "0";
            // 
            // milliseconds_label
            // 
            this.milliseconds_label.AutoSize = true;
            this.milliseconds_label.Location = new System.Drawing.Point(68, 129);
            this.milliseconds_label.Name = "milliseconds_label";
            this.milliseconds_label.Size = new System.Drawing.Size(63, 13);
            this.milliseconds_label.TabIndex = 8;
            this.milliseconds_label.Text = "milliseconds";
            // 
            // milliseconds_textBox
            // 
            this.milliseconds_textBox.Location = new System.Drawing.Point(178, 129);
            this.milliseconds_textBox.Name = "milliseconds_textBox";
            this.milliseconds_textBox.Size = new System.Drawing.Size(45, 20);
            this.milliseconds_textBox.TabIndex = 7;
            this.milliseconds_textBox.Text = "0";
            // 
            // seconds_label
            // 
            this.seconds_label.AutoSize = true;
            this.seconds_label.Location = new System.Drawing.Point(68, 103);
            this.seconds_label.Name = "seconds_label";
            this.seconds_label.Size = new System.Drawing.Size(47, 13);
            this.seconds_label.TabIndex = 6;
            this.seconds_label.Text = "seconds";
            // 
            // seconds_textBox
            // 
            this.seconds_textBox.Location = new System.Drawing.Point(178, 103);
            this.seconds_textBox.Name = "seconds_textBox";
            this.seconds_textBox.Size = new System.Drawing.Size(45, 20);
            this.seconds_textBox.TabIndex = 5;
            this.seconds_textBox.Text = "0";
            // 
            // minutes_label
            // 
            this.minutes_label.AutoSize = true;
            this.minutes_label.Location = new System.Drawing.Point(68, 77);
            this.minutes_label.Name = "minutes_label";
            this.minutes_label.Size = new System.Drawing.Size(43, 13);
            this.minutes_label.TabIndex = 4;
            this.minutes_label.Text = "minutes";
            // 
            // minutes_textBox
            // 
            this.minutes_textBox.Location = new System.Drawing.Point(178, 77);
            this.minutes_textBox.Name = "minutes_textBox";
            this.minutes_textBox.Size = new System.Drawing.Size(45, 20);
            this.minutes_textBox.TabIndex = 3;
            this.minutes_textBox.Text = "0";
            // 
            // hours_label
            // 
            this.hours_label.AutoSize = true;
            this.hours_label.Location = new System.Drawing.Point(68, 51);
            this.hours_label.Name = "hours_label";
            this.hours_label.Size = new System.Drawing.Size(33, 13);
            this.hours_label.TabIndex = 2;
            this.hours_label.Text = "hours";
            // 
            // hours_textBox
            // 
            this.hours_textBox.Location = new System.Drawing.Point(178, 51);
            this.hours_textBox.Name = "hours_textBox";
            this.hours_textBox.Size = new System.Drawing.Size(45, 20);
            this.hours_textBox.TabIndex = 1;
            this.hours_textBox.Text = "0";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(713, 415);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            // 
            // clickOptions_groupBox
            // 
            this.clickOptions_groupBox.Controls.Add(this.mouseBtn_label);
            this.clickOptions_groupBox.Controls.Add(this.mouseBtn_comboBox);
            this.clickOptions_groupBox.Location = new System.Drawing.Point(317, 12);
            this.clickOptions_groupBox.Name = "clickOptions_groupBox";
            this.clickOptions_groupBox.Size = new System.Drawing.Size(200, 100);
            this.clickOptions_groupBox.TabIndex = 2;
            this.clickOptions_groupBox.TabStop = false;
            this.clickOptions_groupBox.Text = "Click Options";
            // 
            // mouseBtn_comboBox
            // 
            this.mouseBtn_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mouseBtn_comboBox.FormattingEnabled = true;
            this.mouseBtn_comboBox.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle"});
            this.mouseBtn_comboBox.Location = new System.Drawing.Point(110, 27);
            this.mouseBtn_comboBox.Name = "mouseBtn_comboBox";
            this.mouseBtn_comboBox.Size = new System.Drawing.Size(84, 21);
            this.mouseBtn_comboBox.TabIndex = 0;
            // 
            // mouseBtn_label
            // 
            this.mouseBtn_label.AutoSize = true;
            this.mouseBtn_label.Location = new System.Drawing.Point(6, 30);
            this.mouseBtn_label.Name = "mouseBtn_label";
            this.mouseBtn_label.Size = new System.Drawing.Size(76, 13);
            this.mouseBtn_label.TabIndex = 1;
            this.mouseBtn_label.Text = "Mouse Button:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clickOptions_groupBox);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.clickInterval_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AutoClicker";
            this.clickInterval_groupBox.ResumeLayout(false);
            this.clickInterval_groupBox.PerformLayout();
            this.clickOptions_groupBox.ResumeLayout(false);
            this.clickOptions_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox clickInterval_groupBox;
        private System.Windows.Forms.TextBox hours_textBox;
        private System.Windows.Forms.Label hours_label;
        private System.Windows.Forms.Label range_label;
        private System.Windows.Forms.TextBox start_textBox;
        private System.Windows.Forms.Label milliseconds_label;
        private System.Windows.Forms.TextBox milliseconds_textBox;
        private System.Windows.Forms.Label seconds_label;
        private System.Windows.Forms.TextBox seconds_textBox;
        private System.Windows.Forms.Label minutes_label;
        private System.Windows.Forms.TextBox minutes_textBox;
        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.Label start_label;
        private System.Windows.Forms.TextBox end_textBox;
        private System.Windows.Forms.RadioButton setTimeRand_radioButton;
        private System.Windows.Forms.RadioButton setTimeDefault_radioButton;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.GroupBox clickOptions_groupBox;
        private System.Windows.Forms.ComboBox mouseBtn_comboBox;
        private System.Windows.Forms.Label mouseBtn_label;
    }
}

