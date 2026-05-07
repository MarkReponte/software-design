namespace lab5
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
            txtAuthorName = new TextBox();
            btnAddBook = new Button();
            groupBox1 = new GroupBox();
            txtBookID = new Label();
            txtId = new TextBox();
            btnDeleteBook = new Button();
            btnUpdateList = new Button();
            btnShowBooks = new Button();
            label2 = new Label();
            txtBookTitle = new TextBox();
            label1 = new Label();
            listBoxBooks = new ListBox();
            panel1 = new Panel();
            txtSearch = new TextBox();
            label3 = new Label();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthorName.Location = new Point(116, 75);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(146, 29);
            txtAuthorName.TabIndex = 0;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBook.Location = new Point(38, 183);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(203, 34);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBookID);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnDeleteBook);
            groupBox1.Controls.Add(btnUpdateList);
            groupBox1.Controls.Add(btnShowBooks);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBookTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAuthorName);
            groupBox1.Controls.Add(btnAddBook);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 450);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtBookID
            // 
            txtBookID.AutoSize = true;
            txtBookID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookID.Location = new Point(6, 43);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(67, 21);
            txtBookID.TabIndex = 11;
            txtBookID.Text = "Book ID:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(116, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(146, 29);
            txtId.TabIndex = 10;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteBook.Location = new Point(38, 263);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(203, 34);
            btnDeleteBook.TabIndex = 9;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateList
            // 
            btnUpdateList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateList.Location = new Point(38, 223);
            btnUpdateList.Name = "btnUpdateList";
            btnUpdateList.Size = new Size(203, 34);
            btnUpdateList.TabIndex = 8;
            btnUpdateList.Text = "Update List";
            btnUpdateList.UseVisualStyleBackColor = true;
            btnUpdateList.Click += btnUpdateList_Click;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowBooks.Location = new Point(38, 303);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(203, 34);
            btnShowBooks.TabIndex = 7;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 114);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 6;
            label2.Text = "Book Title:";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookTitle.Location = new Point(116, 110);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(146, 29);
            txtBookTitle.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 78);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 3;
            label1.Text = "Author Name:";
            // 
            // listBoxBooks
            // 
            listBoxBooks.Dock = DockStyle.Bottom;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(297, 71);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(503, 379);
            listBoxBooks.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(297, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 69);
            panel1.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(83, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(146, 29);
            txtSearch.TabIndex = 11;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 26);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 12;
            label3.Text = "Search:";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(247, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 30);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(listBoxBooks);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtAuthorName;
        private Button btnAddBook;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtBookTitle;
        private ListBox listBoxBooks;
        private Button btnShowBooks;
        private Button btnUpdateList;
        private Button btnDeleteBook;
        private Label txtBookID;
        private TextBox txtId;
        private Panel panel1;
        private Label label3;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
