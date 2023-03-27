namespace LibraryWithTypes.Models
{
    /// <summary>
    /// Class to represent a library item CD.
    /// </summary>
    public class CD : MediaItem
    {
        public List<AudioTrack> Tracks { get; set; }
    }
}

