#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingsV1EmbeddingsPostRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.EmbeddingsV1EmbeddingsPostRequest>
    {
        /// <inheritdoc />
        public override global::Jina.EmbeddingsV1EmbeddingsPostRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Jina.EmbeddingsV2Request? jinaEmbeddingsV2BaseCode = default;
            if (discriminator?.Model == global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV2BaseCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV2Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV2Request)}");
                jinaEmbeddingsV2BaseCode = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.EmbeddingsV3Request? jinaEmbeddingsV3 = default;
            if (discriminator?.Model == global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV3Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV3Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV3Request)}");
                jinaEmbeddingsV3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.EmbeddingsV5Request? jinaEmbeddingsV5TextNano = default;
            if (discriminator?.Model == global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV5TextNano)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV5Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV5Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV5Request)}");
                jinaEmbeddingsV5TextNano = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.EmbeddingsV4Request? jinaEmbeddingsV4 = default;
            if (discriminator?.Model == global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV4Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV4Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.EmbeddingsV4Request)}");
                jinaEmbeddingsV4 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.CodeEmbeddings500MRequest? jinaCodeEmbeddings05b = default;
            if (discriminator?.Model == global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaCodeEmbeddings05b)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.CodeEmbeddings500MRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.CodeEmbeddings500MRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.CodeEmbeddings500MRequest)}");
                jinaCodeEmbeddings05b = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.CodeEmbeddings1500MRequest? jinaCodeEmbeddings15b = default;
            if (discriminator?.Model == global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaCodeEmbeddings15b)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.CodeEmbeddings1500MRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.CodeEmbeddings1500MRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.CodeEmbeddings1500MRequest)}");
                jinaCodeEmbeddings15b = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.ClipV1Request? jinaClipV1 = default;
            if (discriminator?.Model == global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaClipV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ClipV1Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ClipV1Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ClipV1Request)}");
                jinaClipV1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.ClipV2Request? jinaClipV2 = default;
            if (discriminator?.Model == global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaClipV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ClipV2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ClipV2Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ClipV2Request)}");
                jinaClipV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.ColbertV1Request? jinaColbertV1En = default;
            if (discriminator?.Model == global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaColbertV1En)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ColbertV1Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ColbertV1Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ColbertV1Request)}");
                jinaColbertV1En = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.ColbertV2Request? jinaColbertV2 = default;
            if (discriminator?.Model == global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaColbertV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ColbertV2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ColbertV2Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ColbertV2Request)}");
                jinaColbertV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.ELSERV2Request? elserV2 = default;
            if (discriminator?.Model == global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.ElserV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ELSERV2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ELSERV2Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.ELSERV2Request)}");
                elserV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Jina.EmbeddingsV1EmbeddingsPostRequest(
                discriminator?.Model,
                jinaEmbeddingsV2BaseCode,

                jinaEmbeddingsV3,

                jinaEmbeddingsV5TextNano,

                jinaEmbeddingsV4,

                jinaCodeEmbeddings05b,

                jinaCodeEmbeddings15b,

                jinaClipV1,

                jinaClipV2,

                jinaColbertV1En,

                jinaColbertV2,

                elserV2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.EmbeddingsV1EmbeddingsPostRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJinaEmbeddingsV2BaseCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV2Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.EmbeddingsV2Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaEmbeddingsV2BaseCode, typeInfo);
            }
            else if (value.IsJinaEmbeddingsV3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV3Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV3Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.EmbeddingsV3Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaEmbeddingsV3, typeInfo);
            }
            else if (value.IsJinaEmbeddingsV5TextNano)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV5Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV5Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.EmbeddingsV5Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaEmbeddingsV5TextNano, typeInfo);
            }
            else if (value.IsJinaEmbeddingsV4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.EmbeddingsV4Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.EmbeddingsV4Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.EmbeddingsV4Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaEmbeddingsV4, typeInfo);
            }
            else if (value.IsJinaCodeEmbeddings05b)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.CodeEmbeddings500MRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.CodeEmbeddings500MRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.CodeEmbeddings500MRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaCodeEmbeddings05b, typeInfo);
            }
            else if (value.IsJinaCodeEmbeddings15b)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.CodeEmbeddings1500MRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.CodeEmbeddings1500MRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.CodeEmbeddings1500MRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaCodeEmbeddings15b, typeInfo);
            }
            else if (value.IsJinaClipV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ClipV1Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ClipV1Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ClipV1Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaClipV1, typeInfo);
            }
            else if (value.IsJinaClipV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ClipV2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ClipV2Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ClipV2Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaClipV2, typeInfo);
            }
            else if (value.IsJinaColbertV1En)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ColbertV1Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ColbertV1Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ColbertV1Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaColbertV1En, typeInfo);
            }
            else if (value.IsJinaColbertV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ColbertV2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ColbertV2Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ColbertV2Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaColbertV2, typeInfo);
            }
            else if (value.IsElserV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ELSERV2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ELSERV2Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ELSERV2Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElserV2, typeInfo);
            }
        }
    }
}