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
            btnProcess = new Button();
            lbBooks = new ListBox();
            SuspendLayout();
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(290, 349);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(196, 32);
            btnProcess.TabIndex = 3;
            btnProcess.Text = "Process";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnAdd_Click;
            // 
            // lbBooks
            // 
            lbBooks.FormattingEnabled = true;
            lbBooks.Location = new Point(186, 69);
            lbBooks.Name = "lbBooks";
            lbBooks.Size = new Size(429, 274);
            lbBooks.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcess);
            Controls.Add(lbBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcess;
        private ListBox lbBooks;
    }
}
