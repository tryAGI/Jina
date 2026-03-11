#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public class TrainV1TrainPostRequestVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.TrainV1TrainPostRequestVariant1>
    {
        /// <inheritdoc />
        public override global::Jina.TrainV1TrainPostRequestVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.TrainV1TrainPostRequestVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.TrainV1TrainPostRequestVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.TrainV1TrainPostRequestVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Jina.EmbeddingsV2CreateTrainingRequest? jinaEmbeddingsV2BaseEn = default;
            if (discriminator?.Model == global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseEn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV2CreateTrainingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV2CreateTrainingRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV2CreateTrainingRequest)}");
                jinaEmbeddingsV2BaseEn = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.EmbeddingsV3CreateTrainingRequest? jinaEmbeddingsV3 = default;
            if (discriminator?.Model == global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV3CreateTrainingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV3CreateTrainingRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV3CreateTrainingRequest)}");
                jinaEmbeddingsV3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.EmbeddingsV4CreateTrainingRequest? jinaEmbeddingsV4 = default;
            if (discriminator?.Model == global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV4CreateTrainingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV4CreateTrainingRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV4CreateTrainingRequest)}");
                jinaEmbeddingsV4 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.EmbeddingsV5CreateTrainingRequest? jinaEmbeddingsV5TextNano = default;
            if (discriminator?.Model == global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV5TextNano)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV5CreateTrainingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV5CreateTrainingRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV5CreateTrainingRequest)}");
                jinaEmbeddingsV5TextNano = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.ClipCreateTrainingRequest? jinaClipV1 = default;
            if (discriminator?.Model == global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaClipV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ClipCreateTrainingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ClipCreateTrainingRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ClipCreateTrainingRequest)}");
                jinaClipV1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Jina.TrainV1TrainPostRequestVariant1(
                discriminator?.Model,
                jinaEmbeddingsV2BaseEn,

                jinaEmbeddingsV3,

                jinaEmbeddingsV4,

                jinaEmbeddingsV5TextNano,

                jinaClipV1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.TrainV1TrainPostRequestVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJinaEmbeddingsV2BaseEn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV2CreateTrainingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV2CreateTrainingRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.EmbeddingsV2CreateTrainingRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaEmbeddingsV2BaseEn, typeInfo);
            }
            else if (value.IsJinaEmbeddingsV3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV3CreateTrainingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV3CreateTrainingRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.EmbeddingsV3CreateTrainingRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaEmbeddingsV3, typeInfo);
            }
            else if (value.IsJinaEmbeddingsV4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV4CreateTrainingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV4CreateTrainingRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.EmbeddingsV4CreateTrainingRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaEmbeddingsV4, typeInfo);
            }
            else if (value.IsJinaEmbeddingsV5TextNano)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV5CreateTrainingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV5CreateTrainingRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.EmbeddingsV5CreateTrainingRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaEmbeddingsV5TextNano, typeInfo);
            }
            else if (value.IsJinaClipV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ClipCreateTrainingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ClipCreateTrainingRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ClipCreateTrainingRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaClipV1, typeInfo);
            }
        }
    }
}