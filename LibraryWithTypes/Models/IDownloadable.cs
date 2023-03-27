namespace LibraryWithTypes.Models
{
	/// <summary>
	/// Interface to be implemented by all downloadable types. 
	/// </summary>
	public interface IDownloadable
	{
		/// <summary>
		/// Method to download data of the specific type.
		/// </summary>
		void Download();
	}
}

