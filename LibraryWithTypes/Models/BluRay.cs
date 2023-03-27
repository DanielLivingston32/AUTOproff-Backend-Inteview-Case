namespace LibraryWithTypes.Models
{
    /// <summary>
    /// Class to represent a library item BluRay
    /// </summary>
    public class BluRay : MediaItem
    {
        public List<VideoTrack> Tracks { get; set; }
    }
}

