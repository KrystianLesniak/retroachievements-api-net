using NUnit.Framework;
using RetroAchievements.Api.Response;
using System.Text.Json;

namespace RetroAchievements.Api.Tests.Common
{
    public static class AssertResponses
    {
        public static void AreEqual(IRetroAchievementResponse resp1, IRetroAchievementResponse resp2, IRetroAchievementResponse resp3, IRetroAchievementResponse resp4)
        {
            var json1 = JsonSerializer.Serialize(resp1);
            var json2 = JsonSerializer.Serialize(resp2);
            var json3 = JsonSerializer.Serialize(resp3);
            var json4 = JsonSerializer.Serialize(resp4);


            Assert.AreEqual(json1, json2);
            Assert.AreEqual(json2, json3);
            Assert.AreEqual(json3, json4);
        }
    }
}
