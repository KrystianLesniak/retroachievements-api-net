using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Internal.Json.Converters
{
    internal class DateTimeCustomApiFormatConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Debug.Assert(typeToConvert == typeof(DateTime));

            if (DateTime.TryParseExact(reader.GetString(), "yyyy-MM-dd hh:mm:ss", null,
                          DateTimeStyles.None, out DateTime parsedDate))
            {
                return parsedDate;
            }
            else if (DateTime.TryParseExact(reader.GetString(), "yyyy-MM-dd", null,
                          DateTimeStyles.None, out DateTime parsedDate2))
            {
                return parsedDate2;
            }
            else if (DateTime.TryParseExact(reader.GetString(), "yyyy-MM", null,
                          DateTimeStyles.None, out DateTime parsedDate3))
            {
                return parsedDate3;
            }
            else if (DateTime.TryParseExact(reader.GetString(), "yyyy", null,
              DateTimeStyles.None, out DateTime parsedDate4))
            {
                return parsedDate4;
            }
            else
            {
                return DateTime.Parse(reader.GetString()!);
            }


            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-dd hh:mm:ss"));
        }
    }
}
