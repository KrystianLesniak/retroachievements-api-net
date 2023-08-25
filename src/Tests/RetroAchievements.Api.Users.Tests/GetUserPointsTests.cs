using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUserPointsTests
    {
        private User? _topUserUsername;

        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUserPointsRequest_ReturnsProperResponse()
        {
            await SetupApiTestUserName();

            var responseMethodAsync = await HttpClient.GetUserPointsAsync(_topUserUsername!.Username);
            var responseMethodSync = HttpClient.GetUserPoints(_topUserUsername.Username);
            var responseAsync = await HttpClient.SendAsync(new GetUserPointsRequest(_topUserUsername.Username));
            var responseSync = HttpClient.Send(new GetUserPointsRequest(_topUserUsername.Username));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(_topUserUsername.TotalPoints, Is.EqualTo(responseSync.HardcorePoints));
            });
        }

        private async Task SetupApiTestUserName()
        {
            var topTenUsers = await ApiLazyTestData.GetTopTenUsers(HttpClient);

            _topUserUsername = topTenUsers.First(x => x.TotalPoints == topTenUsers.Max(x => x.TotalPoints));
        }

        [Test]
        public void GetUserPointsRequest_ThrowsException_WhenArgumentsAreWhitespaceOrNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetUserPointsRequest(null);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserPointsRequest(string.Empty);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });
        }
    }
}