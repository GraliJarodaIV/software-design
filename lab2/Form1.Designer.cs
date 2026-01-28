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
            btnCalculateFactorial = new Button();
            txtInput = new TextBox();
            lblResult = new Label();
            txtArrayInput = new TextBox();
            btnCalculateSum = new Button();
            lblSumResult = new Label();
            SuspendLayout();
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(282, 107);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(75, 23);
            btnCalculateFactorial.TabIndex = 0;
            btnCalculateFactorial.Text = "button1";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(282, 78);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(466, 81);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "label1";
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(282, 144);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(100, 23);
            txtArrayInput.TabIndex = 3;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(282, 173);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(75, 23);
            btnCalculateSum.TabIndex = 4;
            btnCalculateSum.Text = "button1";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(466, 152);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(38, 15);
            lblSumResult.TabIndex = 5;
            lblSumResult.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(btnCalculateFactorial);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculateFactorial;
        private TextBox txtInput;
        private Label lblResult;
        private TextBox txtArrayInput;
        private Button btnCalculateSum;
        private Label lblSumResult;
    }
}
