using RetroAchievements.Api.Requests.Games;

namespace RetroAchievements.Api.Games.Tests
{
    [TestFixture]
    public class GetGameHashesTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetGameHashes_ReturnsProperResponse()
        {
            var responseMethodAsync = await HttpClient.GetGameHashesAsync(14402);
            var responseMethodSync = HttpClient.GetGameHashes(14402);
            var responseAsync = await HttpClient.SendAsync(new GetGameHashesRequest(14402));
            var responseSync = HttpClient.Send(new GetGameHashesRequest(14402));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Results.Any());
                Assert.That(responseSync.Results.All(x => x.Md5.Length == 32));
            });
        }
    }
}
