using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users.Records;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetGameDataAndUserProgressTests
    {
        private string _topUserUsername = string.Empty;
        private GameProgress? _topUserLastPlayedGameId;

        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();


        [Test]
        [ApiTest]
        public async Task GetGameDataAndUserProgress_ReturnsProperResponse()
        {
            await SetupApiTestUser();

            var responseMethodAsync = await HttpClient.GetGameDataAndUserProgressAsync(_topUserLastPlayedGameId!.GameId, _topUserUsername);
            var responseMethodSync = HttpClient.GetGameDataAndUserProgress(_topUserLastPlayedGameId!.GameId, _topUserUsername);
            var responseAsync = await HttpClient.SendAsync(new GetGameDataAndUserProgressRequest(_topUserLastPlayedGameId!.GameId, _topUserUsername));
            var responseSync = HttpClient.Send(new GetGameDataAndUserProgressRequest(_topUserLastPlayedGameId!.GameId, _topUserUsername));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.AchievementsCount, Is.EqualTo(_topUserLastPlayedGameId.GameAchievementsCount));
                Assert.That(responseSync.ConsoleName, Is.EqualTo(_topUserLastPlayedGameId.ConsoleName));
                Assert.That(responseSync.Title, Is.EqualTo(_topUserLastPlayedGameId.Title));
                Assert.That(responseSync.Achievements, Has.Count.EqualTo(_topUserLastPlayedGameId.GameAchievementsCount));
            });
        }

        private async Task SetupApiTestUser()
        {
            var topTenUsers = await ApiLazyTestData.GetTopTenUsers(HttpClient);

            _topUserUsername = topTenUsers.First(x => x.TotalPoints == topTenUsers.Max(x => x.TotalPoints)).Username;
            _topUserLastPlayedGameId = (await ApiLazyTestData.GetUserAllGamesProgress(HttpClient, _topUserUsername)).Items.First();
        }

        [Test]
        public void GetUserAllGamesProgressRequest_ThrowsException_WhenArgumentsAreWhitespaceOrNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetGameDataAndUserProgressRequest(0, null);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetGameDataAndUserProgressRequest(0, string.Empty);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });
        }
    }
}
