#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class MixedEmbeddingInputTaskJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.MixedEmbeddingInputTask>
    {
        /// <inheritdoc />
        public override global::Jina.MixedEmbeddingInputTask Read(
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
                        return global::Jina.MixedEmbeddingInputTaskExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.MixedEmbeddingInputTask)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.MixedEmbeddingInputTask value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Jina.MixedEmbeddingInputTaskExtensions.ToValueString(value));
        }
    }
}
