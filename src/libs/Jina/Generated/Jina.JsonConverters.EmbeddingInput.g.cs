#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Jina.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Jina.EmbeddingInput>
    {
        /// <inheritdoc />
        public override global::Jina.EmbeddingInput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Jina.TextEmbeddingInput? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.TextEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.TextEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.TextEmbeddingInput).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Jina.ImageEmbeddingInput? image = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ImageEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ImageEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ImageEmbeddingInput).Name}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Jina.MixedEmbeddingInput? mixed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.MixedEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.MixedEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.MixedEmbeddingInput).Name}");
                mixed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Jina.EmbeddingInput(
                text,
                image,
                mixed
                );

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.TextEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.TextEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.TextEmbeddingInput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (image != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ImageEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ImageEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ImageEmbeddingInput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (mixed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.MixedEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.MixedEmbeddingInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.MixedEmbeddingInput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Jina.EmbeddingInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.TextEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.TextEmbeddingInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.TextEmbeddingInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.ImageEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.ImageEmbeddingInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.ImageEmbeddingInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
            else if (value.IsMixed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Jina.MixedEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Jina.MixedEmbeddingInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Jina.MixedEmbeddingInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mixed, typeInfo);
            }
        }
    }
}