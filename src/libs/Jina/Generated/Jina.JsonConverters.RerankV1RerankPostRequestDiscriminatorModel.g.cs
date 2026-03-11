#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class RerankV1RerankPostRequestDiscriminatorModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.RerankV1RerankPostRequestDiscriminatorModel>
    {
        /// <inheritdoc />
        public override global::Jina.RerankV1RerankPostRequestDiscriminatorModel Read(
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
                        return global::Jina.RerankV1RerankPostRequestDiscriminatorModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.RerankV1RerankPostRequestDiscriminatorModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Jina.RerankV1RerankPostRequestDiscriminatorModel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.RerankV1RerankPostRequestDiscriminatorModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Jina.RerankV1RerankPostRequestDiscriminatorModelExtensions.ToValueString(value));
        }
    }
}
