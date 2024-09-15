#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class MixedEmbeddingInputEmbeddingTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.MixedEmbeddingInputEmbeddingType>
    {
        /// <inheritdoc />
        public override global::Jina.MixedEmbeddingInputEmbeddingType Read(
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
                        return global::Jina.MixedEmbeddingInputEmbeddingTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.MixedEmbeddingInputEmbeddingType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.MixedEmbeddingInputEmbeddingType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Jina.MixedEmbeddingInputEmbeddingTypeExtensions.ToValueString(value));
        }
    }
}
