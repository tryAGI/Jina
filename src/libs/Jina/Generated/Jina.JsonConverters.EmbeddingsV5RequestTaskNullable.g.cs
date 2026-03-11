#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbeddingsV5RequestTaskNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.EmbeddingsV5RequestTask?>
    {
        /// <inheritdoc />
        public override global::Jina.EmbeddingsV5RequestTask? Read(
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
                        return global::Jina.EmbeddingsV5RequestTaskExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.EmbeddingsV5RequestTask)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Jina.EmbeddingsV5RequestTask?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.EmbeddingsV5RequestTask? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Jina.EmbeddingsV5RequestTaskExtensions.ToValueString(value.Value));
            }
        }
    }
}
