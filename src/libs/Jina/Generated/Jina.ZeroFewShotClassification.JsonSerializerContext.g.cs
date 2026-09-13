
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.BaseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassificationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>>), TypeInfoPropertyName = "AnyOfStringDictionaryStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>>), TypeInfoPropertyName = "AnyOfIListClassificationPredictionLabelDictionaryStringIListClassificationPredictionLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassificationPredictionLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<double?, global::System.Collections.Generic.Dictionary<string, double>>), TypeInfoPropertyName = "AnyOfDoubleDictionaryStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassificationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ClassificationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassifierSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipCreateTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>), TypeInfoPropertyName = "AnyOfTextTrainingItemImageTrainingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TextTrainingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ImageTrainingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipCreateTrainingRequestModel), TypeInfoPropertyName = "ClipCreateTrainingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TextDoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ImageDoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>), TypeInfoPropertyName = "AnyOfStringTextDocImageDoc2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipZeroShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>), TypeInfoPropertyName = "AnyOfStringTextDocImageDocIListAnyOfStringTextDocImageDoc2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>), TypeInfoPropertyName = "AnyOfIListStringDictionaryStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipZeroShotClassificationRequestModel), TypeInfoPropertyName = "ClipZeroShotClassificationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>), TypeInfoPropertyName = "AnyOfStringTextDocIListAnyOfStringTextDoc2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc>), TypeInfoPropertyName = "AnyOfStringTextDoc2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequestModel), TypeInfoPropertyName = "CodeEmbeddingsZeroShotClassificationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2CreateTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.TextTrainingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2CreateTrainingRequestModel), TypeInfoPropertyName = "EmbeddingsV2CreateTrainingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequestModel), TypeInfoPropertyName = "EmbeddingsV2ZeroShotClassificationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV3CreateTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV3ZeroShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV4CreateTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV4ZeroShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5CreateTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5CreateTrainingRequestModel), TypeInfoPropertyName = "EmbeddingsV5CreateTrainingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequestModel), TypeInfoPropertyName = "EmbeddingsV5ZeroShotClassificationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.FewShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.HTTPValidationErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.HTTPValidationErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TrainingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.UpdateTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>>), TypeInfoPropertyName = "AnyOfTextTrainingItemImageTrainingItemIListAnyOfTextTrainingItemImageTrainingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ClassifyV1ClassifyPostRequestVariant1?, global::Jina.FewShotClassificationRequest>), TypeInfoPropertyName = "AnyOfClassifyV1ClassifyPostRequestVariant1FewShotClassificationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1), TypeInfoPropertyName = "ClassifyV1ClassifyPostRequestVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel), TypeInfoPropertyName = "ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.TrainV1TrainPostRequestVariant1?, global::Jina.UpdateTrainingRequest>), TypeInfoPropertyName = "AnyOfTrainV1TrainPostRequestVariant1UpdateTrainingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TrainV1TrainPostRequestVariant1), TypeInfoPropertyName = "TrainV1TrainPostRequestVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TrainV1TrainPostRequestVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel), TypeInfoPropertyName = "TrainV1TrainPostRequestVariant1DiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ClassifierSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>>?), TypeInfoPropertyName = "NullableAnyOfStringDictionaryStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>>?), TypeInfoPropertyName = "NullableAnyOfIListClassificationPredictionLabelDictionaryStringIListClassificationPredictionLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<double?, global::System.Collections.Generic.Dictionary<string, double>>?), TypeInfoPropertyName = "NullableAnyOfDoubleDictionaryStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>?), TypeInfoPropertyName = "NullableAnyOfTextTrainingItemImageTrainingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipCreateTrainingRequestModel?), TypeInfoPropertyName = "NullableClipCreateTrainingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>?), TypeInfoPropertyName = "NullableAnyOfStringTextDocImageDoc2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>?), TypeInfoPropertyName = "NullableAnyOfStringTextDocImageDocIListAnyOfStringTextDocImageDoc2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>?), TypeInfoPropertyName = "NullableAnyOfIListStringDictionaryStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipZeroShotClassificationRequestModel?), TypeInfoPropertyName = "NullableClipZeroShotClassificationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>?), TypeInfoPropertyName = "NullableAnyOfStringTextDocIListAnyOfStringTextDoc2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc>?), TypeInfoPropertyName = "NullableAnyOfStringTextDoc2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequestModel?), TypeInfoPropertyName = "NullableCodeEmbeddingsZeroShotClassificationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2CreateTrainingRequestModel?), TypeInfoPropertyName = "NullableEmbeddingsV2CreateTrainingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequestModel?), TypeInfoPropertyName = "NullableEmbeddingsV2ZeroShotClassificationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5CreateTrainingRequestModel?), TypeInfoPropertyName = "NullableEmbeddingsV5CreateTrainingRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequestModel?), TypeInfoPropertyName = "NullableEmbeddingsV5ZeroShotClassificationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>>?), TypeInfoPropertyName = "NullableAnyOfTextTrainingItemImageTrainingItemIListAnyOfTextTrainingItemImageTrainingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ClassifyV1ClassifyPostRequestVariant1?, global::Jina.FewShotClassificationRequest>?), TypeInfoPropertyName = "NullableAnyOfClassifyV1ClassifyPostRequestVariant1FewShotClassificationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1?), TypeInfoPropertyName = "NullableClassifyV1ClassifyPostRequestVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel?), TypeInfoPropertyName = "NullableClassifyV1ClassifyPostRequestVariant1DiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.TrainV1TrainPostRequestVariant1?, global::Jina.UpdateTrainingRequest>?), TypeInfoPropertyName = "NullableAnyOfTrainV1TrainPostRequestVariant1UpdateTrainingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TrainV1TrainPostRequestVariant1?), TypeInfoPropertyName = "NullableTrainV1TrainPostRequestVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel?), TypeInfoPropertyName = "NullableTrainV1TrainPostRequestVariant1DiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ClassificationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.List<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.TextTrainingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.HTTPValidationErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.List<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ClassifierSummary>))]
    internal sealed partial class ZeroFewShotClassificationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ZeroFewShotClassificationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ZeroFewShotClassificationSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ZeroFewShotClassificationSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Jina.JsonConverters.ClassifyV1ClassifyPostRequestVariant1JsonConverter());
            options.Converters.Add(new global::Jina.JsonConverters.TrainV1TrainPostRequestVariant1JsonConverter());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.ImageDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, object>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ClassifyV1ClassifyPostRequestVariant1?, global::Jina.FewShotClassificationRequest>());
            options.Converters.Add(new global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TrainV1TrainPostRequestVariant1?, global::Jina.UpdateTrainingRequest>());
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
                    typeToConvert == typeof(global::Jina.ClipCreateTrainingRequestModel)

                    || typeToConvert == typeof(global::Jina.ClipCreateTrainingRequestModel?)

                    || typeToConvert == typeof(global::Jina.ClipZeroShotClassificationRequestModel)

                    || typeToConvert == typeof(global::Jina.ClipZeroShotClassificationRequestModel?)

                    || typeToConvert == typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequestModel)

                    || typeToConvert == typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequestModel?)

                    || typeToConvert == typeof(global::Jina.EmbeddingsV2CreateTrainingRequestModel)

                    || typeToConvert == typeof(global::Jina.EmbeddingsV2CreateTrainingRequestModel?)

                    || typeToConvert == typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequestModel)

                    || typeToConvert == typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequestModel?)

                    || typeToConvert == typeof(global::Jina.EmbeddingsV5CreateTrainingRequestModel)

                    || typeToConvert == typeof(global::Jina.EmbeddingsV5CreateTrainingRequestModel?)

                    || typeToConvert == typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequestModel)

                    || typeToConvert == typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequestModel?)

                    || typeToConvert == typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel)

                    || typeToConvert == typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel?)

                    || typeToConvert == typeof(global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel)

                    || typeToConvert == typeof(global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Jina.ClipCreateTrainingRequestModel))
                {
                    return new global::Jina.JsonConverters.ClipCreateTrainingRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.ClipCreateTrainingRequestModel?))
                {
                    return new global::Jina.JsonConverters.ClipCreateTrainingRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.ClipZeroShotClassificationRequestModel))
                {
                    return new global::Jina.JsonConverters.ClipZeroShotClassificationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.ClipZeroShotClassificationRequestModel?))
                {
                    return new global::Jina.JsonConverters.ClipZeroShotClassificationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequestModel))
                {
                    return new global::Jina.JsonConverters.CodeEmbeddingsZeroShotClassificationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequestModel?))
                {
                    return new global::Jina.JsonConverters.CodeEmbeddingsZeroShotClassificationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.EmbeddingsV2CreateTrainingRequestModel))
                {
                    return new global::Jina.JsonConverters.EmbeddingsV2CreateTrainingRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.EmbeddingsV2CreateTrainingRequestModel?))
                {
                    return new global::Jina.JsonConverters.EmbeddingsV2CreateTrainingRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequestModel))
                {
                    return new global::Jina.JsonConverters.EmbeddingsV2ZeroShotClassificationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequestModel?))
                {
                    return new global::Jina.JsonConverters.EmbeddingsV2ZeroShotClassificationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.EmbeddingsV5CreateTrainingRequestModel))
                {
                    return new global::Jina.JsonConverters.EmbeddingsV5CreateTrainingRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.EmbeddingsV5CreateTrainingRequestModel?))
                {
                    return new global::Jina.JsonConverters.EmbeddingsV5CreateTrainingRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequestModel))
                {
                    return new global::Jina.JsonConverters.EmbeddingsV5ZeroShotClassificationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequestModel?))
                {
                    return new global::Jina.JsonConverters.EmbeddingsV5ZeroShotClassificationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel))
                {
                    return new global::Jina.JsonConverters.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel?))
                {
                    return new global::Jina.JsonConverters.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel))
                {
                    return new global::Jina.JsonConverters.TrainV1TrainPostRequestVariant1DiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel?))
                {
                    return new global::Jina.JsonConverters.TrainV1TrainPostRequestVariant1DiscriminatorModelNullableJsonConverter();
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
                    0 => new ZeroFewShotClassificationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}