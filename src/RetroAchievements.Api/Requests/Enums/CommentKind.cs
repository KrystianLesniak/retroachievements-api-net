namespace RetroAchievements.Api.Requests.Enums
{
    /// <summary>
    /// Kind of entity the comments are attached to.
    /// </summary>
    public enum CommentKind
    {
        /// <summary>
        /// Game comments
        /// </summary>
        Game = 1,
        /// <summary>
        /// Achievement comments
        /// </summary>
        Achievement = 2,
        /// <summary>
        /// User wall comments
        /// </summary>
        User = 3,
    }
}
