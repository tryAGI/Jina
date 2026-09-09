#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public class ContentVariant2ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.ContentVariant2Item>
    {
        /// <inheritdoc />
        public override global::Jina.ContentVariant2Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ChatMessageContentVariant2ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ChatMessageContentVariant2ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ChatMessageContentVariant2ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Jina.TextContentPart? text = default;
            if (discriminator?.Type == global::Jina.ChatMessageContentVariant2ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.TextContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.TextContentPart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.TextContentPart)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.ImageContentPart? imageUrl = default;
            if (discriminator?.Type == global::Jina.ChatMessageContentVariant2ItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ImageContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ImageContentPart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ImageContentPart)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Jina.ContentVariant2Item(
                discriminator?.Type,
                text,

                imageUrl
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.ContentVariant2Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.TextContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.TextContentPart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.TextContentPart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ImageContentPart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ImageContentPart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ImageContentPart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl!, typeInfo);
            }
        }
    }
}