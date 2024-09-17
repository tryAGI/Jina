
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
        public global::Jina.BodyStartBulkEmbeddingV1BulkEmbeddingsPost? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.BulkEmbeddingJobResponse? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AllOf<global::Jina.BulkEmbeddingJobStatus?>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.BulkEmbeddingJobStatus? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ColbertModelEmbeddingsOutput? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ColbertModelEmbeddingsOutputDataItem>? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ColbertModelEmbeddingsOutputDataItem? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AllOf<global::Jina.ApiSchemasEmbeddingUsage>? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ApiSchemasEmbeddingUsage? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.DownloadResultResponse? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.EmbeddingInput? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TextEmbeddingInput? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::Jina.ApiSchemasEmbeddingTextDoc>, global::Jina.ApiSchemasEmbeddingTextDoc>? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ApiSchemasEmbeddingTextDoc>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ApiSchemasEmbeddingTextDoc? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TextEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.TextEmbeddingInputEmbeddingTypeItem>>? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TextEmbeddingInputEmbeddingType? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.TextEmbeddingInputEmbeddingTypeItem>? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TextEmbeddingInputEmbeddingTypeItem? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TextEmbeddingInputTask? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ImageEmbeddingInput? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ImageDoc, global::System.Collections.Generic.IList<global::Jina.ImageDoc>>? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ImageDoc? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, byte[]>? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ImageDoc>? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ImageEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ImageEmbeddingInputEmbeddingTypeItem>>? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ImageEmbeddingInputEmbeddingType? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ImageEmbeddingInputEmbeddingTypeItem>? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ImageEmbeddingInputEmbeddingTypeItem? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.MixedEmbeddingInput? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.ImageDoc, global::Jina.ApiSchemasEmbeddingTextDoc, string>>? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.ImageDoc, global::Jina.ApiSchemasEmbeddingTextDoc, string>? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.MixedEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.MixedEmbeddingInputEmbeddingTypeItem>>? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.MixedEmbeddingInputEmbeddingType? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.MixedEmbeddingInputEmbeddingTypeItem>? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.MixedEmbeddingInputEmbeddingTypeItem? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.HTTPValidationError? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ValidationError>? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ValidationError? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<string, int?>>? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, int?>? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.HealthModel? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ModelEmbeddingOutput? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ModelEmbeddingOutputDataItem>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ModelEmbeddingOutputDataItem? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.RankAPIInput? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<string, global::Jina.ApiSchemasRankTextDoc>? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ApiSchemasRankTextDoc? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Jina.ApiSchemasRankTextDoc>>? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.ApiSchemasRankTextDoc>? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.RankingOutput? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.RankingOutputResult>? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.RankingOutputResult? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AllOf<global::Jina.ApiSchemasRankUsage>? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ApiSchemasRankUsage? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TextEmbeddingAPIInput? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TextEmbeddingAPIInputInputType? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.AnyOf<global::Jina.TextEmbeddingAPIInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.TextEmbeddingAPIInputEmbeddingTypeItem>>? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TextEmbeddingAPIInputEmbeddingType? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Jina.TextEmbeddingAPIInputEmbeddingTypeItem>? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TextEmbeddingAPIInputEmbeddingTypeItem? Type66 { get; set; }
    }
}