namespace LibraryWithTypes.Models
{
    public class VideoTrack : IDownloadable
    {
        // Properties to store and download video track

        /// <inheritdoc cref="IDownloadable.Download"/>
        public void Download() {
            // Download logic
        }
    }
}