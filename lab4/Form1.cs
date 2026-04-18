namespace lab4
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {

            public Book() { }
            public string Title { get; set; } = string.Empty;
            public string Author { get; set; } = string.Empty;

   
            public Book(string title, string author)
            {
                Title = title;
                Author = author;
            }

            public virtual string GetDescription()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {

            public Magazine() { }
            public int IssueNumber { get; set; }

            public Magazine(string title, int issue) : base(title, "Unknown")
            {
                IssueNumber = issue;
            }
            public override string GetDescription()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class EBook : Book
        {
            public EBook() { }
            public double FileSizeMB { get; set; }

            public EBook(string title, string author, double fileSizeMB) : base(title, author)
            {
                FileSizeMB = fileSizeMB;
            }


            public override string GetDescription()
            {
                return $"{Title} (Ebook, {FileSizeMB}MB)";
            }

        }

        public class Textbook : Book
        {
            public string Subject { get; set; }


            public Textbook(string title, string author, string subject) : base(title, author)
            {
                Subject = subject;
            }

            public override string GetDescription()
            {
                return $"Textbook: {Title} by {Author} (Subject: {Subject})";
            }
        }

        public class AudioBook : Book
        {
            public double DurationHours { get; set; }
            public AudioBook(string title, string author, double durationHours) : base(title, author)
            {
                DurationHours = durationHours;
            }
            public override string GetDescription()
            {
                return $"Audiobook: {Title} by {Author} (Duration: {DurationHours} hours)";
            }
        }
        public void ProccessBook(Book[] BookInventory, ListBox lbBooks)
        {
            lbBooks.Items.Clear();

            if (BookInventory == null)
            {
                lbBooks.Items.Add("No Books Available");
                return;
            }

            foreach (var book in BookInventory)
            {
                string info = book.GetDescription();

                lbBooks.Items.Add(info);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Book[] myBooks = new Book[]
            {
                new Book("The Great Gatsby", "F.Scott Fitzgerald"),
                new Magazine("Vogue", 45),
                new EBook("Digital Minimalism","Cal Newport", 1.5),
                new Textbook("Introduction to Algorithms", "Cormen, Leiserson, Rivest, Stein", "Computer Science"),
                new AudioBook("The Hobbit", "J.R.R. Tolkien", 11.5)
            };

            ProccessBook(myBooks, lbBooks);
        }
    }
}
	