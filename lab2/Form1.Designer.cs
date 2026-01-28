namespace lab2
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
            label1 = new Label();
            label2 = new Label();
            txtInput = new TextBox();
            label3 = new Label();
            lblResult = new Label();
            btnCalculateFactorial = new Button();
            btnCalculateFibonacci = new Button();
            lblFibonacciResult = new Label();
            label5 = new Label();
            txtFibonacciInput = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnCalculateSum = new Button();
            lblSumResult = new Label();
            label8 = new Label();
            txtArrayInput = new TextBox();
            label9 = new Label();
            label10 = new Label();
            btnCalculatePower = new Button();
            lblPowerResult = new Label();
            label11 = new Label();
            txtBaseInput = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtExponentInput = new TextBox();
            label14 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(100, 66);
            label1.Name = "label1";
            label1.Size = new Size(235, 25);
            label1.TabIndex = 0;
            label1.Text = "FACTORIAL CALCULATOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 99);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter a number:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(99, 117);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(236, 23);
            txtInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(100, 147);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 3;
            label3.Text = "RESULT:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.Location = new Point(172, 147);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.TabIndex = 4;
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(261, 148);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(75, 23);
            btnCalculateFactorial.TabIndex = 5;
            btnCalculateFactorial.Text = "Solve";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(262, 304);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(75, 23);
            btnCalculateFibonacci.TabIndex = 11;
            btnCalculateFibonacci.Text = "Solve";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Font = new Font("Segoe UI", 12F);
            lblFibonacciResult.Location = new Point(173, 303);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(0, 21);
            lblFibonacciResult.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(101, 303);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 9;
            label5.Text = "RESULT:";
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(100, 273);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(236, 23);
            txtFibonacciInput.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 255);
            label6.Name = "label6";
            label6.Size = new Size(189, 15);
            label6.TabIndex = 7;
            label6.Text = "Enter a fibonacci number position:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.Location = new Point(101, 222);
            label7.Name = "label7";
            label7.Size = new Size(235, 25);
            label7.TabIndex = 6;
            label7.Text = "FIBONACCI CALCULATOR";
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(591, 148);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(75, 23);
            btnCalculateSum.TabIndex = 17;
            btnCalculateSum.Text = "Solve";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Font = new Font("Segoe UI", 12F);
            lblSumResult.Location = new Point(502, 147);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(0, 21);
            lblSumResult.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(430, 147);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 15;
            label8.Text = "RESULT:";
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(429, 117);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(236, 23);
            txtArrayInput.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(430, 99);
            label9.Name = "label9";
            label9.Size = new Size(173, 15);
            label9.TabIndex = 13;
            label9.Text = "Enter num1,num2,num3,...num";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label10.Location = new Point(430, 66);
            label10.Name = "label10";
            label10.Size = new Size(245, 25);
            label10.TabIndex = 12;
            label10.Text = "ARRAY SUM CALCULATOR";
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Location = new Point(597, 308);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(75, 23);
            btnCalculatePower.TabIndex = 23;
            btnCalculatePower.Text = "Solve";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Font = new Font("Segoe UI", 10F);
            lblPowerResult.Location = new Point(501, 306);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(0, 19);
            lblPowerResult.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(430, 306);
            label11.Name = "label11";
            label11.Size = new Size(66, 21);
            label11.TabIndex = 21;
            label11.Text = "RESULT:";
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(472, 252);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(200, 23);
            txtBaseInput.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(430, 255);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 19;
            label12.Text = "Base:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label13.Location = new Point(452, 222);
            label13.Name = "label13";
            label13.Size = new Size(203, 25);
            label13.TabIndex = 18;
            label13.Text = "POWER CALCULATOR";
            // 
            // txtExponentInput
            // 
            txtExponentInput.Location = new Point(472, 280);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(200, 23);
            txtExponentInput.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(430, 283);
            label14.Name = "label14";
            label14.Size = new Size(43, 15);
            label14.TabIndex = 24;
            label14.Text = "Power:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 392);
            Controls.Add(txtExponentInput);
            Controls.Add(label14);
            Controls.Add(btnCalculatePower);
            Controls.Add(lblPowerResult);
            Controls.Add(label11);
            Controls.Add(txtBaseInput);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(btnCalculateSum);
            Controls.Add(lblSumResult);
            Controls.Add(label8);
            Controls.Add(txtArrayInput);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(lblFibonacciResult);
            Controls.Add(label5);
            Controls.Add(txtFibonacciInput);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(txtInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtInput;
        private Label label3;
        private Label lblResult;
        private Button btnCalculateFactorial;
        private Button btnCalculateFibonacci;
        private Label lblFibonacciResult;
        private Label label5;
        private TextBox txtFibonacciInput;
        private Label label6;
        private Label label7;
        private Button btnCalculateSum;
        private Label lblSumResult;
        private Label label8;
        private TextBox txtArrayInput;
        private Label label9;
        private Label label10;
        private Button btnCalculatePower;
        private Label lblPowerResult;
        private Label label11;
        private TextBox txtBaseInput;
        private Label label12;
        private Label label13;
        private TextBox txtExponentInput;
        private Label label14;
    }
}
