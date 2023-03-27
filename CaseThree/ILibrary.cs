using CaseThree.Models;

namespace LibraryWithTypes
{
    /// <summary>
    /// Interface representing the structure of the library.
    /// </summary>
	public interface ILibrary
	{
        /// <summary>
        /// Adds a book to the library.
        /// </summary>
        /// <param name="book">The book to be added to the library.</param>
        /// <param name="location">The location of the book to be added.</param>
        public void AddBook(Book book, BookLocation location);

        /// <summary>
        /// Finds a specific book based on ISBN.
        /// </summary>
        /// <param name="isbn">The ISBN of the book passed as a string.</param>
        /// <returns>An object instance of <cref="Book"/> on successful match. Else, returns a
        /// null value.</returns>
        public Book FindBook(int isbn);

        /// <summary>
        /// Finds the location of the book based on ISBN.
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>An object instance of <cref="BookLocation" /> on successful match.
        /// Else, returns a null value.</returns>
        public BookLocation FindBookLocation(int isbn);

        /// <summary>
        /// Lists the inventory in the library based on location.
        /// </summary>
        /// <param name="location">The location whose inventory needs to be
        /// listed.</param>
        /// <returns>A HashSet of Books present in the location.</returns>
        public HashSet<Book> InventoryList(BookLocation location);
    }
}

