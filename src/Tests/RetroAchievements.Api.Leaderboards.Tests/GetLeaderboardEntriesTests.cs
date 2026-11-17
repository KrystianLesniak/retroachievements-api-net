using RetroAchievements.Api.Requests.Leaderboards;

namespace RetroAchievements.Api.Leaderboards.Tests
{
    [TestFixture]
    public class GetLeaderboardEntriesTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetLeaderboardEntries_ReturnsProperResponse()
        {
            var responseMethodAsync = await HttpClient.GetLeaderboardEntriesAsync(5718);
            var responseMethodSync = HttpClient.GetLeaderboardEntries(5718);
            var responseAsync = await HttpClient.SendAsync(new GetLeaderboardEntriesRequest(5718));
            var responseSync = HttpClient.Send(new GetLeaderboardEntriesRequest(5718));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Results.Any());
                Assert.That(responseSync.Results.First().Rank, Is.EqualTo(1));
            });
        }

        [Test]
        public void GetLeaderboardEntriesRequest_ThrowsException_WhenArgumentsAreInvalid()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetLeaderboardEntriesRequest(5718, 0, 501);
            });
        }
    }
}
