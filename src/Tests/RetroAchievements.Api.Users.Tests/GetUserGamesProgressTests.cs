using RetroAchievements.Api.Requests.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUserGamesProgressTests
    {
        private string _topUserUsername = string.Empty;
        private IEnumerable<int> _topUserFiveGameIds = Array.Empty<int>();

        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();


        [Test]
        [ApiTest]
        public async Task GetUserProgress_ReturnsProperResponse()
        {
            await SetupApiTestUserName();

            var responseMethodAsync = await HttpClient.GetUserGamesProgressAsync(_topUserUsername, _topUserFiveGameIds);
            var responseMethodSync = HttpClient.GetUserGamesProgress(_topUserUsername, _topUserFiveGameIds);
            var responseAsync = await HttpClient.SendAsync(new GetUserGamesProgressRequest(_topUserUsername, _topUserFiveGameIds));
            var responseSync = HttpClient.Send(new GetUserGamesProgressRequest(_topUserUsername, _topUserFiveGameIds));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Items.Any());
                Assert.That(responseSync.Items.Keys.All(x => _topUserFiveGameIds.Contains(x)));
            });
        }

        private async Task SetupApiTestUserName()
        {
            var topTenUsers = (await HttpClient.GetTopTenUsersAsync()).Items;

            _topUserUsername = topTenUsers.First(x => x.TotalPoints == topTenUsers.Max(x => x.TotalPoints)).Username;
            _topUserFiveGameIds = (await HttpClient.GetUserAllGamesProgressAsync(_topUserUsername)).Items.Take(5).Select(x => x.GameId);
        }

        [Test]
        public void GetUserGamesProgressRequest_ThrowsException_WhenArgumentsAreEmptyOrNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetUserGamesProgressRequest("someUsername", null);
            });

            Assert.Throws<ArgumentNullException>(() =>
            {
                _ = new GetUserGamesProgressRequest(null, new List<int> {0, 1});
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });

            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserGamesProgressRequest(_topUserUsername, Enumerable.Empty<int>());
            });
        }
    }
}