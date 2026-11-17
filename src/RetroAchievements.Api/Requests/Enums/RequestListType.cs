namespace RetroAchievements.Api.Requests.Enums
{
    /// <summary>
    /// Type of set requests list.
    /// </summary>
    public enum RequestListType
    {
        /// <summary>
        /// Only active (not yet fulfilled) set requests
        /// </summary>
        ActiveRequests = 0,
        /// <summary>
        /// All set requests
        /// </summary>
        AllRequests = 1,
    }
}
