using RetroAchievements.Api.Response.Consoles;
using RetroAchievements.Api.Response.Games;
using RetroAchievements.Api.Response.Users;
using System.Text.Json;

namespace RetroAchievements.Api.Tests
{
    public class JsonSerializationTests
    {
        [Test]
        public void CollectionResponse_SerializesBackToArray()
        {
            var response = JsonSerializer.Deserialize<GetConsoleIdsResponse>(@"[{""ID"":1,""Name"":""Genesis/Mega Drive"",""IconURL"":""x"",""Active"":true,""IsGameSystem"":true}]")!;

            var json = JsonSerializer.Serialize(response);

            Assert.That(JsonSerializer.Deserialize<GetConsoleIdsResponse>(json)!.Items.Single().Name, Is.EqualTo("Genesis/Mega Drive"));
        }

        [Test]
        public void DictionaryResponse_SerializesBackToObject()
        {
            var response = JsonSerializer.Deserialize<GetAchievementDistributionResponse>(@"{""1"":10,""2"":5}")!;

            var json = JsonSerializer.Serialize(response);

            Assert.That(JsonSerializer.Deserialize<GetAchievementDistributionResponse>(json)!.Items[2], Is.EqualTo(5));
        }

        [Test]
        public void DateTimeConverter_KeepsAfternoonHours()
        {
            var response = JsonSerializer.Deserialize<GetUserClaimsResponse>(@"[{""Created"":""2024-01-02 13:05:00""}]")!;

            Assert.Multiple(() =>
            {
                Assert.That(response.Items.Single().CreatedDate, Is.EqualTo(new DateTime(2024, 1, 2, 13, 5, 0)));
                Assert.That(JsonSerializer.Serialize(response), Does.Contain("2024-01-02 13:05:00"));
            });
        }

        [Test]
        public void GameExtendedData_DeserializesNullAwardCounts()
        {
            var response = JsonSerializer.Deserialize<GetGameExtendedDataResponse>(@"{""ID"":1,""Achievements"":{""50"":{""ID"":50,""NumAwarded"":null,""NumAwardedHardcore"":null}}}")!;

            Assert.That(response.Achievements[50].AwardedCount, Is.EqualTo(0));
        }
    }
}
