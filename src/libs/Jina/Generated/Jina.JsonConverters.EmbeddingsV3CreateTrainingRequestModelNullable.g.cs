#nullable enable

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbeddingsV3CreateTrainingRequestModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.EmbeddingsV3CreateTrainingRequestModel?>
    {
        /// <inheritdoc />
        public override global::Jina.EmbeddingsV3CreateTrainingRequestModel? Read(
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
                        return global::Jina.EmbeddingsV3CreateTrainingRequestModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Jina.EmbeddingsV3CreateTrainingRequestModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Jina.EmbeddingsV3CreateTrainingRequestModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.EmbeddingsV3CreateTrainingRequestModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Jina.EmbeddingsV3CreateTrainingRequestModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
