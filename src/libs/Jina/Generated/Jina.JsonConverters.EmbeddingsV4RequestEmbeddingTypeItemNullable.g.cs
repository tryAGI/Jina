#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbeddingsV4RequestEmbeddingTypeItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem?>
    {
        /// <inheritdoc />
        public override global::Jina.EmbeddingsV4RequestEmbeddingTypeItem? Read(
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
                        return global::Jina.EmbeddingsV4RequestEmbeddingTypeItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.EmbeddingsV4RequestEmbeddingTypeItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Jina.EmbeddingsV4RequestEmbeddingTypeItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.EmbeddingsV4RequestEmbeddingTypeItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Jina.EmbeddingsV4RequestEmbeddingTypeItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
