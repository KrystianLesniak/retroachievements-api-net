using RetroAchievements.Api.Requests.Comments;
using RetroAchievements.Api.Requests.Enums;
using RetroAchievements.Api.Response.Comments;

namespace RetroAchievements.Api
{
    /// <summary>
    /// Class with extension methods for calling APIs from group "Comments"
    /// </summary>
    public static class CommentsApi
    {
        #region GetComments
        /// <inheritdoc cref="GetCommentsRequest(int, CommentKind, int, int)"/>
        public static async Task<GetCommentsResponse> GetCommentsAsync(this IRetroAchievementsHttpClient client, int identifier, CommentKind kind, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetCommentsRequest(identifier, kind, offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetCommentsRequest(int, CommentKind, int, int)"/>
        public static GetCommentsResponse GetComments(this IRetroAchievementsHttpClient client, int identifier, CommentKind kind, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetCommentsRequest(identifier, kind, offset, count), authenticationData);
        }

        /// <inheritdoc cref="GetCommentsRequest(string, int, int)"/>
        public static async Task<GetCommentsResponse> GetCommentsAsync(this IRetroAchievementsHttpClient client, string username, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetCommentsRequest(username, offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetCommentsRequest(string, int, int)"/>
        public static GetCommentsResponse GetComments(this IRetroAchievementsHttpClient client, string username, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetCommentsRequest(username, offset, count), authenticationData);
        }
        #endregion GetComments
    }
}
