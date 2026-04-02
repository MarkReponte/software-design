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
            txtArrayInput = new TextBox();
            btnFactorialResult = new Button();
            lblSumResult = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtArrayInput
            // 
            txtArrayInput.Anchor = AnchorStyles.None;
            txtArrayInput.Location = new Point(319, 57);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(147, 23);
            txtArrayInput.TabIndex = 0;
            // 
            // btnFactorialResult
            // 
            btnFactorialResult.Anchor = AnchorStyles.None;
            btnFactorialResult.Location = new Point(319, 86);
            btnFactorialResult.Name = "btnFactorialResult";
            btnFactorialResult.Size = new Size(68, 23);
            btnFactorialResult.TabIndex = 1;
            btnFactorialResult.Text = "Factorial";
            btnFactorialResult.UseVisualStyleBackColor = true;
            btnFactorialResult.Click += btnFactorialResult_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.Anchor = AnchorStyles.None;
            lblSumResult.Location = new Point(393, 86);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(68, 23);
            lblSumResult.TabIndex = 2;
            lblSumResult.Text = "Sum";
            lblSumResult.UseVisualStyleBackColor = true;
            lblSumResult.Click += button1_Click;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.None;
            lblResult.AutoSize = true;
            lblResult.Location = new Point(319, 150);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(lblSumResult);
            Controls.Add(btnFactorialResult);
            Controls.Add(txtArrayInput);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArrayInput;
        private Button btnFactorialResult;
        private Button lblSumResult;
        private Label lblResult;
    }
}
