using System.Text.Json;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Internal.Json.Converters
{
    // API returns null instead of 0 for some counters (e.g. unofficial achievements)
    internal class NullToDefaultIntConverter : JsonConverter<int>
    {
        public override bool HandleNull => true;

        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.TokenType == JsonTokenType.Null ? default : reader.GetInt32();

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options) =>
            writer.WriteNumberValue(value);
    }
}
