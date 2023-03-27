namespace CaseTwo.Models
{
    public class Book
    {
        public List<string> Authors = new List<string>();
        public string Title; // Missing property in question. Took the liberty to add it.
        public string Publisher;
        public int PublicationYear;
        public int NumberOfPages;
    }
}

