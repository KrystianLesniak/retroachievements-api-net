using RetroAchievements.Api.Requests.Leaderboards;

namespace RetroAchievements.Api.Leaderboards.Tests
{
    [TestFixture]
    public class GetUserGameLeaderboardsTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUserGameLeaderboards_ReturnsProperResponse()
        {
            var responseMethodAsync = await HttpClient.GetUserGameLeaderboardsAsync(1, "Scott");
            var responseMethodSync = HttpClient.GetUserGameLeaderboards(1, "Scott");
            var responseAsync = await HttpClient.SendAsync(new GetUserGameLeaderboardsRequest(1, "Scott"));
            var responseSync = HttpClient.Send(new GetUserGameLeaderboardsRequest(1, "Scott"));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Results.Any());
                Assert.That(responseSync.Results.All(x => x.UserEntry.Username == "Scott"));
            });
        }

        [Test]
        public void GetUserGameLeaderboardsRequest_ThrowsException_WhenArgumentsAreInvalid()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetUserGameLeaderboardsRequest(1, null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserGameLeaderboardsRequest(1, string.Empty);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserGameLeaderboardsRequest(1, "Scott", 0, 501);
            });
        }
    }
}
