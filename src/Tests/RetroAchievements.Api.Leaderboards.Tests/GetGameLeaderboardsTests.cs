using RetroAchievements.Api.Requests.Leaderboards;

namespace RetroAchievements.Api.Leaderboards.Tests
{
    [TestFixture]
    public class GetGameLeaderboardsTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetGameLeaderboards_ReturnsProperResponse()
        {
            var responseMethodAsync = await HttpClient.GetGameLeaderboardsAsync(14402);
            var responseMethodSync = HttpClient.GetGameLeaderboards(14402);
            var responseAsync = await HttpClient.SendAsync(new GetGameLeaderboardsRequest(14402));
            var responseSync = HttpClient.Send(new GetGameLeaderboardsRequest(14402));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Results.Any());
            });
        }

        [Test]
        public void GetGameLeaderboardsRequest_ThrowsException_WhenArgumentsAreInvalid()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetGameLeaderboardsRequest(14402, 0, 501);
            });
        }
    }
}
