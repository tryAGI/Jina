#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.ResponseFormatVariant1>
    {
        /// <inheritdoc />
        public override global::Jina.ResponseFormatVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ChatCompletionRequestResponseFormatVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ChatCompletionRequestResponseFormatVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ChatCompletionRequestResponseFormatVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Jina.ResponseFormatText? text = default;
            if (discriminator?.Type == global::Jina.ChatCompletionRequestResponseFormatVariant1DiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ResponseFormatText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ResponseFormatText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ResponseFormatText)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.ResponseFormatJSONObject? jsonObject = default;
            if (discriminator?.Type == global::Jina.ChatCompletionRequestResponseFormatVariant1DiscriminatorType.JsonObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ResponseFormatJSONObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ResponseFormatJSONObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ResponseFormatJSONObject)}");
                jsonObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.ResponseFormatJSONSchema? jsonSchema = default;
            if (discriminator?.Type == global::Jina.ChatCompletionRequestResponseFormatVariant1DiscriminatorType.JsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ResponseFormatJSONSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ResponseFormatJSONSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ResponseFormatJSONSchema)}");
                jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Jina.ResponseFormatVariant1(
                discriminator?.Type,
                text,

                jsonObject,

                jsonSchema
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.ResponseFormatVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ResponseFormatText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ResponseFormatText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ResponseFormatText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsJsonObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ResponseFormatJSONObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ResponseFormatJSONObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ResponseFormatJSONObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonObject!, typeInfo);
            }
            else if (value.IsJsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ResponseFormatJSONSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ResponseFormatJSONSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ResponseFormatJSONSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema!, typeInfo);
            }
        }
    }
}