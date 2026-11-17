using RetroAchievements.Api.Requests.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUsersIFollowTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUsersIFollow_ReturnsProperResponse()
        {
            var responseMethodAsync = await HttpClient.GetUsersIFollowAsync();
            var responseMethodSync = HttpClient.GetUsersIFollow();
            var responseAsync = await HttpClient.SendAsync(new GetUsersIFollowRequest());
            var responseSync = HttpClient.Send(new GetUsersIFollowRequest());

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Total, Is.AtLeast(0));
            });
        }

        [Test]
        public void GetUsersIFollowRequest_ThrowsException_WhenArgumentsAreInvalid()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUsersIFollowRequest(0, 501);
            });
        }
    }
}
