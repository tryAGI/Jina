
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
        public global::Jina.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type23 { get; set; }
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
        public global::Jina.AnyOf<string, global::System.Collections.Generic.IList<global::Jina.ContentVariant2Item>>? Type26 { get; set; }
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
        public global::Jina.ClipV1Request? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClipV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV1RequestEmbeddingTypeItem>>? Type35 { get; set; }
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
        public global::Jina.AnyOf<global::Jina.ClipV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV2RequestEmbeddingTypeItem>>? Type46 { get; set; }
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
        public global::Jina.CodeEmbeddings1500MRequest? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings1500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings1500MRequestEmbeddingType? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings1500MRequestTask? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequest? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequestEmbeddingType? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequestTask? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV1Request? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV1RequestEmbeddingType? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV1RequestEmbeddingTypeItem? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV1RequestInputType? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV2Request? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ColbertV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV2RequestEmbeddingTypeItem>>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV2RequestEmbeddingType? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ColbertV2RequestEmbeddingTypeItem>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV2RequestEmbeddingTypeItem? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV2RequestInputType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ELSERV2EmbeddingUsage? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingResponse? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.SingleEmbeddingData>, global::System.Collections.Generic.IList<global::Jina.MultiEmbeddingData>, global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.SingleEmbeddingData>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.SingleEmbeddingData? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.MultiEmbeddingData>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.MultiEmbeddingData? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingUsage, global::Jina.ELSERV2EmbeddingUsage, global::Jina.BaseUsage>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingUsage? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2Request? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2RequestEmbeddingType? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2RequestEmbeddingTypeItem? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2RequestModel? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV3Request? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV3RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV3RequestEmbeddingType? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV3RequestEmbeddingTypeItem? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV3RequestTask? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV4Request? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV4RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV4RequestEmbeddingType? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV4RequestEmbeddingTypeItem? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV4RequestTask? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5Request? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5RequestEmbeddingType? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5RequestEmbeddingTypeItem? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.VideoDoc? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.MergedContentGroup? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5RequestModel? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5RequestTask? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ErrorResponse? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.FieldError>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.FieldError? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ImageURL? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.JSONSchemaSpec? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc>>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ModelDatacenter? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ModelInfo? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ModelDatacenter>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ModelPricing? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ModelListResponse? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ModelInfo>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.OpenAIError? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.OpenAIErrorResponse? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankerM0Request? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.ImageDoc>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankerV3Request? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankerV3RequestModel? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankingResponse? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.RerankingResult>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankingResult? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.TextRerankerRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.TextRerankerRequestModel? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV1EmbeddingsPostRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminator? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankV1RerankPostRequest? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankV1RerankPostRequestDiscriminator? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.RerankV1RerankPostRequestDiscriminatorModel? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.BatchStatus>? Type151 { get; set; }

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
        public global::Jina.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.List<global::Jina.ContentVariant2Item>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ContentVariant2Item>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClipV1RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ClipV1RequestEmbeddingTypeItem>>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ClipV1RequestEmbeddingTypeItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ClipV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ClipV2RequestEmbeddingTypeItem>>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ClipV2RequestEmbeddingTypeItem>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings1500MRequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc>>>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc>>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings500MRequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ColbertV1RequestEmbeddingTypeItem>>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ColbertV1RequestEmbeddingTypeItem>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ColbertV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.ColbertV2RequestEmbeddingTypeItem>>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ColbertV2RequestEmbeddingTypeItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.List<global::Jina.SingleEmbeddingData>, global::System.Collections.Generic.List<global::Jina.MultiEmbeddingData>, global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.SingleEmbeddingData>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.MultiEmbeddingData>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV2RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV3RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV4RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.List<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.PDFDoc, global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>>>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.FieldError>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.AnyOf<global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc>>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ModelDatacenter>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.ModelInfo>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.RerankingResult>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Jina.AnyOf<string, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.Dictionary<string, double>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.BatchStatus>? ListType45 { get; set; }
    }
}