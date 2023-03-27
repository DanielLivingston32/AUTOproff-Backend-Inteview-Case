using CaseTwo.Models;

namespace CaseTwo {
    public class Library
    {
        private List<Book> books = new List<Book>();

        public List<Book> ReadBooks(string input)
        {
            List<Book> result = new List<Book>();
            string[] lines = input.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Book currentBook = null;
            foreach (string line in lines)
            {
                if (line.StartsWith("Book:"))
                {
                    if (currentBook != null)
                    {
                        result.Add(currentBook);
                    }
                    currentBook = new Book();
                }
                else if (currentBook != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();
                        switch (key)
                        {
                            case "Author":
                                currentBook.Authors.Add(value);
                                break;
                            case "Title":
                                currentBook.Title = value;
                                break;
                            case "Publisher":
                                currentBook.Publisher = value;
                                break;
                            case "Published":
                                int.TryParse(value, out currentBook.PublicationYear);
                                break;
                            case "NumberOfPages":
                                int.TryParse(value, out currentBook.NumberOfPages);
                                break;
                        }
                    }
                }
            }
            if (currentBook != null)
            {
                result.Add(currentBook);
            }
            books = result;
            return result;
        }

        public List<Book> FindBooks(string searchString)
        {
            List<Book> result = new List<Book>();
            List<string> andQueries = searchString.Split(new[] { " & " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (Book book in books)
            {
                bool matches = true;
                foreach (string query in andQueries)
                {
                    if (!MatchesQuery(book, query))
                    {
                        matches = false;
                        break;
                    }
                }
                if (matches)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        private bool MatchesQuery(Book book, string query)
        {
            bool result = false;
            if (query.StartsWith("*") && query.EndsWith("*") && query.Length > 2)
            {
                string pattern = query.Substring(1, query.Length - 2).ToLowerInvariant();
                result = (book.Authors.Any(a => a.ToLowerInvariant().Contains(pattern)) ||
                          book.Title.ToLowerInvariant().Contains(pattern) ||
                          book.Publisher.ToLowerInvariant().Contains(pattern) ||
                          book.PublicationYear.ToString().Contains(pattern));
            }
            return result;
        }
    }

}