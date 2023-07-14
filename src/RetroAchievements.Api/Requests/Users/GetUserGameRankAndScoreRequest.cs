using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get an user High Score data for a game.
    /// </summary>
    public record GetUserGameRankAndScoreRequest : IRetroAchievementsRequest<GetUserGameRankAndScoreResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserGameRankAndScore";


        ///<inheritdoc cref="GetUserGameRankAndScoreRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        public GetUserGameRankAndScoreRequest(string username, int gameId)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));

            Username = username;
            GameId = gameId;
        }

        /// <summary>
        /// Unique identifier of game.
        /// </summary>
        [ApiInputKey("g")]
        public int GameId { get; init; }

        /// <summary>
        /// Username of user.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
