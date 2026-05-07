using Microsoft.EntityFrameworkCore;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public void UpdateListOfBooks(int bookId, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(bookId);

                if (book != null)
                {
                    book.Title = bookTitle;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
            }
        }

        public void RefreshBookList()
        {
            var books = GetBooksWithAuthors();

            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = books;
        }

        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();
                return booksWithAuthors;
            }
        }

        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author) 
                    .Where(b => b.Author.Name.Contains(authorName)) 
                    .Select(b => $"{b.Title} (ID: {b.BookID})") 
                    .ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string author = txtAuthorName.Text.Trim();
            string title = txtBookTitle.Text.Trim();
            string id = txtId.Text.Trim();

            if (string.IsNullOrEmpty(author) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter both an author and a book title.");
                return;
            }


            AddAuthorWithBook(author, title);


            txtAuthorName.Clear();
            txtBookTitle.Clear();
            txtId.Clear();
            RefreshBookList();

            MessageBox.Show("Book added successfully!");
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            listBoxBooks.DataSource = books;
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            UpdateListOfBooks(1, "New Improved Title");

            RefreshBookList();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                DeleteBook(id);
                txtId.Clear();
                RefreshBookList();
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Book ID.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchName))
            {
                var results = SearchBooksByAuthor(searchName);
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = results;

                if (results.Count == 0)
                {
                    MessageBox.Show("No books found for that author.");
                }
            }
        }
    }
}
