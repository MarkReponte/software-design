namespace Task5
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
            btnSort = new Button();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Location = new Point(59, 88);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 3;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(174, 88);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(568, 274);
            listBoxResults.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSort);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSort;
        private ListBox listBoxResults;
    }
}
