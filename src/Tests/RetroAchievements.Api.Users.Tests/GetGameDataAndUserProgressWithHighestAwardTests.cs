using RetroAchievements.Api.Requests.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetGameDataAndUserProgressWithHighestAwardTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetGameDataAndUserProgressWithHighestAward_ReturnsProperResponse()
        {
            var topTenUsers = await ApiLazyTestData.GetTopTenUsers(HttpClient);
            var username = topTenUsers.First().Username;
            var responseMethodAsync = await HttpClient.GetGameDataAndUserProgressAsync(14402, username, true);
            var responseMethodSync = HttpClient.GetGameDataAndUserProgress(14402, username, true);
            var responseAsync = await HttpClient.SendAsync(new GetGameDataAndUserProgressRequest(14402, username, true));
            var responseSync = HttpClient.Send(new GetGameDataAndUserProgressRequest(14402, username, true));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Id, Is.EqualTo(14402));
            });
        }
    }
}
