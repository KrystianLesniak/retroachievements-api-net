using RetroAchievements.Api.Requests.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUserProfileTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUserProfile_ReturnsProperResponse()
        {
            var topTenUsers = await ApiLazyTestData.GetTopTenUsers(HttpClient);
            var username = topTenUsers.First().Username;
            var responseMethodAsync = await HttpClient.GetUserProfileAsync(username);
            var responseMethodSync = HttpClient.GetUserProfile(username);
            var responseAsync = await HttpClient.SendAsync(new GetUserProfileRequest(username));
            var responseSync = HttpClient.Send(new GetUserProfileRequest(username));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Username, Is.EqualTo(username));
                Assert.That(responseSync.Ulid, Is.Not.Null.And.Not.Empty);
            });
        }

        [Test]
        public void GetUserProfileRequest_ThrowsException_WhenArgumentsAreInvalid()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetUserProfileRequest(null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserProfileRequest(string.Empty);
            });
        }
    }
}
