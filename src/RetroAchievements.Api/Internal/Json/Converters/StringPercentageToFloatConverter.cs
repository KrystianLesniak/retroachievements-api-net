using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;

namespace RetroAchievements.Api.Internal.Json.Converters
{
    internal class StringPercentageToFloatConverter : JsonConverter<float>
    {
        public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options) =>
            writer.WriteStringValue(value.ToString("0.00") + "%");

        public override float Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (float.TryParse(reader.GetString()?.TrimEnd('%'), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var value))
                return value;

            throw new JsonException();
        }
    }
}
