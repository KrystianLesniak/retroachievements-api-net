using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response
{
    public record DictionaryRetroAchievementsResponse<TKey, TValue> : RetroAchievementsResponse where TKey : notnull
    {
        [JsonInclude]
        public IDictionary<TKey, TValue> Items { get; internal set; } = new Dictionary<TKey, TValue>();
    }

    internal class DictionaryRetroAchievementsResponseConverter<TKey, TValue, TResponse> : JsonConverter<TResponse> where TResponse : DictionaryRetroAchievementsResponse<TKey, TValue>, new() where TKey : notnull
    {
        public override TResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Debug.Assert(typeToConvert == typeof(TResponse));

            using (var jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                var items = JsonSerializer.Deserialize<IDictionary<TKey, TValue>>(jsonDoc.RootElement.GetRawText(), options);

                return new TResponse
                {
                    Items = items ?? new Dictionary<TKey, TValue>()
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
