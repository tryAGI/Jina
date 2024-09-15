#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextEmbeddingInputEmbeddingTypeItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.TextEmbeddingInputEmbeddingTypeItem>
    {
        /// <inheritdoc />
        public override global::Jina.TextEmbeddingInputEmbeddingTypeItem Read(
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
                        return global::Jina.TextEmbeddingInputEmbeddingTypeItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.TextEmbeddingInputEmbeddingTypeItem)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.TextEmbeddingInputEmbeddingTypeItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Jina.TextEmbeddingInputEmbeddingTypeItemExtensions.ToValueString(value));
        }
    }
}
