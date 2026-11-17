using RetroAchievements.Api.Requests.Comments;

namespace RetroAchievements.Api.Comments.Tests
{
    [TestFixture]
    public class GetCommentsForUserWallTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetCommentsForUserWall_ReturnsProperResponse()
        {
            var topTenUsers = await ApiLazyTestData.GetTopTenUsers(HttpClient);
            var username = topTenUsers.First().Username;
            var responseMethodAsync = await HttpClient.GetCommentsAsync(username);
            var responseMethodSync = HttpClient.GetComments(username);
            var responseAsync = await HttpClient.SendAsync(new GetCommentsRequest(username));
            var responseSync = HttpClient.Send(new GetCommentsRequest(username));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Count, Is.EqualTo(responseSync.Results.Count));
            });
        }
    }
}
