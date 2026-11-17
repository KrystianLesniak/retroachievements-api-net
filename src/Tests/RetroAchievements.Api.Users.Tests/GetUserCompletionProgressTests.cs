using RetroAchievements.Api.Requests.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUserCompletionProgressTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUserCompletionProgress_ReturnsProperResponse()
        {
            var topTenUsers = await ApiLazyTestData.GetTopTenUsers(HttpClient);
            var username = topTenUsers.First().Username;
            var responseMethodAsync = await HttpClient.GetUserCompletionProgressAsync(username);
            var responseMethodSync = HttpClient.GetUserCompletionProgress(username);
            var responseAsync = await HttpClient.SendAsync(new GetUserCompletionProgressRequest(username));
            var responseSync = HttpClient.Send(new GetUserCompletionProgressRequest(username));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Results.Any());
            });
        }

        [Test]
        public void GetUserCompletionProgressRequest_ThrowsException_WhenArgumentsAreInvalid()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetUserCompletionProgressRequest(null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserCompletionProgressRequest(string.Empty);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserCompletionProgressRequest("Scott", 0, 501);
            });
        }
    }
}
