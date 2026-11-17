using RetroAchievements.Api.Requests.Comments;
using RetroAchievements.Api.Requests.Enums;

namespace RetroAchievements.Api.Comments.Tests
{
    [TestFixture]
    public class GetCommentsTests
    {
        private readonly RetroAchievementsHttpClient HttpClient = TestHttpClient.GetRetroAchievementsApiClient();

        [Test]
        [ApiTest]
        public async Task GetComments_ReturnsProperResponse()
        {
            var responseMethodAsync = await HttpClient.GetCommentsAsync(14402, CommentKind.Game);
            var responseMethodSync = HttpClient.GetComments(14402, CommentKind.Game);
            var responseAsync = await HttpClient.SendAsync(new GetCommentsRequest(14402, CommentKind.Game));
            var responseSync = HttpClient.Send(new GetCommentsRequest(14402, CommentKind.Game));

            AssertResponses.AreEqual(responseMethodAsync, responseMethodSync, responseAsync, responseSync);
            Assert.Multiple(() =>
            {
                Assert.That(responseMethodAsync.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(responseMethodAsync.FailedResponseString, Is.EqualTo(null));
                Assert.That(responseSync.Results.Any());
                Assert.That(responseSync.Total, Is.AtLeast(responseSync.Count));
            });
        }

        [Test]
        public void GetCommentsRequest_ThrowsException_WhenArgumentsAreInvalid()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetCommentsRequest(14402, CommentKind.Game, 0, 501);
            });
            Assert.Throws<ArgumentException>(() =>
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                _ = new GetCommentsRequest(null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            });
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new GetCommentsRequest(string.Empty);
            });
        }
    }
}
