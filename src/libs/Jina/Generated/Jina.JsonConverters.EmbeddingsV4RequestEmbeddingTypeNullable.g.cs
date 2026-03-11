#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbeddingsV4RequestEmbeddingTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.EmbeddingsV4RequestEmbeddingType?>
    {
        /// <inheritdoc />
        public override global::Jina.EmbeddingsV4RequestEmbeddingType? Read(
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
                        return global::Jina.EmbeddingsV4RequestEmbeddingTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.EmbeddingsV4RequestEmbeddingType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Jina.EmbeddingsV4RequestEmbeddingType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.EmbeddingsV4RequestEmbeddingType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Jina.EmbeddingsV4RequestEmbeddingTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
