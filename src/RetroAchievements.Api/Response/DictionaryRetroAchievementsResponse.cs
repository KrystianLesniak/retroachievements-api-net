using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response
{
    /// <summary>
    /// RetroAchievements API Map Response Data.
    /// </summary>
    public record DictionaryRetroAchievementsResponse<TKey, TValue> : RetroAchievementsResponse where TKey : notnull
    {
        /// <summary>
        /// Map of items returned from API request call.
        /// </summary>
        [JsonInclude]
        public IReadOnlyDictionary<TKey, TValue> Items { get; internal set; } = new ReadOnlyDictionary<TKey, TValue>(new Dictionary<TKey, TValue>());
    }

    internal class DictionaryRetroAchievementsResponseConverter<TKey, TValue, TResponse> : JsonConverter<TResponse> where TResponse : DictionaryRetroAchievementsResponse<TKey, TValue>, new() where TKey : notnull
    {
        public override TResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Debug.Assert(typeToConvert == typeof(TResponse));

            using (var jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                IDictionary<TKey, TValue>? items = new Dictionary<TKey, TValue>();

                if (jsonDoc.RootElement.ValueKind == JsonValueKind.Object)
                {
                    items = JsonSerializer.Deserialize<IDictionary<TKey, TValue>>(jsonDoc.RootElement.GetRawText(), options);
                }

                return new TResponse
                {
                    Items = new ReadOnlyDictionary<TKey, TValue>(items ?? new Dictionary<TKey, TValue>())
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
