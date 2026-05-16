namespace lab7
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
            panel2 = new Panel();
            btnSearch = new Button();
            label4 = new Label();
            txtSearch = new TextBox();
            listBoxBooks = new ListBox();
            grpbxBooks = new GroupBox();
            label5 = new Label();
            txtBookID = new TextBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            btnDeleteBook = new Button();
            btnFetchBooks = new Button();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            progressBar = new ProgressBar();
            panel3 = new Panel();
            lblPageNumber = new Label();
            btnPreviousPage = new Button();
            btnNext = new Button();
            panel2.SuspendLayout();
            grpbxBooks.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(333, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(467, 78);
            panel2.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(231, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 36);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(66, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(159, 23);
            txtSearch.TabIndex = 11;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(333, 86);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(467, 229);
            listBoxBooks.TabIndex = 15;
            // 
            // grpbxBooks
            // 
            grpbxBooks.Controls.Add(panel3);
            grpbxBooks.Controls.Add(label5);
            grpbxBooks.Controls.Add(txtBookID);
            grpbxBooks.Controls.Add(btnUpdate);
            grpbxBooks.Controls.Add(btnAdd);
            grpbxBooks.Controls.Add(label1);
            grpbxBooks.Controls.Add(label2);
            grpbxBooks.Controls.Add(btnDeleteBook);
            grpbxBooks.Controls.Add(btnFetchBooks);
            grpbxBooks.Controls.Add(txtAuthorName);
            grpbxBooks.Controls.Add(txtBookTitle);
            grpbxBooks.Dock = DockStyle.Left;
            grpbxBooks.Location = new Point(0, 0);
            grpbxBooks.Name = "grpbxBooks";
            grpbxBooks.Size = new Size(333, 450);
            grpbxBooks.TabIndex = 14;
            grpbxBooks.TabStop = false;
            grpbxBooks.Text = "Book";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 32);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 13;
            label5.Text = "ID:";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(98, 29);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(159, 23);
            txtBookID.TabIndex = 12;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(44, 239);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(248, 34);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(44, 199);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(248, 34);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 71);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 4;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 106);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "Author:";
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(44, 279);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(248, 34);
            btnDeleteBook.TabIndex = 7;
            btnDeleteBook.Text = "DELETE";
            btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(44, 159);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(248, 34);
            btnFetchBooks.TabIndex = 2;
            btnFetchBooks.Text = "FETCH BOOKS";
            btnFetchBooks.UseVisualStyleBackColor = true;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(98, 103);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(159, 23);
            txtAuthorName.TabIndex = 1;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(98, 63);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(159, 23);
            txtBookTitle.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(progressBar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(333, 366);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 84);
            panel1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 20);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 15;
            label3.Text = "Progress:";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(15, 38);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(440, 23);
            progressBar.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Location = new Point(333, 314);
            panel3.Name = "panel3";
            panel3.Size = new Size(467, 56);
            panel3.TabIndex = 18;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(530, 335);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(80, 15);
            lblPageNumber.TabIndex = 18;
            lblPageNumber.Text = "Page Number";
            lblPageNumber.Click += label6_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(432, 330);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(77, 25);
            btnPreviousPage.TabIndex = 19;
            btnPreviousPage.Text = "Previous ";
            btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(628, 330);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(77, 25);
            btnNext.TabIndex = 20;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            Controls.Add(btnPreviousPage);
            Controls.Add(lblPageNumber);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(listBoxBooks);
            Controls.Add(grpbxBooks);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            grpbxBooks.ResumeLayout(false);
            grpbxBooks.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnSearch;
        private Label label4;
        private TextBox txtSearch;
        private ListBox listBoxBooks;
        private GroupBox grpbxBooks;
        private Label label5;
        private TextBox txtBookID;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Button btnDeleteBook;
        private Button btnFetchBooks;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Panel panel1;
        private Label label3;
        private ProgressBar progressBar;
        private Panel panel3;
    }
}
