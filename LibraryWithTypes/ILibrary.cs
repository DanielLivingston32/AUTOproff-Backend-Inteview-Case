using LibraryWithTypes.Models;

namespace LibraryWithTypes
{
	/// <summary>
	/// Represents the library and contains the business logic for the same.
	/// </summary>
	public interface ILibrary
	{
		/// <summary>
		/// Adds Library item to the Library.
		/// </summary>
		/// <param name="item">The item to be added to the library.</param>
		public void AddLibraryItem(Item item);

		/// <summary>
		/// Gets a specific library item by ISBN.
		/// </summary>
		/// <param name="ISBN">The unique ISBN string of the item to retrieve.</param>
		public Item GetLibraryItem(string ISBN);

		/// <summary>
		/// Removes a specific library item by ISBN.
		/// </summary>
		/// <param name="ISBN">The unique ISBN string of the item to remove.</param>
        public void RemoveLibraryItem(string ISBN);

		/// <summary>
		/// Gets all the Library items.
		/// </summary>
        public void GetAllLibraryItem();
    }
}

