using RetroAchievements.Api.Requests.Games;

namespace RetroAchievements.Api.Games.Tests
{
    [TestFixture]
    public class GetGameExtendedDataUnofficialTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetGameExtendedDataUnofficial_ReturnsProperResponse()
        {
            var responseMethodAsync = await HttpClient.GetGameExtendedDataAsync(1, true);
            var responseMethodSync = HttpClient.GetGameExtendedData(1, true);
            var responseAsync = await HttpClient.SendAsync(new GetGameExtendedDataRequest(1, true));
            var responseSync = HttpClient.Send(new GetGameExtendedDataRequest(1, true));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Id, Is.EqualTo(1));
                Assert.That(responseSync.Achievements.Any());
            });
        }
    }
}
