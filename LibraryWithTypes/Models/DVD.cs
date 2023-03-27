namespace LibraryWithTypes.Models
{
    /// <summary>
    /// Class to represent a library item DVD.
    /// </summary>
    public class DVD : MediaItem
    {
        public List<VideoTrack> Tracks { get; set; }
    }
}

