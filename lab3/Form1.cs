namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"Title: {Title} by {Author}";
            }
        }

        public class Ebook : Book
        {
            public string FileFormat { get; set; }
            public override string GetInfo()
            {
                return $"[E-book] {Title} ({FileFormat})";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"Title: {Title} - Issue: {IssueNumber}";
            }
        }

        public class Textbook : Book
        {
            public string Subject { get; set; }
            public override string GetInfo()
            {
                return $"[Textbook] {Title} - Subject: {Subject}";
            }
        }

        public class AudioBook : Book
        {
            public string Narrator { get; set; }
            public double Duration { get; set; } // Duration in hours
            public override string GetInfo()
            {
                return $"[AudioBook] {Title} - Naratted by: {Narrator}, {Duration} hours";
            }
        }

        private void DisplayLibraryInfo(Book[] booksToDisplay)
        {
            listBox1.Items.Clear();

            foreach (Book item in booksToDisplay)
            {
                listBox1.Items.Add(item.GetInfo());
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] library = new Book[]
            {
                new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
                new Ebook { Title = "1984", Author = "George Orwell", FileFormat = "PDF" },
                new Magazine { Title = "National Geographic", Author = "Various", IssueNumber = 202 },
                new Textbook { Title = "Introduction to Algorithms", Author = "Cormen et al.", Subject = "Computer Science" },
                new AudioBook { Title = "The Hobbit", Author = "J.R.R. Tolkien", Narrator = "Andy Serkis", Duration = 11.5 }
            };
            DisplayLibraryInfo(library);
        }
    }
}
