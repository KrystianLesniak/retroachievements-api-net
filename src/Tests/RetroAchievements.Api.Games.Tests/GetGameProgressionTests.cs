using RetroAchievements.Api.Requests.Games;

namespace RetroAchievements.Api.Games.Tests
{
    [TestFixture]
    public class GetGameProgressionTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetGameProgression_ReturnsProperResponse()
        {
            var responseMethodAsync = await HttpClient.GetGameProgressionAsync(228, true);
            var responseMethodSync = HttpClient.GetGameProgression(228, true);
            var responseAsync = await HttpClient.SendAsync(new GetGameProgressionRequest(228, true));
            var responseSync = HttpClient.Send(new GetGameProgressionRequest(228, true));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Id, Is.EqualTo(228));
                Assert.That(responseSync.Achievements.Any());
            });
        }
    }
}
