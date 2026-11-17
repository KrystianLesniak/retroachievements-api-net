using RetroAchievements.Api.Requests.Users;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUserWantToPlayListTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUserWantToPlayList_ReturnsProperResponse()
        {
            var username = TestAuthenticationData.CreateFromSecrets().UserName;
            var responseMethodAsync = await HttpClient.GetUserWantToPlayListAsync(username);
            var responseMethodSync = HttpClient.GetUserWantToPlayList(username);
            var responseAsync = await HttpClient.SendAsync(new GetUserWantToPlayListRequest(username));
            var responseSync = HttpClient.Send(new GetUserWantToPlayListRequest(username));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Total, Is.AtLeast(0));
            });
        }

        [Test]
        public void GetUserWantToPlayListRequest_ThrowsException_WhenArgumentsAreInvalid()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetUserWantToPlayListRequest(null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserWantToPlayListRequest(string.Empty);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserWantToPlayListRequest("Scott", 0, 501);
            });
        }
    }
}
