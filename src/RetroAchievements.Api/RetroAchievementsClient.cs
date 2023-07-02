namespace RetroAchievements.Api
{
    public class RetroAchievementsClient : IDisposable
    {
        internal HttpClient HttpClient { get; private set; } = new HttpClient();

        public void Dispose()
        {
            HttpClient.Dispose();
            GC.SuppressFinalize(this); //informing GC that this object was cleaned up fully.
        }
    }
}