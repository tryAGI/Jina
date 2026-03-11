#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class ClipV2RequestModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.ClipV2RequestModel?>
    {
        /// <inheritdoc />
        public override global::Jina.ClipV2RequestModel? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Jina.ClipV2RequestModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.ClipV2RequestModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Jina.ClipV2RequestModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.ClipV2RequestModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Jina.ClipV2RequestModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
