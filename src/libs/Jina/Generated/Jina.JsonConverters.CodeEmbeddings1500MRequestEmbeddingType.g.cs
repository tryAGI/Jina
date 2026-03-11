#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeEmbeddings1500MRequestEmbeddingTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.CodeEmbeddings1500MRequestEmbeddingType>
    {
        /// <inheritdoc />
        public override global::Jina.CodeEmbeddings1500MRequestEmbeddingType Read(
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
                        return global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.CodeEmbeddings1500MRequestEmbeddingType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Jina.CodeEmbeddings1500MRequestEmbeddingType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.CodeEmbeddings1500MRequestEmbeddingType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeExtensions.ToValueString(value));
        }
    }
}
