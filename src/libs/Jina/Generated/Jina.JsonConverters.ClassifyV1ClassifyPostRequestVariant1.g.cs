#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public class ClassifyV1ClassifyPostRequestVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.ClassifyV1ClassifyPostRequestVariant1>
    {
        /// <inheritdoc />
        public override global::Jina.ClassifyV1ClassifyPostRequestVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ClassifyV1ClassifyPostRequestVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ClassifyV1ClassifyPostRequestVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Jina.EmbeddingsV2ZeroShotClassificationRequest? jinaEmbeddingsV2BaseCode = default;
            if (discriminator?.Model == global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV2ZeroShotClassificationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV2ZeroShotClassificationRequest)}");
                jinaEmbeddingsV2BaseCode = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.EmbeddingsV3ZeroShotClassificationRequest? jinaEmbeddingsV3 = default;
            if (discriminator?.Model == global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV3ZeroShotClassificationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV3ZeroShotClassificationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV3ZeroShotClassificationRequest)}");
                jinaEmbeddingsV3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.EmbeddingsV4ZeroShotClassificationRequest? jinaEmbeddingsV4 = default;
            if (discriminator?.Model == global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV4ZeroShotClassificationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV4ZeroShotClassificationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV4ZeroShotClassificationRequest)}");
                jinaEmbeddingsV4 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.EmbeddingsV5ZeroShotClassificationRequest? jinaEmbeddingsV5TextNano = default;
            if (discriminator?.Model == global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV5TextNano)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV5ZeroShotClassificationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV5ZeroShotClassificationRequest)}");
                jinaEmbeddingsV5TextNano = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.ClipZeroShotClassificationRequest? jinaClipV1 = default;
            if (discriminator?.Model == global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaClipV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ClipZeroShotClassificationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ClipZeroShotClassificationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ClipZeroShotClassificationRequest)}");
                jinaClipV1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.CodeEmbeddingsZeroShotClassificationRequest? jinaCodeEmbeddings05b = default;
            if (discriminator?.Model == global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaCodeEmbeddings05b)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.CodeEmbeddingsZeroShotClassificationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.CodeEmbeddingsZeroShotClassificationRequest)}");
                jinaCodeEmbeddings05b = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Jina.ClassifyV1ClassifyPostRequestVariant1(
                discriminator?.Model,
                jinaEmbeddingsV2BaseCode,

                jinaEmbeddingsV3,

                jinaEmbeddingsV4,

                jinaEmbeddingsV5TextNano,

                jinaClipV1,

                jinaCodeEmbeddings05b
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.ClassifyV1ClassifyPostRequestVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJinaEmbeddingsV2BaseCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV2ZeroShotClassificationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaEmbeddingsV2BaseCode, typeInfo);
            }
            else if (value.IsJinaEmbeddingsV3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV3ZeroShotClassificationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV3ZeroShotClassificationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.EmbeddingsV3ZeroShotClassificationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaEmbeddingsV3, typeInfo);
            }
            else if (value.IsJinaEmbeddingsV4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV4ZeroShotClassificationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV4ZeroShotClassificationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.EmbeddingsV4ZeroShotClassificationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaEmbeddingsV4, typeInfo);
            }
            else if (value.IsJinaEmbeddingsV5TextNano)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV5ZeroShotClassificationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaEmbeddingsV5TextNano, typeInfo);
            }
            else if (value.IsJinaClipV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ClipZeroShotClassificationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ClipZeroShotClassificationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ClipZeroShotClassificationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaClipV1, typeInfo);
            }
            else if (value.IsJinaCodeEmbeddings05b)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.CodeEmbeddingsZeroShotClassificationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaCodeEmbeddings05b, typeInfo);
            }
        }
    }
}