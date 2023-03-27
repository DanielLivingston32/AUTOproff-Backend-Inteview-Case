namespace LibraryWithTypes.Models
{
    /// <summary>
    /// Abstract class representing the basic structure of any media item that can be borrowed from a library,
    /// such as a CD, DVD, or Blu-ray disc.
    /// </summary>
    public abstract class MediaItem : Item
    {
        public string Artist { get; set; }
        public int Duration { get; set; }
    }
}

