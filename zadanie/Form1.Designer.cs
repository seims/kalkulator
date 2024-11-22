namespace Calc4GH
{
    partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            displayTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button15 = new Button();
            button14 = new Button();
            button16 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(displayTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 1);
            tableLayoutPanel1.Controls.Add(button4, 0, 2);
            tableLayoutPanel1.Controls.Add(button5, 1, 2);
            tableLayoutPanel1.Controls.Add(button6, 2, 2);
            tableLayoutPanel1.Controls.Add(button7, 0, 3);
            tableLayoutPanel1.Controls.Add(button8, 1, 3);
            tableLayoutPanel1.Controls.Add(button9, 2, 3);
            tableLayoutPanel1.Controls.Add(button10, 1, 4);
            tableLayoutPanel1.Controls.Add(button11, 3, 1);
            tableLayoutPanel1.Controls.Add(button12, 3, 2);
            tableLayoutPanel1.Controls.Add(button13, 0, 4);
            tableLayoutPanel1.Controls.Add(button15, 2, 4);
            tableLayoutPanel1.Controls.Add(button14, 3, 4);
            tableLayoutPanel1.Controls.Add(button16, 3, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(549, 548);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // displayTextBox
            // 
            tableLayoutPanel1.SetColumnSpan(displayTextBox, 4);
            displayTextBox.Dock = DockStyle.Fill;
            displayTextBox.Font = new Font("Segoe UI", 24F);
            displayTextBox.Location = new Point(3, 3);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.Size = new Size(543, 50);
            displayTextBox.TabIndex = 0;
            displayTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 112);
            button1.Name = "button1";
            button1.Size = new Size(131, 103);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonPressed;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(140, 112);
            button2.Name = "button2";
            button2.Size = new Size(131, 103);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonPressed;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(277, 112);
            button3.Name = "button3";
            button3.Size = new Size(131, 103);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonPressed;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(3, 221);
            button4.Name = "button4";
            button4.Size = new Size(131, 103);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ButtonPressed;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(140, 221);
            button5.Name = "button5";
            button5.Size = new Size(131, 103);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ButtonPressed;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(277, 221);
            button6.Name = "button6";
            button6.Size = new Size(131, 103);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ButtonPressed;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(3, 330);
            button7.Name = "button7";
            button7.Size = new Size(131, 103);
            button7.TabIndex = 7;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += ButtonPressed;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(140, 330);
            button8.Name = "button8";
            button8.Size = new Size(131, 103);
            button8.TabIndex = 8;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += ButtonPressed;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(277, 330);
            button9.Name = "button9";
            button9.Size = new Size(131, 103);
            button9.TabIndex = 9;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = true;
            button9.Click += ButtonPressed;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(140, 439);
            button10.Name = "button10";
            button10.Size = new Size(131, 106);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ButtonPressed;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(414, 112);
            button11.Name = "button11";
            button11.Size = new Size(132, 103);
            button11.TabIndex = 11;
            button11.Text = "C";
            button11.UseVisualStyleBackColor = true;
            button11.Click += ClearDisplay;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(414, 221);
            button12.Name = "button12";
            button12.Size = new Size(132, 103);
            button12.TabIndex = 12;
            button12.Text = "+";
            button12.UseVisualStyleBackColor = true;
            button12.Click += FunctionButtonPressed;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Fill;
            button13.Location = new Point(3, 439);
            button13.Name = "button13";
            button13.Size = new Size(131, 106);
            button13.TabIndex = 13;
            button13.Text = "=";
            button13.UseVisualStyleBackColor = true;
            button13.Click += ShowResult;
            // 
            // button15
            // 
            button15.Location = new Point(277, 439);
            button15.Name = "button15";
            button15.Size = new Size(131, 106);
            button15.TabIndex = 15;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            button15.Click += FunctionButtonPressed;
            // 
            // button14
            // 
            button14.Location = new Point(414, 439);
            button14.Name = "button14";
            button14.Size = new Size(132, 103);
            button14.TabIndex = 14;
            button14.Text = "/";
            button14.UseVisualStyleBackColor = true;
            button14.Click += FunctionButtonPressed;
            // 
            // button16
            // 
            button16.Location = new Point(414, 330);
            button16.Name = "button16";
            button16.Size = new Size(132, 103);
            button16.TabIndex = 16;
            button16.Text = "-";
            button16.UseVisualStyleBackColor = true;
            button16.Click += FunctionButtonPressed;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(549, 548);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox displayTextBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;

    }
}
