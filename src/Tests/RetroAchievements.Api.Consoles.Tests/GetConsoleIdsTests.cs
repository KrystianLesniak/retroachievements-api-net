using RetroAchievements.Api.Requests.Consoles;

namespace RetroAchievements.Api.Consoles.Tests
{
    [TestFixture]
    public class GetConsoleIdsTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        public async Task GetConsoleIds_ReturnsProperResponse()
        {
            var responseMethodAsync = await HttpClient.GetConsoleIdsAsync();
            var responseMethodSync = HttpClient.GetConsoleIds();
            var responseAsync = await HttpClient.SendAsync(new GetConsoleIdsRequest());
            var responseSync = HttpClient.Send(new GetConsoleIdsRequest());

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Items.Any());
                Assert.That(responseSync.Items.Any(x=> x.Id == 1));
            });
        }
    }
}