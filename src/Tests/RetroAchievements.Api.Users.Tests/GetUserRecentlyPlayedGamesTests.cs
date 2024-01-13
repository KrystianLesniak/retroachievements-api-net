using RetroAchievements.Api.Requests.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUserRecentlyPlayedGamesTests
    {
        private string _topUserUsername = string.Empty;

        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUserRecentlyPlayedGames_ReturnsProperResponse()
        {
            await SetupApiTestUserName();

            var responseMethodAsync = await HttpClient.GetUserRecentlyPlayedGamesAsync(_topUserUsername);
            var responseMethodSync = HttpClient.GetUserRecentlyPlayedGames(_topUserUsername);
            var responseAsync = await HttpClient.SendAsync(new GetUserRecentlyPlayedGamesRequest(_topUserUsername));
            var responseSync = HttpClient.Send(new GetUserRecentlyPlayedGamesRequest(_topUserUsername));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Items.Any());
            });
        }

        private async Task SetupApiTestUserName()
        {
            var topTenUsers = await ApiLazyTestData.GetTopTenUsers(HttpClient);

            _topUserUsername = topTenUsers.First(x => x.TotalPoints == topTenUsers.Max(x => x.TotalPoints)).Username;
        }

        [Test]
        public void GetUserAwardsRequest_ThrowsException_WhenArgumentsAreWhitespaceOrNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetUserRecentlyPlayedGamesRequest(null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });

            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserRecentlyPlayedGamesRequest(string.Empty);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserRecentlyPlayedGamesRequest(string.Empty, 0, 51);
            });
        }
    }
}