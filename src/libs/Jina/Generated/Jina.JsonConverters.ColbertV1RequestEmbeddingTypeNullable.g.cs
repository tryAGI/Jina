#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class ColbertV1RequestEmbeddingTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.ColbertV1RequestEmbeddingType?>
    {
        /// <inheritdoc />
        public override global::Jina.ColbertV1RequestEmbeddingType? Read(
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
                        return global::Jina.ColbertV1RequestEmbeddingTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.ColbertV1RequestEmbeddingType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Jina.ColbertV1RequestEmbeddingType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.ColbertV1RequestEmbeddingType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Jina.ColbertV1RequestEmbeddingTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
