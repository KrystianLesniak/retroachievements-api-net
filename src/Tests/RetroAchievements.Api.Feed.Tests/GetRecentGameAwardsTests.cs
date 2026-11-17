using RetroAchievements.Api.Requests.Feed;
using RetroAchievements.Api.Requests.Enums;

namespace RetroAchievements.Api.Feed.Tests
{
    [TestFixture]
    public class GetRecentGameAwardsTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetRecentGameAwards_ReturnsProperResponse()
        {
            var responseMethodAsync = await HttpClient.GetRecentGameAwardsAsync(DateTime.Today.AddDays(-7), 0, 10, new[] { AwardKind.Mastered });
            var responseMethodSync = HttpClient.GetRecentGameAwards(DateTime.Today.AddDays(-7), 0, 10, new[] { AwardKind.Mastered });
            var responseAsync = await HttpClient.SendAsync(new GetRecentGameAwardsRequest(DateTime.Today.AddDays(-7), 0, 10, new[] { AwardKind.Mastered }));
            var responseSync = HttpClient.Send(new GetRecentGameAwardsRequest(DateTime.Today.AddDays(-7), 0, 10, new[] { AwardKind.Mastered }));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Results.Any());
                Assert.That(responseSync.Results.All(x => x.AwardKind == "mastered"));
            });
        }

        [Test]
        public void GetRecentGameAwardsRequest_ThrowsException_WhenArgumentsAreInvalid()
        {
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetRecentGameAwardsRequest(null, 0, 101);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });
        }
    }
}
