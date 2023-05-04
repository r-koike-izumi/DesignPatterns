namespace State
{
    partial class SafeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ClockLabel = new Label();
            ScreenTextBox = new TextBox();
            UseButton = new Button();
            AlarmButton = new Button();
            PhoneButton = new Button();
            ExitButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ClockLabel
            // 
            ClockLabel.AutoSize = true;
            ClockLabel.Location = new Point(12, 9);
            ClockLabel.Name = "ClockLabel";
            ClockLabel.Size = new Size(31, 15);
            ClockLabel.TabIndex = 0;
            ClockLabel.Text = "時刻";
            // 
            // ScreenTextBox
            // 
            ScreenTextBox.AcceptsReturn = true;
            ScreenTextBox.Location = new Point(12, 27);
            ScreenTextBox.Multiline = true;
            ScreenTextBox.Name = "ScreenTextBox";
            ScreenTextBox.ScrollBars = ScrollBars.Vertical;
            ScreenTextBox.Size = new Size(318, 223);
            ScreenTextBox.TabIndex = 1;
            // 
            // UseButton
            // 
            UseButton.Location = new Point(12, 256);
            UseButton.Name = "UseButton";
            UseButton.Size = new Size(75, 23);
            UseButton.TabIndex = 2;
            UseButton.Text = "金庫使用";
            UseButton.UseVisualStyleBackColor = true;
            UseButton.Click += UseButton_Click;
            // 
            // AlarmButton
            // 
            AlarmButton.Location = new Point(93, 256);
            AlarmButton.Name = "AlarmButton";
            AlarmButton.Size = new Size(75, 23);
            AlarmButton.TabIndex = 2;
            AlarmButton.Text = "非常ベル";
            AlarmButton.UseVisualStyleBackColor = true;
            AlarmButton.Click += AlarmButton_Click;
            // 
            // PhoneButton
            // 
            PhoneButton.Location = new Point(174, 256);
            PhoneButton.Name = "PhoneButton";
            PhoneButton.Size = new Size(75, 23);
            PhoneButton.TabIndex = 2;
            PhoneButton.Text = "通常通話";
            PhoneButton.UseVisualStyleBackColor = true;
            PhoneButton.Click += PhoneButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(255, 256);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "終了";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // SafeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 290);
            Controls.Add(ExitButton);
            Controls.Add(PhoneButton);
            Controls.Add(AlarmButton);
            Controls.Add(UseButton);
            Controls.Add(ScreenTextBox);
            Controls.Add(ClockLabel);
            Name = "SafeForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ClockLabel;
        private TextBox ScreenTextBox;
        private Button UseButton;
        private Button AlarmButton;
        private Button PhoneButton;
        private Button ExitButton;
        private System.Windows.Forms.Timer timer1;
    }
}