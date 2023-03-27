namespace LibraryWithTypes.Models
{
    /// <summary>
    /// Abstract class with properties specific to MediaTypes.
    /// </summary>
    public abstract class Track
    {
        public string Title { get; set; }
        public int Duration { get; set; }
    }
}

