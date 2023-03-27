namespace LibraryWithTypes.Models
{
    /// <summary>
    /// Class to represent a library item book. 
    /// </summary>
    public class Book : Item
    {
        public List<string> Authors = new List<string>();
        public string Publisher;
        public int PublicationYear;
        public int NumberOfPages;
    }
}

