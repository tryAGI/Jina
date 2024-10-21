
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
            typeof(global::Jina.JsonConverters.BulkEmbeddingJobStatusJsonConverter),
            typeof(global::Jina.JsonConverters.BulkEmbeddingJobStatusNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingInputEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingInputEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingInputEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingInputEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingInputTaskJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingInputTaskNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ImageEmbeddingInputEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.ImageEmbeddingInputEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ImageEmbeddingInputEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.ImageEmbeddingInputEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.MixedEmbeddingInputEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.MixedEmbeddingInputEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.MixedEmbeddingInputEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.MixedEmbeddingInputEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingAPIInputInputTypeJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingAPIInputInputTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingAPIInputEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingAPIInputEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingAPIInputEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingAPIInputEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TrainingAPIInputAccessJsonConverter),
            typeof(global::Jina.JsonConverters.TrainingAPIInputAccessNullableJsonConverter),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverterFactory4),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverterFactory3),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverterFactory2),
            typeof(global::Jina.JsonConverters.EmbeddingInputJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}