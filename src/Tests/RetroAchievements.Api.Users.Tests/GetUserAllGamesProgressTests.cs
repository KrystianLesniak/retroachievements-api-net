using RetroAchievements.Api.Requests.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUserAllGamesProgressTests
    {
        private string _topUserUsername = string.Empty;

        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUserAllGamesProgress_ReturnsProperResponse()
        {
            await SetupApiTestUserName();

            var responseMethodAsync = await HttpClient.GetUserAllGamesProgressAsync(_topUserUsername);
            var responseMethodSync = HttpClient.GetUserAllGamesProgress(_topUserUsername);
            var responseAsync = await HttpClient.SendAsync(new GetUserAllGamesProgressRequest(_topUserUsername));
            var responseSync = HttpClient.Send(new GetUserAllGamesProgressRequest(_topUserUsername));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Items.Any());
            });
        }

        private async Task SetupApiTestUserName()
        {
            var topTenUsers = await ApiLazyTestData.GetTopTenUsers(HttpClient);

            _topUserUsername = topTenUsers.First(x => x.TotalPoints == topTenUsers.Max(x => x.TotalPoints)).Username;
        }

        [Test]
        public void GetUserAllGamesProgressRequest_ThrowsException_WhenArgumentsAreWhitespaceOrNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetUserAllGamesProgressRequest(null);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserAllGamesProgressRequest(string.Empty);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });
        }
    }
}