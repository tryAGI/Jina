#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class MixedEmbeddingInputTaskNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.MixedEmbeddingInputTask?>
    {
        /// <inheritdoc />
        public override global::Jina.MixedEmbeddingInputTask? Read(
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
                        return global::Jina.MixedEmbeddingInputTaskExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.MixedEmbeddingInputTask)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Jina.MixedEmbeddingInputTask?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.MixedEmbeddingInputTask? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Jina.MixedEmbeddingInputTaskExtensions.ToValueString(value.Value));
            }
        }
    }
}
