using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response
{
    public record CollectionRetroAchievementsResponse<TItem> : RetroAchievementsResponse
    {
        [JsonInclude]
        public IEnumerable<TItem> Items { get; internal set; } = new List<TItem>();
    }

    internal class BaseCollectionRetroAchievementsResponseConverter<TItem, TResponse> : JsonConverter<TResponse> where TResponse : CollectionRetroAchievementsResponse<TItem>, new()
    {
        public override TResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Debug.Assert(typeToConvert == typeof(TResponse));

            using (var jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                var items = JsonSerializer.Deserialize<IEnumerable<TItem>>(jsonDoc.RootElement.GetRawText(), options);

                return new TResponse
                {
                    Items = items ?? new List<TItem>()
                };
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, TResponse value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }
}
