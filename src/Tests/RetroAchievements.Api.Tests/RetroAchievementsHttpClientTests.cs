using RetroAchievements.Api.Request;
using RetroAchievements.Api.Requests.Achievements;
using RetroAchievements.Api.Response.Achievements;

namespace RetroAchievements.Api.Tests
{
    public class RetroAchievementsHttpClientTests
    {
        [Test]
        public void RetroAchievementsHttpClient_ThrowsArgumentNullException_WhenInitializedWithoutAuthData()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                IRetroAchievementsAuthenticationData? authData = null;
#pragma warning disable CS8604 // Possible null reference argument.
                _ = new RetroAchievementsHttpClient(authData);
#pragma warning restore CS8604 // Possible null reference argument.
            });
        }

        [Test]
        public void RetroAchievementsHttpClient_ThrowsArgumentNullException_WhenInitializedWithoutHttpClient()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                HttpClient? authData = null;
#pragma warning disable CS8604 // Possible null reference argument.
                _ = new RetroAchievementsHttpClient(authData);
#pragma warning restore CS8604 // Possible null reference argument.
            });
        }

        [Test]
        public void RetroAchievementsHttpClient_ThrowsArgumentNullException_SetNullAuthenticationData()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                IRetroAchievementsAuthenticationData? authData = null;
                var httpClient = new RetroAchievementsHttpClient();
#pragma warning disable CS8604 // Possible null reference argument.
                httpClient.SetAuthenticationData(authData);
#pragma warning restore CS8604 // Possible null reference argument.
            });
        }

        [Test]
        public void RetroAchievementsHttpClientSend_ThrowsMissingAuthenticationDataException_WhenNoAuthenticationDataProvided()
        {
            var httpClient = new RetroAchievementsHttpClient();

            var exAsync = Assert.CatchAsync(async () =>
            {
                await httpClient.SendAsync(new GetAchievementUnlocksRequest(1));
            });
            var ex = Assert.Catch(() =>
            {
                httpClient.Send(new GetAchievementUnlocksRequest(1));
            });
            Assert.Multiple(() =>
            {
                Assert.That(exAsync.Message, Is.EqualTo("No Authentication Data for RetroAchievements Web API provided. Please provide API and username via RetroAchievementsHttpClient constructor or as parameter when calling a request."));
                Assert.That(ex.Message, Is.EqualTo("No Authentication Data for RetroAchievements Web API provided. Please provide API and username via RetroAchievementsHttpClient constructor or as parameter when calling a request."));
            });
        }

        [Test]
        public void RetroAchievementsHttpClientSend_ThrowsArgumentNullException_WhenNoRequest()
        {
            var httpClient = new RetroAchievementsHttpClient();
            IRetroAchievementsRequest<GetAchievementUnlocksResponse>? request = null;

            Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
#pragma warning disable CS8604 // Possible null reference argument.
                await httpClient.SendAsync(request);
            });
            Assert.Throws<ArgumentNullException>(() =>
            {
                httpClient.Send(request);
#pragma warning restore CS8604 // Possible null reference argument.
            });
        }
    }
}