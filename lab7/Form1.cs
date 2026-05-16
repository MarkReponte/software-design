using LAB5;
using Microsoft.EntityFrameworkCore;
using static LAB5.Form1;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int pageSize = 10;
        private int currentPage = 1;

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

        public async Task<List<Book>> SearchBooksByTitleAsync(string searchTitle)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                   
                    context.Database.EnsureCreated();

                   
                    return await context.Books
                        .Include(b => b.Author) 
                        .Where(b => b.Title.ToLower().Contains(searchTitle.ToLower()))
                        .ToListAsync();
                }
            }
            catch (Exception ex)
            {
                var realMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Search failed: {realMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Book>(); 
            }
        }




        public async Task<List<string>> GetBooksByPageAsync (int pageNumber)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                                         .Include(b => b.Author)
                                         .OrderBy(b => b.BookID)
                                         .Skip((pageNumber - 1) * pageSize)
                                         .Take(pageSize)
                                         .Select(b => $"{b.Title} by {b.Author.Name}")
                                         .ToListAsync();

                return books;
            }
        }

        public async Task SaveBookWithHandlingAsync(string bookTitle, string authorName)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };

                    context.Books.Add(book);

                    await context.SaveChangesAsync();

                    MessageBox.Show("Book and Author saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
            }
        }

        public async Task ImportBooksFromTextFileAsync(string filePath)
        {
            try
            {
                if (!System.IO.File.Exists(filePath))
                {
                    MessageBox.Show("The selected file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var context = new BookstoreContext())
                {

                    context.Database.EnsureCreated();

                    using (var reader = new System.IO.StreamReader(filePath))
                    {
                        string line;
                        while ((line = await reader.ReadLineAsync()) != null)
                        {
                            if (string.IsNullOrWhiteSpace(line)) continue;

                            var parts = line.Split(',');
                            if (parts.Length == 2)
                            {
                                var title = parts[0].Trim();
                                var authorName = parts[1].Trim();

                                var author = new Author { Name = authorName };
                                var book = new Book { Title = title, Author = author };

                                context.Books.Add(book);
                            }
                        }
                    }

                    await context.SaveChangesAsync();
                    MessageBox.Show("All books imported and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                var realMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Import failed: {realMessage}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task ExportBookAsync(string filePath)
        {
            var books = await GetBooksByPageAsync (currentPage);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    await writer.WriteLineAsync(book);
                }
            }
        }

        public async Task RefreshBookListAsync()
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    context.Database.EnsureCreated();

                    var allBooks = await context.Books.Include(b => b.Author).ToListAsync();

                    listBoxBooks.DataSource = null;
                    listBoxBooks.DataSource = allBooks;
                    listBoxBooks.DisplayMember = "Title";
                }
            }
            catch (Exception ex)
            {
                var realMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Failed to refresh list: {realMessage}");
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

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookWithHandlingAsync(bookTitle, authorName);
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

        

        private async void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                openFileDialog.Title = "Select a Book List Text File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
              
                    await ImportBooksFromTextFileAsync(openFileDialog.FileName);

                    await RefreshBookListAsync();
                }
            }
        }

        private async void btnExportBooks_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Save Book List"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await ExportBookAsync(filePath);
                MessageBox.Show("Books exported successfully!");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTitle = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTitle))
            {
                MessageBox.Show("Please enter a book title to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Book> searchResults = await SearchBooksByTitleAsync(searchTitle);

            listBoxBooks.DataSource = null; 
            listBoxBooks.DataSource = searchResults;

            
            listBoxBooks.DisplayMember = "Title";
        }
    }
}
