using RetroAchievements.Api.Common.Enums;
using RetroAchievements.Api.Internal.Json;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{

    [JsonConverter(typeof(GetActiveClaimsResponseConverter))]
    public record GetActiveClaimsResponse : BaseRetroAchievementsResponse
    {
        [JsonInclude]
        public IEnumerable<ActiveClaim> ActiveClaims { get; internal set; } = new List<ActiveClaim>();
    }

    public record ActiveClaim
    {
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        [JsonInclude]
        public string User { get; private set; }

        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        [JsonInclude]
        public string GameTitle { get; private set; } = string.Empty;

        [JsonInclude]
        public string GameIcon { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("ConsoleID")]
        public int ConsoleId { get; private set; }

        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        [JsonInclude]
        public ClaimTypeEnum ClaimType { get; private set; }

        [JsonInclude]
        public SetTypeEnum SetType { get; private set; }

        [JsonInclude]
        public StatusEnum Status { get; private set; }

        [JsonInclude]
        public int Extension { get; private set; }

        [JsonInclude]
        public int Special { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeConverterForCustomApiFormat))]
        public DateTime Created { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeConverterForCustomApiFormat))]
        public DateTime DoneTime { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeConverterForCustomApiFormat))]
        public DateTime Updated { get; private set; }

        //TODO: Map to boolean
        [JsonInclude]
        public int UserIsJrDev { get; private set; }

        [JsonInclude]
        public int MinutesLeft { get; private set; }
    }

    internal class GetActiveClaimsResponseConverter : JsonConverter<GetActiveClaimsResponse>
    {
        public override GetActiveClaimsResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Debug.Assert(typeToConvert == typeof(GetActiveClaimsResponse));

            using (var jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                var activeClaims = JsonSerializer.Deserialize<IEnumerable<ActiveClaim>>(jsonDoc.RootElement.GetRawText(), options);

                return new GetActiveClaimsResponse
                {
                    ActiveClaims = activeClaims ?? new List<ActiveClaim>()
                };
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, GetActiveClaimsResponse value, JsonSerializerOptions options)
        {
            //TODO: Handle Serialization
            throw new NotImplementedException();
        }
    }
}
