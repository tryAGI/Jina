
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ResponseFormatVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ResponseFormatJSONObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ResponseFormatJSONSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ChatCompletionRequestResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ChatCompletionRequestResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "ChatCompletionRequestResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.StreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::System.Collections.Generic.IList<global::Jina.ContentVariant2Item>, object>), TypeInfoPropertyName = "AnyOfStringIListContentVariant2ItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ContentVariant2Item), TypeInfoPropertyName = "ContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TextContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ImageContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ChatMessageContentVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ChatMessageContentVariant2ItemDiscriminatorType), TypeInfoPropertyName = "ChatMessageContentVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ChatMessageRole), TypeInfoPropertyName = "ChatMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.HTTPValidationErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.HTTPValidationErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ImageURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.JSONSchemaSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ChatCompletionRequestResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableChatCompletionRequestResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::System.Collections.Generic.IList<global::Jina.ContentVariant2Item>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListContentVariant2ItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ContentVariant2Item?), TypeInfoPropertyName = "NullableContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ChatMessageContentVariant2ItemDiscriminatorType?), TypeInfoPropertyName = "NullableChatMessageContentVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ChatMessageRole?), TypeInfoPropertyName = "NullableChatMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::System.Collections.Generic.List<global::Jina.ContentVariant2Item>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.HTTPValidationErrorError>))]
    internal sealed partial class GenerativeModelsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerativeModelsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GenerativeModelsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GenerativeModelsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Jina.JsonConverters.ResponseFormatVariant1JsonConverter());
            options.Converters.Add(new global::Jina.JsonConverters.ContentVariant2ItemJsonConverter());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Jina.ContentVariant2Item>, object>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::Jina.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Jina.ChatCompletionRequestResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Jina.ChatCompletionRequestResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Jina.ChatMessageContentVariant2ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Jina.ChatMessageContentVariant2ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Jina.ChatMessageRole)

                    || typeToConvert == typeof(global::Jina.ChatMessageRole?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Jina.ChatCompletionRequestResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Jina.JsonConverters.ChatCompletionRequestResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.ChatCompletionRequestResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Jina.JsonConverters.ChatCompletionRequestResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.ChatMessageContentVariant2ItemDiscriminatorType))
                {
                    return new global::Jina.JsonConverters.ChatMessageContentVariant2ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.ChatMessageContentVariant2ItemDiscriminatorType?))
                {
                    return new global::Jina.JsonConverters.ChatMessageContentVariant2ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.ChatMessageRole))
                {
                    return new global::Jina.JsonConverters.ChatMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.ChatMessageRole?))
                {
                    return new global::Jina.JsonConverters.ChatMessageRoleNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new GenerativeModelsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}