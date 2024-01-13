using RetroAchievements.Api.Requests.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUserRankAndPointsTests
    {
        private string _topUserUsername = string.Empty;

        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUserRankAndPoints_ReturnsProperResponse()
        {
            await SetupApiTestUserName();

            var responseMethodAsync = await HttpClient.GetUserRankAndPointsAsync(_topUserUsername);
            var responseMethodSync = HttpClient.GetUserRankAndPoints(_topUserUsername);
            var responseAsync = await HttpClient.SendAsync(new GetUserRankAndPointsRequest(_topUserUsername));
            var responseSync = HttpClient.Send(new GetUserRankAndPointsRequest(_topUserUsername));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
            });
        }

        private async Task SetupApiTestUserName()
        {
            var topTenUsers = await ApiLazyTestData.GetTopTenUsers(HttpClient);

            _topUserUsername = topTenUsers.First(x => x.TotalPoints == topTenUsers.Max(x => x.TotalPoints)).Username;
        }

        [Test]
        public void GetUserRankAndPointsRequest_ThrowsException_WhenArgumentsAreWhitespaceOrNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetUserRankAndPointsRequest(null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });

            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserRankAndPointsRequest(string.Empty);
            });
        }
    }
}