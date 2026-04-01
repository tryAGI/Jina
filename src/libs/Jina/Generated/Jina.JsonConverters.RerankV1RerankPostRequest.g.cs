#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public class RerankV1RerankPostRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.RerankV1RerankPostRequest>
    {
        /// <inheritdoc />
        public override global::Jina.RerankV1RerankPostRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.RerankV1RerankPostRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.RerankV1RerankPostRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.RerankV1RerankPostRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Jina.TextRerankerRequest? jinaColbertV1En = default;
            if (discriminator?.Model == global::Jina.RerankV1RerankPostRequestDiscriminatorModel.JinaColbertV1En)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.TextRerankerRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.TextRerankerRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.TextRerankerRequest)}");
                jinaColbertV1En = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.RerankerM0Request? jinaRerankerM0 = default;
            if (discriminator?.Model == global::Jina.RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerM0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.RerankerM0Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.RerankerM0Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.RerankerM0Request)}");
                jinaRerankerM0 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Jina.RerankerV3Request? jinaRerankerV3 = default;
            if (discriminator?.Model == global::Jina.RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerV3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.RerankerV3Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.RerankerV3Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Jina.RerankerV3Request)}");
                jinaRerankerV3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Jina.RerankV1RerankPostRequest(
                discriminator?.Model,
                jinaColbertV1En,

                jinaRerankerM0,

                jinaRerankerV3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.RerankV1RerankPostRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJinaColbertV1En)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.TextRerankerRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.TextRerankerRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.TextRerankerRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaColbertV1En!, typeInfo);
            }
            else if (value.IsJinaRerankerM0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.RerankerM0Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.RerankerM0Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.RerankerM0Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaRerankerM0!, typeInfo);
            }
            else if (value.IsJinaRerankerV3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.RerankerV3Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.RerankerV3Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.RerankerV3Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JinaRerankerV3!, typeInfo);
            }
        }
    }
}