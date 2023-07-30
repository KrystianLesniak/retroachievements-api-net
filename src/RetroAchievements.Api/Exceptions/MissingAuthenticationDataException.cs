namespace RetroAchievements.Api.Exceptions
{
    internal class MissingAuthenticationDataException : Exception
    {
        public MissingAuthenticationDataException() :
            base(
                $"No Authentication Data for RetroAchievements Web API provided. Please provide API and username via {nameof(RetroAchievementsHttpClient)} constructor or as parameter when calling a request.")
        { }

    }
}
