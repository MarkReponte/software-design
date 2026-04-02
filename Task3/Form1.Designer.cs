namespace Task3
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
            txtFibonacciInput = new TextBox();
            btnFibonacciResult = new Button();
            lblFibonacciResult = new Label();
            label2 = new Label();
            txtBaseInput = new TextBox();
            txtExponentInput = new TextBox();
            btnPowerResult = new Button();
            lblPowerResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(276, 25);
            label1.TabIndex = 0;
            label1.Text = "Recursive Fibonacci Sequence";
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Anchor = AnchorStyles.None;
            txtFibonacciInput.ForeColor = SystemColors.ControlText;
            txtFibonacciInput.Location = new Point(75, 69);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.PlaceholderText = "Enter Number";
            txtFibonacciInput.Size = new Size(138, 23);
            txtFibonacciInput.TabIndex = 1;
            // 
            // btnFibonacciResult
            // 
            btnFibonacciResult.Anchor = AnchorStyles.None;
            btnFibonacciResult.Location = new Point(109, 98);
            btnFibonacciResult.Name = "btnFibonacciResult";
            btnFibonacciResult.Size = new Size(75, 23);
            btnFibonacciResult.TabIndex = 2;
            btnFibonacciResult.Text = "Calculate";
            btnFibonacciResult.UseVisualStyleBackColor = true;
            btnFibonacciResult.Click += btnFibonacciResult_Click;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.Anchor = AnchorStyles.None;
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(93, 133);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(0, 15);
            lblFibonacciResult.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(439, 30);
            label2.Name = "label2";
            label2.Size = new Size(280, 25);
            label2.TabIndex = 4;
            label2.Text = "Recursive Power Computation";
            // 
            // txtBaseInput
            // 
            txtBaseInput.Anchor = AnchorStyles.None;
            txtBaseInput.ForeColor = SystemColors.ControlText;
            txtBaseInput.Location = new Point(477, 69);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.PlaceholderText = "base number";
            txtBaseInput.Size = new Size(81, 23);
            txtBaseInput.TabIndex = 5;
            // 
            // txtExponentInput
            // 
            txtExponentInput.Anchor = AnchorStyles.None;
            txtExponentInput.ForeColor = SystemColors.ControlText;
            txtExponentInput.Location = new Point(564, 69);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.PlaceholderText = "n number";
            txtExponentInput.Size = new Size(81, 23);
            txtExponentInput.TabIndex = 6;
            // 
            // btnPowerResult
            // 
            btnPowerResult.Anchor = AnchorStyles.None;
            btnPowerResult.Location = new Point(524, 98);
            btnPowerResult.Name = "btnPowerResult";
            btnPowerResult.Size = new Size(75, 23);
            btnPowerResult.TabIndex = 7;
            btnPowerResult.Text = "Calculate";
            btnPowerResult.UseVisualStyleBackColor = true;
            btnPowerResult.Click += btnPowerResult_Click;
            // 
            // lblPowerResult
            // 
            lblPowerResult.Anchor = AnchorStyles.None;
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(514, 133);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(0, 15);
            lblPowerResult.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPowerResult);
            Controls.Add(btnPowerResult);
            Controls.Add(txtExponentInput);
            Controls.Add(txtBaseInput);
            Controls.Add(label2);
            Controls.Add(lblFibonacciResult);
            Controls.Add(btnFibonacciResult);
            Controls.Add(txtFibonacciInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFibonacciInput;
        private Button btnFibonacciResult;
        private Label lblFibonacciResult;
        private Label label2;
        private TextBox txtBaseInput;
        private TextBox txtExponentInput;
        private Button btnPowerResult;
        private Label lblPowerResult;
    }
}
