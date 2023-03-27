using LibraryWithTypes.Models;
using LibraryWithTypes.Services;

namespace LibraryWithTypes
{
	/// <inheritdoc cref="ILibrary"/>
	public class Library : ILibrary
    {
		public IList<Item> LibraryItems { get; private set; }
		private IItemValidationService _itemValidationService { get; }

		public Library(IItemValidationService itemValidationService) {
			_itemValidationService = itemValidationService;
		}

		/// <inheritdoc cref="ILibrary.AddLibraryItem(Item)"/>
		public void AddLibraryItem(Item item) {
			if(item == null) {
				throw new ArgumentNullException(nameof(item));
			}

			// Validate Item
			_itemValidationService.Validate(null); // Temporary Argument

			// Add Item
			LibraryItems.Add(item);
		}

        /// <inheritdoc cref="ILibrary.RemoveLibraryItem(string)"/>
        public void RemoveLibraryItem(string ISBN) {
			// Code
		}

        /// <inheritdoc cref="ILibrary.GetAllLibraryItem()"/>
        public void GetAllLibraryItem() {
			// Code
		}

        /// <inheritdoc cref="ILibrary.GetLibraryItem(string)"/>
        public Item GetLibraryItem(string ISBN) {
			// Code
			Item result = null; // Temporary

			return result;
		}
    }
}

