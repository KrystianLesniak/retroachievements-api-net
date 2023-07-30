using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response
{
    /// <summary>
    /// RetroAchievements API Collection Response Data.
    /// </summary>
    public record CollectionRetroAchievementsResponse<TItem> : RetroAchievementsResponse
    {
        /// <summary>
        /// Collection of items returned from API request call.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<TItem> Items { get; internal set; } = Array.Empty<TItem>();
    }

    internal class CollectionRetroAchievementsResponseConverter<TItem, TResponse> : JsonConverter<TResponse> where TResponse : CollectionRetroAchievementsResponse<TItem>, new()
    {
        public override TResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Debug.Assert(typeToConvert == typeof(TResponse));

            using (var jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                IReadOnlyCollection<TItem>? items = Array.Empty<TItem>();

                if (jsonDoc.RootElement.ValueKind == JsonValueKind.Array && jsonDoc.RootElement.GetArrayLength() > 0)
                {
                    items = JsonSerializer.Deserialize<IReadOnlyCollection<TItem>>(jsonDoc.RootElement.GetRawText(), options);
                }

                return new TResponse
                {
                    Items = items ?? Array.Empty<TItem>()
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
