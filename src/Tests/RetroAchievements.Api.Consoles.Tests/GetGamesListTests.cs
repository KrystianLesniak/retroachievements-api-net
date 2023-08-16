using RetroAchievements.Api.Requests.Consoles;

namespace RetroAchievements.Api.Consoles.Tests
{
    [TestFixture]
    public class GetGamesListTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetGamesList_ReturnsProperResponse()
        {
            int consoleId = 1;

            var responseMethodAsync = await HttpClient.GetGamesListAsync(consoleId);
            var responseMethodSync = HttpClient.GetGamesList(consoleId);
            var responseAsync = await HttpClient.SendAsync(new GetGamesListRequest(consoleId));
            var responseSync = HttpClient.Send(new GetGamesListRequest(consoleId));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Items.Any());
            });
        }

        [Test]
        [ApiTest]
        public async Task GetGamesList_WithoutHashes_ReturnResponseWithoutHashes()
        {
            int consoleId = 1;

            var response = await HttpClient.GetGamesListAsync(consoleId);

            Assert.Multiple(() =>
            {
                Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(response.FailedResponseString, Is.EqualTo(null));
                Assert.That(response.Items.Any());
                Assert.That(response.Items.All(x => !x.Hashes.Any()));
            });
        }

        [Test]
        [ApiTest]
        public async Task GetGamesList_WithHashes_ReturnResponseWithHashes()
        {
            int consoleId = 1;

            var response = await HttpClient.GetGamesListAsync(consoleId, getHashes: true);

            Assert.Multiple(() =>
            {
                Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(response.FailedResponseString, Is.EqualTo(null));
                Assert.That(response.Items.Any());
                Assert.That(response.Items.All(x => x.Hashes.All(x => x != string.Empty)));
            });
        }

        [Test]
        [ApiTest]
        public async Task GetGamesList_OnlyWithAchievements_ReturnResponseWithAchievementsOnly()
        {
            int consoleId = 1;

            var response = await HttpClient.GetGamesListAsync(consoleId, onlyWithAchievements: true);

            Assert.Multiple(() =>
            {
                Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(response.FailedResponseString, Is.EqualTo(null));
                Assert.That(response.Items.All(x=> x.AchievementsCount > 0));
            });
        }

        [Test]
        [ApiTest]
        public async Task GetGamesList_ReturnsEmptyResponse()
        {
            int consoleId = 100000000;

            var responseMethodAsync = await HttpClient.GetGamesListAsync(consoleId);
            var responseMethodSync = HttpClient.GetGamesList(consoleId);
            var responseAsync = await HttpClient.SendAsync(new GetGamesListRequest(consoleId));
            var responseSync = HttpClient.Send(new GetGamesListRequest(consoleId));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(!responseMethodSync.Items.Any());
            });
        }
    }
}