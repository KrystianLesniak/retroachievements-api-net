using RetroAchievements.Api.Requests.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUsersFollowingMeTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUsersFollowingMe_ReturnsProperResponse()
        {
            var responseMethodAsync = await HttpClient.GetUsersFollowingMeAsync();
            var responseMethodSync = HttpClient.GetUsersFollowingMe();
            var responseAsync = await HttpClient.SendAsync(new GetUsersFollowingMeRequest());
            var responseSync = HttpClient.Send(new GetUsersFollowingMeRequest());

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Total, Is.AtLeast(0));
            });
        }

        [Test]
        public void GetUsersFollowingMeRequest_ThrowsException_WhenArgumentsAreInvalid()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUsersFollowingMeRequest(0, 501);
            });
        }
    }
}
