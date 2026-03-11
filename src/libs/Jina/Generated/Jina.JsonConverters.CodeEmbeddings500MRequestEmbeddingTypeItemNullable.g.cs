#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeEmbeddings500MRequestEmbeddingTypeItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem?>
    {
        /// <inheritdoc />
        public override global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem? Read(
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
                        return global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
