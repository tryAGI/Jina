
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
            typeof(global::Jina.JsonConverters.BatchEmbeddingRequestModelJsonConverter),
            typeof(global::Jina.JsonConverters.BatchEmbeddingRequestModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.BatchStatusStatusJsonConverter),
            typeof(global::Jina.JsonConverters.BatchStatusStatusNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ClipCreateTrainingRequestModelJsonConverter),
            typeof(global::Jina.JsonConverters.ClipCreateTrainingRequestModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ClipV1RequestEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.ClipV1RequestEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ClipV1RequestEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.ClipV1RequestEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ClipV2RequestEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.ClipV2RequestEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ClipV2RequestEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.ClipV2RequestEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ClipZeroShotClassificationRequestModelJsonConverter),
            typeof(global::Jina.JsonConverters.ClipZeroShotClassificationRequestModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddings1500MRequestEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddings1500MRequestEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddings1500MRequestEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddings1500MRequestEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddings1500MRequestTask2JsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddings1500MRequestTask2NullableJsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddings500MRequestEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddings500MRequestEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddings500MRequestEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddings500MRequestEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddings500MRequestTask2JsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddings500MRequestTask2NullableJsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddingsZeroShotClassificationRequestModelJsonConverter),
            typeof(global::Jina.JsonConverters.CodeEmbeddingsZeroShotClassificationRequestModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ColbertV1RequestEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.ColbertV1RequestEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ColbertV1RequestEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.ColbertV1RequestEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ColbertV1RequestInputType2JsonConverter),
            typeof(global::Jina.JsonConverters.ColbertV1RequestInputType2NullableJsonConverter),
            typeof(global::Jina.JsonConverters.ColbertV2RequestEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.ColbertV2RequestEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ColbertV2RequestEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.ColbertV2RequestEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ColbertV2RequestInputType2JsonConverter),
            typeof(global::Jina.JsonConverters.ColbertV2RequestInputType2NullableJsonConverter),
            typeof(global::Jina.JsonConverters.ELSERV2RequestEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.ELSERV2RequestEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ELSERV2RequestEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.ELSERV2RequestEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ELSERV2RequestTask2JsonConverter),
            typeof(global::Jina.JsonConverters.ELSERV2RequestTask2NullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV2CreateTrainingRequestModelJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV2CreateTrainingRequestModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV2RequestEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV2RequestEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV2RequestEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV2RequestEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV2RequestModelJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV2RequestModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV2ZeroShotClassificationRequestModelJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV2ZeroShotClassificationRequestModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV3RequestEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV3RequestEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV3RequestEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV3RequestEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV3RequestTask2JsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV3RequestTask2NullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV4RequestEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV4RequestEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV4RequestEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV4RequestEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV4RequestTask2JsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV4RequestTask2NullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV5CreateTrainingRequestModelJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV5CreateTrainingRequestModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV5RequestEmbeddingTypeJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV5RequestEmbeddingTypeNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV5RequestEmbeddingTypeItemJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV5RequestEmbeddingTypeItemNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV5RequestModelJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV5RequestModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV5RequestTask2JsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV5RequestTask2NullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV5ZeroShotClassificationRequestModelJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV5ZeroShotClassificationRequestModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TextRerankerRequestModelJsonConverter),
            typeof(global::Jina.JsonConverters.TextRerankerRequestModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModelJsonConverter),
            typeof(global::Jina.JsonConverters.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModelJsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.RerankV1RerankPostRequestDiscriminatorModelJsonConverter),
            typeof(global::Jina.JsonConverters.RerankV1RerankPostRequestDiscriminatorModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.TrainV1TrainPostRequestVariant1DiscriminatorModelJsonConverter),
            typeof(global::Jina.JsonConverters.TrainV1TrainPostRequestVariant1DiscriminatorModelNullableJsonConverter),
            typeof(global::Jina.JsonConverters.ClassifyV1ClassifyPostRequestVariant1JsonConverter),
            typeof(global::Jina.JsonConverters.EmbeddingsV1EmbeddingsPostRequestJsonConverter),
            typeof(global::Jina.JsonConverters.RerankV1RerankPostRequestJsonConverter),
            typeof(global::Jina.JsonConverters.TrainV1TrainPostRequestVariant1JsonConverter),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ClipV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV1RequestEmbeddingTypeItem>, object>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ClipV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV2RequestEmbeddingTypeItem>, object>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.CodeEmbeddings1500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>, object>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.CodeEmbeddings500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>, object>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>, object>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ColbertV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV2RequestEmbeddingTypeItem>, object>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ELSERV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ELSERV2RequestEmbeddingTypeItem>, object>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Jina.SingleEmbeddingData>, global::System.Collections.Generic.IList<global::Jina.MultiEmbeddingData>, global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.EmbeddingUsage, global::Jina.ELSERV2EmbeddingUsage, global::Jina.BaseUsage>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.EmbeddingsV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>, object>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.EmbeddingsV3RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>, object>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.EmbeddingsV4RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>, object>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>, object>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, object>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ClassifyV1ClassifyPostRequestVariant1?, global::Jina.FewShotClassificationRequest>),
            typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TrainV1TrainPostRequestVariant1?, global::Jina.UpdateTrainingRequest>),
            typeof(global::Jina.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.BaseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.BatchEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.BatchEmbeddingRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.BatchStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.BatchStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.BatchStatusStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassificationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassificationPredictionLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<double?, global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassificationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ClassificationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassifierSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipCreateTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TextTrainingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ImageTrainingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipCreateTrainingRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ClipV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV1RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipV1RequestEmbeddingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ClipV1RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipV1RequestEmbeddingTypeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TextDoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ImageDoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.PDFDoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ClipV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV2RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipV2RequestEmbeddingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ClipV2RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipV2RequestEmbeddingTypeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipZeroShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClipZeroShotClassificationRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddings1500MRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.CodeEmbeddings1500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddings1500MRequestEmbeddingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddings1500MRequestTask2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddings500MRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.CodeEmbeddings500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddings500MRequestEmbeddingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddings500MRequestTask2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ColbertV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ColbertV1RequestEmbeddingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ColbertV1RequestEmbeddingTypeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ColbertV1RequestInputType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ColbertV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ColbertV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV2RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ColbertV2RequestEmbeddingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ColbertV2RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ColbertV2RequestEmbeddingTypeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ColbertV2RequestInputType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ELSERV2EmbeddingUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ELSERV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ELSERV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ELSERV2RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ELSERV2RequestEmbeddingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ELSERV2RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ELSERV2RequestEmbeddingTypeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ELSERV2RequestTask2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.SingleEmbeddingData>, global::System.Collections.Generic.IList<global::Jina.MultiEmbeddingData>, global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.SingleEmbeddingData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.SingleEmbeddingData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.MultiEmbeddingData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.MultiEmbeddingData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.EmbeddingUsage, global::Jina.ELSERV2EmbeddingUsage, global::Jina.BaseUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2CreateTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.TextTrainingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2CreateTrainingRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.EmbeddingsV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2RequestEmbeddingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2RequestEmbeddingTypeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2RequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV3CreateTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.EmbeddingsV3RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV3RequestEmbeddingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV3RequestEmbeddingTypeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV3RequestTask2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV3ZeroShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV4CreateTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.EmbeddingsV4RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV4RequestEmbeddingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV4RequestEmbeddingTypeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV4RequestTask2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV4ZeroShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5CreateTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5CreateTrainingRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5RequestEmbeddingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5RequestEmbeddingTypeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5RequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5RequestTask2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.FewShotClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.HTTPValidationErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.HTTPValidationErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ModelDatacenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ModelDatacenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ModelPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ModelListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.RerankerM0Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.RerankerV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.RerankingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.RerankingResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.RerankingResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TextRerankerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TextRerankerRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TrainingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.UpdateTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ClassifyV1ClassifyPostRequestVariant1?, global::Jina.FewShotClassificationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV1EmbeddingsPostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.RerankV1RerankPostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.RerankV1RerankPostRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.RerankV1RerankPostRequestDiscriminatorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.TrainV1TrainPostRequestVariant1?, global::Jina.UpdateTrainingRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TrainV1TrainPostRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TrainV1TrainPostRequestVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.BatchStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Jina.ClassifierSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ClassificationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ClipV1RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ClipV1RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ClipV1RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ClipV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ClipV2RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ClipV2RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.List<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.CodeEmbeddings1500MRequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.CodeEmbeddings500MRequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ColbertV1RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ColbertV1RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ColbertV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ColbertV2RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ColbertV2RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.ELSERV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ELSERV2RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ELSERV2RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.List<global::Jina.SingleEmbeddingData>, global::System.Collections.Generic.List<global::Jina.MultiEmbeddingData>, global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.SingleEmbeddingData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.MultiEmbeddingData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.TextTrainingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.EmbeddingsV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.EmbeddingsV3RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.EmbeddingsV4RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.HTTPValidationErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ModelDatacenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.RerankingResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<string, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.List<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.BatchStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Jina.ClassifierSummary>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}