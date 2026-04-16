namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Book Book1 = new Magazine
            {
                Title = "Tech Weekly",
                Author = "John Doe",
                IssueNumber = 45
            };

            MessageBox.Show(Book1.GetInfo());
        }
    }


    public class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }

		public virtual string GetInfo()
		{
			return $"{Title} by {Author}";
		}
	}

	public class Magazine : Book
	{
        public int IssueNumber { get; set; }

        public virtual string GetInfo()
        {
            return $"{Title} - Issue {IssueNumber}";
        }
		
	}
	
		
    public class Ebook : Book
    {
        public double FileSizeMB { get; set; }

        public virtual string GetInfo()
        {
            return $"{Title} [{FileSizeMB} MB]";
        }
    }
	


}
