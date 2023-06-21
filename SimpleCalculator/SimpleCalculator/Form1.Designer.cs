namespace SimpleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            button13 = new System.Windows.Forms.Button();
            button14 = new System.Windows.Forms.Button();
            button15 = new System.Windows.Forms.Button();
            button17 = new System.Windows.Forms.Button();
            button18 = new System.Windows.Forms.Button();
            button20 = new System.Windows.Forms.Button();
            textBox_result = new System.Windows.Forms.TextBox();
            currentDisplay = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.AliceBlue;
            button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.DarkMagenta;
            button1.Location = new System.Drawing.Point(8, 165);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(67, 55);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.AliceBlue;
            button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.DarkMagenta;
            button2.Location = new System.Drawing.Point(90, 165);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(67, 55);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.AliceBlue;
            button3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.Color.DarkMagenta;
            button3.Location = new System.Drawing.Point(176, 165);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(67, 55);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.LavenderBlush;
            button4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.ForeColor = System.Drawing.Color.DarkMagenta;
            button4.Location = new System.Drawing.Point(259, 165);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(67, 55);
            button4.TabIndex = 3;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Operational_button;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.Salmon;
            button5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.ForeColor = System.Drawing.Color.DarkMagenta;
            button5.Location = new System.Drawing.Point(342, 165);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(67, 55);
            button5.TabIndex = 4;
            button5.Text = "CE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.Color.AliceBlue;
            button6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button6.ForeColor = System.Drawing.Color.DarkMagenta;
            button6.Location = new System.Drawing.Point(342, 243);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(67, 53);
            button6.TabIndex = 9;
            button6.Text = "C";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.Color.LavenderBlush;
            button7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button7.ForeColor = System.Drawing.Color.DarkMagenta;
            button7.Location = new System.Drawing.Point(259, 243);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(67, 53);
            button7.TabIndex = 8;
            button7.Text = "*";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Operational_button;
            // 
            // button8
            // 
            button8.BackColor = System.Drawing.Color.AliceBlue;
            button8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button8.ForeColor = System.Drawing.Color.DarkMagenta;
            button8.Location = new System.Drawing.Point(176, 243);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(67, 53);
            button8.TabIndex = 7;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Click;
            // 
            // button9
            // 
            button9.BackColor = System.Drawing.Color.AliceBlue;
            button9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button9.ForeColor = System.Drawing.Color.DarkMagenta;
            button9.Location = new System.Drawing.Point(90, 243);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(67, 53);
            button9.TabIndex = 6;
            button9.Text = "5";
            button9.UseVisualStyleBackColor = false;
            button9.Click += Click;
            // 
            // button10
            // 
            button10.BackColor = System.Drawing.Color.AliceBlue;
            button10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button10.ForeColor = System.Drawing.Color.DarkMagenta;
            button10.Location = new System.Drawing.Point(8, 243);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(67, 53);
            button10.TabIndex = 5;
            button10.Text = "4";
            button10.UseVisualStyleBackColor = false;
            button10.Click += Click;
            // 
            // button11
            // 
            button11.BackColor = System.Drawing.Color.LightPink;
            button11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button11.ForeColor = System.Drawing.Color.DarkMagenta;
            button11.Location = new System.Drawing.Point(342, 314);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(67, 124);
            button11.TabIndex = 14;
            button11.Text = "=";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = System.Drawing.Color.LavenderBlush;
            button12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button12.ForeColor = System.Drawing.Color.DarkMagenta;
            button12.Location = new System.Drawing.Point(259, 314);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(67, 53);
            button12.TabIndex = 13;
            button12.Text = "+";
            button12.UseVisualStyleBackColor = false;
            button12.Click += Operational_button;
            // 
            // button13
            // 
            button13.BackColor = System.Drawing.Color.AliceBlue;
            button13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button13.ForeColor = System.Drawing.Color.DarkMagenta;
            button13.Location = new System.Drawing.Point(176, 314);
            button13.Name = "button13";
            button13.Size = new System.Drawing.Size(67, 53);
            button13.TabIndex = 12;
            button13.Text = "3";
            button13.UseVisualStyleBackColor = false;
            button13.Click += Click;
            // 
            // button14
            // 
            button14.BackColor = System.Drawing.Color.AliceBlue;
            button14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button14.ForeColor = System.Drawing.Color.DarkMagenta;
            button14.Location = new System.Drawing.Point(90, 314);
            button14.Name = "button14";
            button14.Size = new System.Drawing.Size(67, 53);
            button14.TabIndex = 11;
            button14.Text = "2";
            button14.UseVisualStyleBackColor = false;
            button14.Click += Click;
            // 
            // button15
            // 
            button15.BackColor = System.Drawing.Color.AliceBlue;
            button15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button15.ForeColor = System.Drawing.Color.DarkMagenta;
            button15.Location = new System.Drawing.Point(8, 314);
            button15.Name = "button15";
            button15.Size = new System.Drawing.Size(67, 53);
            button15.TabIndex = 10;
            button15.Text = "1";
            button15.UseVisualStyleBackColor = false;
            button15.Click += Click;
            // 
            // button17
            // 
            button17.BackColor = System.Drawing.Color.LavenderBlush;
            button17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button17.ForeColor = System.Drawing.Color.DarkMagenta;
            button17.Location = new System.Drawing.Point(259, 388);
            button17.Name = "button17";
            button17.Size = new System.Drawing.Size(67, 50);
            button17.TabIndex = 18;
            button17.Text = "-";
            button17.UseVisualStyleBackColor = false;
            button17.Click += Operational_button;
            // 
            // button18
            // 
            button18.BackColor = System.Drawing.Color.LavenderBlush;
            button18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button18.ForeColor = System.Drawing.Color.DarkMagenta;
            button18.Location = new System.Drawing.Point(176, 388);
            button18.Name = "button18";
            button18.Size = new System.Drawing.Size(67, 50);
            button18.TabIndex = 17;
            button18.Text = ".";
            button18.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = System.Drawing.Color.Lavender;
            button20.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button20.ForeColor = System.Drawing.Color.DarkMagenta;
            button20.Location = new System.Drawing.Point(8, 388);
            button20.Name = "button20";
            button20.Size = new System.Drawing.Size(149, 50);
            button20.TabIndex = 15;
            button20.Text = "0";
            button20.UseVisualStyleBackColor = false;
            button20.Click += Click;
            // 
            // textBox_result
            // 
            textBox_result.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox_result.ForeColor = System.Drawing.Color.DarkMagenta;
            textBox_result.Location = new System.Drawing.Point(12, 83);
            textBox_result.Name = "textBox_result";
            textBox_result.Size = new System.Drawing.Size(381, 45);
            textBox_result.TabIndex = 19;
            textBox_result.Text = "0";
            textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentDisplay
            // 
            currentDisplay.AutoSize = true;
            currentDisplay.Location = new System.Drawing.Point(23, 35);
            currentDisplay.Name = "currentDisplay";
            currentDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            currentDisplay.Size = new System.Drawing.Size(0, 25);
            currentDisplay.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Lavender;
            ClientSize = new System.Drawing.Size(416, 450);
            Controls.Add(currentDisplay);
            Controls.Add(textBox_result);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button20);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = System.Drawing.Color.DarkMagenta;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximumSize = new System.Drawing.Size(438, 506);
            MinimumSize = new System.Drawing.Size(438, 506);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label currentDisplay;
    }
}
