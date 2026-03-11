
#nullable enable

namespace Jina
{
    /// <summary>
    /// The reranking model to use.
    /// </summary>
    public enum TextRerankerRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaRerankerV2BaseMultilingual,
        /// <summary>
        /// 
        /// </summary>
        JinaRerankerV1TinyEn,
        /// <summary>
        /// 
        /// </summary>
        JinaRerankerV1TurboEn,
        /// <summary>
        /// 
        /// </summary>
        JinaRerankerV1BaseEn,
        /// <summary>
        /// 
        /// </summary>
        JinaColbertV1En,
        /// <summary>
        /// 
        /// </summary>
        JinaColbertV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextRerankerRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextRerankerRequestModel value)
        {
            return value switch
            {
                TextRerankerRequestModel.JinaRerankerV2BaseMultilingual => "jina-reranker-v2-base-multilingual",
                TextRerankerRequestModel.JinaRerankerV1TinyEn => "jina-reranker-v1-tiny-en",
                TextRerankerRequestModel.JinaRerankerV1TurboEn => "jina-reranker-v1-turbo-en",
                TextRerankerRequestModel.JinaRerankerV1BaseEn => "jina-reranker-v1-base-en",
                TextRerankerRequestModel.JinaColbertV1En => "jina-colbert-v1-en",
                TextRerankerRequestModel.JinaColbertV2 => "jina-colbert-v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextRerankerRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-reranker-v2-base-multilingual" => TextRerankerRequestModel.JinaRerankerV2BaseMultilingual,
                "jina-reranker-v1-tiny-en" => TextRerankerRequestModel.JinaRerankerV1TinyEn,
                "jina-reranker-v1-turbo-en" => TextRerankerRequestModel.JinaRerankerV1TurboEn,
                "jina-reranker-v1-base-en" => TextRerankerRequestModel.JinaRerankerV1BaseEn,
                "jina-colbert-v1-en" => TextRerankerRequestModel.JinaColbertV1En,
                "jina-colbert-v2" => TextRerankerRequestModel.JinaColbertV2,
                _ => null,
            };
        }
    }
}