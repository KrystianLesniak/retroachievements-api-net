using RetroAchievements.Api.Requests.Consoles;

namespace RetroAchievements.Api.Consoles.Tests
{
    [TestFixture]
    public class GetConsoleIdsActiveGameSystemsTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetConsoleIdsActiveGameSystems_ReturnsProperResponse()
        {
            var responseMethodAsync = await HttpClient.GetConsoleIdsAsync(true, true);
            var responseMethodSync = HttpClient.GetConsoleIds(true, true);
            var responseAsync = await HttpClient.SendAsync(new GetConsoleIdsRequest(true, true));
            var responseSync = HttpClient.Send(new GetConsoleIdsRequest(true, true));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Items.Any());
                Assert.That(responseSync.Items.All(x => x.IsActive && x.IsGameSystem));
            });
        }
    }
}
