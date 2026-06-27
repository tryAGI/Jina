
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
        public global::Jina.ClassificationPrediction? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>>? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>>? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClassificationPredictionLabel? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClassificationResponse? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ClassificationPrediction>? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClassifierSummary? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClipCreateTrainingRequest? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TextTrainingItem? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ImageTrainingItem? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClipCreateTrainingRequestModel? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClipV1Request? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClipV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV1RequestEmbeddingTypeItem>, object>? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClipV1RequestEmbeddingType? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ClipV1RequestEmbeddingTypeItem>? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClipV1RequestEmbeddingTypeItem? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TextDoc? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ImageDoc? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.PDFDoc? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClipV2Request? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClipV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV2RequestEmbeddingTypeItem>, object>? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClipV2RequestEmbeddingType? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ClipV2RequestEmbeddingTypeItem>? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClipV2RequestEmbeddingTypeItem? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClipZeroShotClassificationRequest? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClipZeroShotClassificationRequestModel? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.CodeEmbeddings1500MRequest? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings1500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>, object>? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.CodeEmbeddings1500MRequestEmbeddingType? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc>? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.CodeEmbeddings1500MRequestTask2? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequest? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>, object>? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequestEmbeddingType? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequestTask2? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.CodeEmbeddingsZeroShotClassificationRequest? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.CodeEmbeddingsZeroShotClassificationRequestModel? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ColbertV1Request? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>, object>? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ColbertV1RequestEmbeddingType? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ColbertV1RequestEmbeddingTypeItem? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ColbertV1RequestInputType2? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ColbertV2Request? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ColbertV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV2RequestEmbeddingTypeItem>, object>? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ColbertV2RequestEmbeddingType? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ColbertV2RequestEmbeddingTypeItem>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ColbertV2RequestEmbeddingTypeItem? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ColbertV2RequestInputType2? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ELSERV2EmbeddingUsage? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ELSERV2Request? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ELSERV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ELSERV2RequestEmbeddingTypeItem>, object>? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ELSERV2RequestEmbeddingType? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ELSERV2RequestEmbeddingTypeItem>? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ELSERV2RequestEmbeddingTypeItem? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ELSERV2RequestTask2? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingResponse? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.SingleEmbeddingData>, global::System.Collections.Generic.IList<global::Jina.MultiEmbeddingData>, global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>>? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.SingleEmbeddingData>? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.SingleEmbeddingData? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.MultiEmbeddingData>? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.MultiEmbeddingData? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingUsage, global::Jina.ELSERV2EmbeddingUsage, global::Jina.BaseUsage>? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingUsage? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV2CreateTrainingRequest? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.TextTrainingItem>? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV2CreateTrainingRequestModel? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV2Request? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>, object>? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV2RequestEmbeddingType? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV2RequestEmbeddingTypeItem? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV2RequestModel? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV2ZeroShotClassificationRequest? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV2ZeroShotClassificationRequestModel? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV3CreateTrainingRequest? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV3Request? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV3RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>, object>? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV3RequestEmbeddingType? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV3RequestEmbeddingTypeItem? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV3RequestTask2? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV3ZeroShotClassificationRequest? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV4CreateTrainingRequest? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV4Request? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV4RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>, object>? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV4RequestEmbeddingType? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV4RequestEmbeddingTypeItem? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV4RequestTask2? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV4ZeroShotClassificationRequest? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV5CreateTrainingRequest? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV5CreateTrainingRequestModel? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV5Request? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>, object>? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV5RequestEmbeddingType? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV5RequestEmbeddingTypeItem? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.VideoDoc? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>>? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.MergedContentGroup? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV5RequestModel? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV5RequestTask2? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV5ZeroShotClassificationRequest? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV5ZeroShotClassificationRequestModel? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ErrorResponse? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.FewShotClassificationRequest? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.HTTPValidationError? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.HTTPValidationErrorError>? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.HTTPValidationErrorError? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc>>? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc>? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ModelDatacenter? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ModelInfo? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTimeOffset? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ModelDatacenter>? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ModelPricing? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ModelListResponse? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ModelInfo>? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.RerankerM0Request? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.RerankerV3Request? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.RerankingResponse? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.RerankingResult>? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.RerankingResult? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, object>? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TextRerankerRequest? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TextRerankerRequestModel? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TrainingResponse? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.UpdateTrainingRequest? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>>? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClassifyV1ClassifyPostRequestVariant1?, global::Jina.FewShotClassificationRequest>? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClassifyV1ClassifyPostRequestVariant1? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClassifyV1ClassifyPostRequestVariant1Discriminator? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV1EmbeddingsPostRequest? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminator? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.RerankV1RerankPostRequest? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.RerankV1RerankPostRequestDiscriminator? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.RerankV1RerankPostRequestDiscriminatorModel? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TrainV1TrainPostRequestVariant1?, global::Jina.UpdateTrainingRequest>? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TrainV1TrainPostRequestVariant1? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TrainV1TrainPostRequestVariant1Discriminator? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.BatchStatus>? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ClassifierSummary>? Type186 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>>>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Jina.ClassificationPredictionLabel>>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ClassificationPrediction>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClipV1RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ClipV1RequestEmbeddingTypeItem>, object>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ClipV1RequestEmbeddingTypeItem>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClipV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ClipV2RequestEmbeddingTypeItem>, object>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ClipV2RequestEmbeddingTypeItem>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.List<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings1500MRequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>, object>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc>>>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc>>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings500MRequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>, object>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ColbertV1RequestEmbeddingTypeItem>, object>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ColbertV1RequestEmbeddingTypeItem>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ColbertV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ColbertV2RequestEmbeddingTypeItem>, object>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ColbertV2RequestEmbeddingTypeItem>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ELSERV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ELSERV2RequestEmbeddingTypeItem>, object>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ELSERV2RequestEmbeddingTypeItem>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.List<global::Jina.SingleEmbeddingData>, global::System.Collections.Generic.List<global::Jina.MultiEmbeddingData>, global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.SingleEmbeddingData>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.MultiEmbeddingData>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.TextTrainingItem>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>, object>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV3RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>, object>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV4RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>, object>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>, object>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.PDFDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>>>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.HTTPValidationErrorError>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc>>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ModelDatacenter>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ModelInfo>? ListType46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>? ListType47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.RerankingResult>? ListType50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.Dictionary<string, double>>? ListType51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.List<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>>? ListType52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.BatchStatus>? ListType53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ClassifierSummary>? ListType54 { get; set; }
    }
}