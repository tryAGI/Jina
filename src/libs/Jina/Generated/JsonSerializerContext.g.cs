
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
            typeof(global::Jina.JsonConverters.ImageEmbeddingInputTaskJsonConverter),
            typeof(global::Jina.JsonConverters.ImageEmbeddingInputTaskNullableJsonConverter),
            typeof(global::Jina.JsonConverters.MixedEmbeddingInputEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.MixedEmbeddingInputEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.MixedEmbeddingInputEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.MixedEmbeddingInputEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.MixedEmbeddingInputTaskJsonConverter),
            typeof(global::Jina.JsonConverters.MixedEmbeddingInputTaskNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingAPIInputInputTypeJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingAPIInputInputTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingAPIInputEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingAPIInputEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingAPIInputEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.TextEmbeddingAPIInputEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TrainingAPIInputAccessJsonConverter),
            typeof(global::Jina.JsonConverters.TrainingAPIInputAccessNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingInputJsonConverter),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.ApiSchemasClassificationTextDoc, global::Jina.ApiSchemasClassificationImageDoc, string>>, global::Jina.ApiSchemasClassificationTextDoc, global::Jina.ApiSchemasClassificationImageDoc, string>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ApiSchemasClassificationTextDoc, global::Jina.ApiSchemasClassificationImageDoc, string>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, byte[]>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::Jina.ApiSchemasEmbeddingTextDoc>, global::Jina.ApiSchemasEmbeddingTextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TextEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.TextEmbeddingInputEmbeddingTypeItem>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ApiSchemasImageImageDoc, global::System.Collections.Generic.IList<global::Jina.ApiSchemasImageImageDoc>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, byte[]>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ImageEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ImageEmbeddingInputEmbeddingTypeItem>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ApiSchemasImageImageDoc, global::Jina.ApiSchemasEmbeddingTextDoc, string>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.MixedEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.MixedEmbeddingInputEmbeddingTypeItem>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, int?>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, byte[]>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.ApiSchemasRankTextDoc, global::Jina.ApiSchemasImageImageDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ApiSchemasImageImageDoc, global::Jina.ApiSchemasRankTextDoc, string>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::Jina.ApiSchemasEmbeddingTextDoc>, global::Jina.ApiSchemasEmbeddingTextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TextEmbeddingAPIInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.TextEmbeddingAPIInputEmbeddingTypeItem>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextExampleDoc, global::Jina.ImageExampleDoc>>, global::Jina.TextExampleDoc, global::Jina.ImageExampleDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TextExampleDoc, global::Jina.ImageExampleDoc>),
            typeof(global::Jina.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}