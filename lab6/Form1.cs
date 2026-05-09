using LAB5;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Net;
using static LAB5.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var context = new BookstoreContext())
            {
                context.Database.EnsureCreated();
            }
        }

        public async Task<List<string>> GetBookAsync()
        {
            using (var context = new BookstoreContext())
            {

                var books = await context.Books.Include(b => b.Author)
                                                .Select(b => $"{b.Title} by {b.Author.Name}")
                                                .ToListAsync();

                return books;
            }
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(v => progressBar.Value = v);
            var books = await GetBooksListAsync(progress);

            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = books;

            listBoxBooks.DisplayMember = "Title";
        }

        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };


                context.Authors.Add(author);
                context.Books.Add(book);

                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateBookAsync(int id, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.Include(b => b.Author)
                                              .FirstOrDefaultAsync(b => b.BookID == id);
                if (book != null)
                {
                    book.Title = newTitle;
                    if (book.Author != null)
                    {
                        book.Author.Name = newAuthorName;
                    }
                    await context.SaveChangesAsync();
                }
            }
        }


        public async Task DeleteBookAsync(int id)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FindAsync(id);
                if (book != null)
                {
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task FetchWithProgressAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                progress.Report(10);
                await Task.Delay(500);
                progress.Report(50);

                var books = await context.Books.Include(b => b.Author).Select(b => $"{b.Title} by {b.Author.Name}").ToListAsync();

                await Task.Delay(500);
                progress.Report(100);
            }
        }

        public async Task<List<string>> GetBooksListAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                progress.Report(30);

                var books = await context.Books.Include(b => b.Author).Select(b => $"{b.Title} by {b.Author.Name}").ToListAsync();

                progress.Report(100);
                return books;
            }
        }

        public async Task<List<string>> SearchTitleAsync(string searchTerm)
        {
            using (var context = new BookstoreContext())
            {
                string term = searchTerm.ToLower();

                return await context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Title.ToLower().Contains(term))
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();
            }
        }

        private void grpbxBooks_Enter(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {

            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookAsync(bookTitle, authorName);

            MessageBox.Show("Book and Author saved successfully!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem is Book selectedBook)
            {

                txtBookID.Text = selectedBook.BookID.ToString();
                txtBookTitle.Text = selectedBook.Title;
                txtAuthorName.Text = selectedBook.Author?.Name;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text.Trim();
            string bookTitle = txtBookTitle.Text.Trim();

            if (!int.TryParse(txtBookID.Text.Trim(), out int bookId))
            {
                MessageBox.Show("Please enter a valid Book ID.");
                return;
            }

            if (string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(bookTitle))
            {
                MessageBox.Show("Please enter both author and book title to update.");
                return;
            }

            await UpdateBookAsync(bookId, bookTitle, authorName);

            MessageBox.Show("Book updated successfully!");

            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = await GetBooksListAsync(new Progress<int>());

            txtBookID.Clear();
            txtAuthorName.Clear();
            txtBookTitle.Clear();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a title to search.");
                return;
            }

            var results = await SearchTitleAsync(searchTerm);

            listBoxBooks.DataSource = null;

            if (results.Count > 0)
            {
                listBoxBooks.DataSource = results;
            }
            else
            {
                MessageBox.Show("No books found matching the search term.");
            }

        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text.Trim(), out int bookId))
            {
                MessageBox.Show("Please enter a valid Book ID to delete.");
                return;
            }
            

            await DeleteBookAsync(bookId);

            MessageBox.Show("Book deleted successfully!");

            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = await GetBookAsync();

            txtBookID.Clear();
        }
    }
}
