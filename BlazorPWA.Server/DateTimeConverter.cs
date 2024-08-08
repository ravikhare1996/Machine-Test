using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorPWA.Server
{    
    public class DateTimeConverter : JsonConverter<DateTime?>
    {
        private readonly string[] _formats = new[]
    {
        "yyyy-MM-ddTHH:mm:ss.fff",
        "yyyy-MM-ddTHH:mm:ss",
        "yyyy-MM-dd",
    };

        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return (DateTime?)null;
            }
            var value = reader.GetString();
            return DateTime.ParseExact(value, _formats, CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteStringValue(value.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"));
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }

}
