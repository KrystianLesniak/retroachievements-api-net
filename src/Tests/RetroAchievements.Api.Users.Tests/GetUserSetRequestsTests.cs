using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Requests.Enums;

namespace RetroAchievements.Api.Users.Tests
{
    [TestFixture]
    public class GetUserSetRequestsTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetUserSetRequests_ReturnsProperResponse()
        {
            var topTenUsers = await ApiLazyTestData.GetTopTenUsers(HttpClient);
            var username = topTenUsers.First().Username;
            var responseMethodAsync = await HttpClient.GetUserSetRequestsAsync(username, RequestListType.AllRequests);
            var responseMethodSync = HttpClient.GetUserSetRequests(username, RequestListType.AllRequests);
            var responseAsync = await HttpClient.SendAsync(new GetUserSetRequestsRequest(username, RequestListType.AllRequests));
            var responseSync = HttpClient.Send(new GetUserSetRequestsRequest(username, RequestListType.AllRequests));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.TotalRequests, Is.AtLeast(0));
            });
        }

        [Test]
        public void GetUserSetRequestsRequest_ThrowsException_WhenArgumentsAreInvalid()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetUserSetRequestsRequest(null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetUserSetRequestsRequest(string.Empty);
            });
        }
    }
}
