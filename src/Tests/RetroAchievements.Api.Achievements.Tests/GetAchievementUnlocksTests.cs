using RetroAchievements.Api.Requests.Achievements;

namespace RetroAchievements.Api.Achievements.Tests
{
    [TestFixture]
    public class GetAchievementUnlocksTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient(); 

        [Test]
        [ApiTest]
        public async Task GetAchievementUnlocks_ReturnsProperResponse()
        {
            var achievementId = 3159;

            var responseMethodAsync = await HttpClient.GetAchievementUnlocksAsync(achievementId);
            var responseMethodSync = HttpClient.GetAchievementUnlocks(achievementId);
            var responseAsync = await HttpClient.SendAsync(new GetAchievementUnlocksRequest(achievementId));
            var responseSync = HttpClient.Send(new GetAchievementUnlocksRequest(achievementId));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Game.Id, Is.EqualTo(1446));
                Assert.That(responseSync.Achievement.Id, Is.EqualTo(achievementId));
                Assert.That(responseSync.PlayersCount, Is.AtLeast(30000));
                Assert.That(responseSync.UnlocksCount, Is.AtLeast(29000));
                Assert.That(responseSync.Unlocks.Any());
            });
        }

        [Test]
        [ApiTest]
        public async Task GetAchievementUnlocks_ReturnsUnsuccessfulResponse()
        {
            var achievementId = 1000000;

            var responseMethodAsync = await HttpClient.GetAchievementUnlocksAsync(achievementId);
            var responseMethodSync = HttpClient.GetAchievementUnlocks(achievementId);
            var responseAsync = await HttpClient.SendAsync(new GetAchievementUnlocksRequest(achievementId));
            var responseSync = HttpClient.Send(new GetAchievementUnlocksRequest(achievementId));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.InternalServerError));
                Assert.That(responseMethodAsync.FailedResponseString, Is.Not.EqualTo(string.Empty));
                Assert.That(responseMethodAsync.FailedResponseString, Is.Not.EqualTo(null));
                Assert.That(responseSync.Game.Id, Is.EqualTo(0));
                Assert.That(responseSync.Achievement.Id, Is.EqualTo(0));
                Assert.That(responseSync.PlayersCount, Is.AtLeast(0));
                Assert.That(responseSync.UnlocksCount, Is.AtLeast(0));
                Assert.That(!responseSync.Unlocks.Any());
            });
        }

        [Test]
        public void GetAchievementUnlocksRequest_ThrowsArgumentException_IfCountExceeds500()
        {
            var achievementId = 3159;
            var count = 501;

            Assert.Throws<ArgumentException>(() =>
                _ = new GetAchievementUnlocksRequest(achievementId, count: count)
            );
        }
    }
}