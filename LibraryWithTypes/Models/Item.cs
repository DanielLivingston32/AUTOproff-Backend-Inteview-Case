namespace LibraryWithTypes.Models
{
    /// <summary>
    /// Abstract class representing the basic structure of any item that can be borrowed from a library,
    /// such as a Book, CD, DVD, or Blu-ray disc.
    /// </summary>
	public abstract class Item
	{
        public string Title { get; set; }
        public string ISBN { get; set; }
        public ItemType Type { get; set; }
    }
}