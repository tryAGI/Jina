#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageEmbeddingInputEmbeddingTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.ImageEmbeddingInputEmbeddingType>
    {
        /// <inheritdoc />
        public override global::Jina.ImageEmbeddingInputEmbeddingType Read(
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
                        return global::Jina.ImageEmbeddingInputEmbeddingTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.ImageEmbeddingInputEmbeddingType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.ImageEmbeddingInputEmbeddingType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Jina.ImageEmbeddingInputEmbeddingTypeExtensions.ToValueString(value));
        }
    }
}
