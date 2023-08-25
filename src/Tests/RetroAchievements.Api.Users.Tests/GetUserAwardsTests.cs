using RetroAchievements.Api.Requests.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUserAwardsTests
    {
        private string _topUserUsername = string.Empty;

        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUserAwardsTests_ReturnsProperResponse()
        {
            await SetupApiTestUserName();

            var responseMethodAsync = await HttpClient.GetUserAwardsAsync(_topUserUsername);
            var responseMethodSync = HttpClient.GetUserAwards(_topUserUsername);
            var responseAsync = await HttpClient.SendAsync(new GetUserAwardsRequest(_topUserUsername));
            var responseSync = HttpClient.Send(new GetUserAwardsRequest(_topUserUsername));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.VisibleUserAwards.Any());
                Assert.That(responseSync.TotalAwardsCount, Is.GreaterThan(0));
            });
        }

        private async Task SetupApiTestUserName()
        {
            var topTenUsers = await ApiLazyTestData.GetTopTenUsers(HttpClient);

            _topUserUsername = topTenUsers.First(x => x.TotalPoints == topTenUsers.Max(x => x.TotalPoints)).Username;
        }

        [Test]
        public void GetUserAwardsRequest_ThrowsException_WhenArgumentsAreWhitespaceOrNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetUserAwardsRequest(null);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserAwardsRequest(string.Empty);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });
        }
    }
}