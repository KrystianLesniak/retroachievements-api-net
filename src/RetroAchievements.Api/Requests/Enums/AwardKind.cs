namespace RetroAchievements.Api.Requests.Enums
{
    /// <summary>
    /// Kind of game award.
    /// </summary>
    public enum AwardKind
    {
        /// <summary>
        /// Beaten in softcore mode
        /// </summary>
        BeatenSoftcore = 0,
        /// <summary>
        /// Beaten in hardcore mode
        /// </summary>
        BeatenHardcore = 1,
        /// <summary>
        /// Completed (softcore mastery)
        /// </summary>
        Completed = 2,
        /// <summary>
        /// Mastered (hardcore)
        /// </summary>
        Mastered = 3,
    }
}
