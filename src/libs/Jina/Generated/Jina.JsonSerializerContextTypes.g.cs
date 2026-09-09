
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.AudioDoc? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.BaseUsage? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.BatchEmbeddingRequest? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.BatchEmbeddingRequestModel? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.BatchStats? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.BatchStatus? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.BatchStatusStatus? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ChatCompletionRequest? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ChatMessage>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ChatMessage? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ResponseFormatVariant1? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ResponseFormatText? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ResponseFormatJSONObject? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ResponseFormatJSONSchema? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ChatCompletionRequestResponseFormatVariant1Discriminator? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ChatCompletionRequestResponseFormatVariant1DiscriminatorType? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.StreamOptions? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.IList<global::Jina.ContentVariant2Item>, object>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ContentVariant2Item>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ContentVariant2Item? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.TextContentPart? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ImageContentPart? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ChatMessageContentVariant2ItemDiscriminator? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ChatMessageContentVariant2ItemDiscriminatorType? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ChatMessageRole? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClassificationPrediction? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClassificationPredictionLabel? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClassificationResponse? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ClassificationPrediction>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClassifierSummary? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClipCreateTrainingRequest? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.TextTrainingItem? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ImageTrainingItem? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClipCreateTrainingRequestModel? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClipV1Request? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClipV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV1RequestEmbeddingTypeItem>, object>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClipV1RequestEmbeddingType? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ClipV1RequestEmbeddingTypeItem>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClipV1RequestEmbeddingTypeItem? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.TextDoc? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ImageDoc? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.PDFDoc? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClipV2Request? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClipV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV2RequestEmbeddingTypeItem>, object>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClipV2RequestEmbeddingType? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ClipV2RequestEmbeddingTypeItem>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClipV2RequestEmbeddingTypeItem? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClipZeroShotClassificationRequest? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClipZeroShotClassificationRequestModel? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings1500MRequest? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings1500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>, object>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings1500MRequestEmbeddingType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings1500MRequestTask? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequest? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>, object>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequestEmbeddingType? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequestTask? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddingsZeroShotClassificationRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddingsZeroShotClassificationRequestModel? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV1Request? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>, object>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV1RequestEmbeddingType? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV1RequestEmbeddingTypeItem? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV1RequestInputType? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV2Request? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ColbertV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV2RequestEmbeddingTypeItem>, object>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV2RequestEmbeddingType? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ColbertV2RequestEmbeddingTypeItem>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV2RequestEmbeddingTypeItem? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV2RequestInputType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ELSERV2EmbeddingUsage? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ELSERV2Request? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ELSERV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ELSERV2RequestEmbeddingTypeItem>, object>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ELSERV2RequestEmbeddingType? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ELSERV2RequestEmbeddingTypeItem>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ELSERV2RequestEmbeddingTypeItem? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ELSERV2RequestTask? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingResponse? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.SingleEmbeddingData>, global::System.Collections.Generic.IList<global::Jina.MultiEmbeddingData>, global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.SingleEmbeddingData>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.SingleEmbeddingData? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.MultiEmbeddingData>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.MultiEmbeddingData? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingUsage, global::Jina.ELSERV2EmbeddingUsage, global::Jina.BaseUsage>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingUsage? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2CreateTrainingRequest? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.TextTrainingItem>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2CreateTrainingRequestModel? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2Request? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>, object>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2RequestEmbeddingType? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2RequestEmbeddingTypeItem? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2RequestModel? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2ZeroShotClassificationRequest? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2ZeroShotClassificationRequestModel? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV3CreateTrainingRequest? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV3Request? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV3RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>, object>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV3RequestEmbeddingType? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV3RequestEmbeddingTypeItem? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV3RequestTask? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV3ZeroShotClassificationRequest? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV4CreateTrainingRequest? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV4Request? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV4RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>, object>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV4RequestEmbeddingType? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV4RequestEmbeddingTypeItem? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV4RequestTask? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV4ZeroShotClassificationRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5CreateTrainingRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5CreateTrainingRequestModel? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5Request? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>, object>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5RequestEmbeddingType? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5RequestEmbeddingTypeItem? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.VideoDoc? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.MergedContentGroup? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5RequestModel? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5RequestTask? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5ZeroShotClassificationRequest? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5ZeroShotClassificationRequestModel? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ErrorResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.FewShotClassificationRequest? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.HTTPValidationError? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.HTTPValidationErrorError>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.HTTPValidationErrorError? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ImageURL? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.JSONSchemaSpec? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc>>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ModelDatacenter? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ModelInfo? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ModelDatacenter>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ModelPricing? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ModelListResponse? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ModelInfo>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankerM0Request? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.ImageDoc>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankerV3Request? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankerV3RequestModel? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankingResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.RerankingResult>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankingResult? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, object>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.TextRerankerRequest? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.TextRerankerRequestModel? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.TrainingResponse? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.UpdateTrainingRequest? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClassifyV1ClassifyPostRequestVariant1?, global::Jina.FewShotClassificationRequest>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClassifyV1ClassifyPostRequestVariant1? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClassifyV1ClassifyPostRequestVariant1Discriminator? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV1EmbeddingsPostRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminator? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankV1RerankPostRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankV1RerankPostRequestDiscriminator? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankV1RerankPostRequestDiscriminatorModel? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TrainV1TrainPostRequestVariant1?, global::Jina.UpdateTrainingRequest>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.TrainV1TrainPostRequestVariant1? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.TrainV1TrainPostRequestVariant1Discriminator? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.BatchStatus>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ClassifierSummary>? Type209 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ChatMessage>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.List<string>, object>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.List<global::Jina.ContentVariant2Item>, object>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ContentVariant2Item>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>>>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ClassificationPrediction>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClipV1RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ClipV1RequestEmbeddingTypeItem>, object>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ClipV1RequestEmbeddingTypeItem>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClipV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ClipV2RequestEmbeddingTypeItem>, object>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ClipV2RequestEmbeddingTypeItem>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.List<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings1500MRequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>, object>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc>>>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc>>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings500MRequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>, object>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ColbertV1RequestEmbeddingTypeItem>, object>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ColbertV1RequestEmbeddingTypeItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ColbertV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ColbertV2RequestEmbeddingTypeItem>, object>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ColbertV2RequestEmbeddingTypeItem>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ELSERV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ELSERV2RequestEmbeddingTypeItem>, object>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ELSERV2RequestEmbeddingTypeItem>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.List<global::Jina.SingleEmbeddingData>, global::System.Collections.Generic.List<global::Jina.MultiEmbeddingData>, global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.SingleEmbeddingData>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.MultiEmbeddingData>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.TextTrainingItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>, object>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV3RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>, object>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV4RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>, object>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>, object>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.PDFDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>>>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.HTTPValidationErrorError>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc>>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ModelDatacenter>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ModelInfo>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.RerankingResult>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.Dictionary<string, double>>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.List<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.BatchStatus>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ClassifierSummary>? ListType58 { get; set; }
    }
}