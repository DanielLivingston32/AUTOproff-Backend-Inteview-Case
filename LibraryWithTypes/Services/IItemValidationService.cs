using LibraryWithTypes.Models;

namespace LibraryWithTypes.Services
{
	/// <summary>
	/// Service to validate the item to be inserted
	/// </summary>
	public interface IItemValidationService
	{
		/// <summary>
		/// Validates the passed item.
		/// </summary>
		void Validate(Item item);
	}
}

