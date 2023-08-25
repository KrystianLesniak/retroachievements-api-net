using RetroAchievements.Api.Requests.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUserClaimsTests
    {
        private string _topUserUsername = string.Empty;

        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUserClaimsRequest_ReturnsProperResponse()
        {
            //TODO: Find some user that indeed have claims ;)
            await SetupApiTestUserName();

            var responseMethodAsync = await HttpClient.GetUserClaimsAsync(_topUserUsername);
            var responseMethodSync = HttpClient.GetUserClaims(_topUserUsername);
            var responseAsync = await HttpClient.SendAsync(new GetUserClaimsRequest(_topUserUsername));
            var responseSync = HttpClient.Send(new GetUserClaimsRequest(_topUserUsername));

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
        public void GetUserClaimsRequest_ThrowsException_WhenArgumentsAreWhitespaceOrNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetUserClaimsRequest(null);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserClaimsRequest(string.Empty);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });
        }
    }
}