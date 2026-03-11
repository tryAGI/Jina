
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum RerankV1RerankPostRequestDiscriminatorModel
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
        /// <summary>
        /// 
        /// </summary>
        JinaRerankerM0,
        /// <summary>
        /// 
        /// </summary>
        JinaRerankerV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerankV1RerankPostRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerankV1RerankPostRequestDiscriminatorModel value)
        {
            return value switch
            {
                RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerV2BaseMultilingual => "jina-reranker-v2-base-multilingual",
                RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerV1TinyEn => "jina-reranker-v1-tiny-en",
                RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerV1TurboEn => "jina-reranker-v1-turbo-en",
                RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerV1BaseEn => "jina-reranker-v1-base-en",
                RerankV1RerankPostRequestDiscriminatorModel.JinaColbertV1En => "jina-colbert-v1-en",
                RerankV1RerankPostRequestDiscriminatorModel.JinaColbertV2 => "jina-colbert-v2",
                RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerM0 => "jina-reranker-m0",
                RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerV3 => "jina-reranker-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerankV1RerankPostRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-reranker-v2-base-multilingual" => RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerV2BaseMultilingual,
                "jina-reranker-v1-tiny-en" => RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerV1TinyEn,
                "jina-reranker-v1-turbo-en" => RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerV1TurboEn,
                "jina-reranker-v1-base-en" => RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerV1BaseEn,
                "jina-colbert-v1-en" => RerankV1RerankPostRequestDiscriminatorModel.JinaColbertV1En,
                "jina-colbert-v2" => RerankV1RerankPostRequestDiscriminatorModel.JinaColbertV2,
                "jina-reranker-m0" => RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerM0,
                "jina-reranker-v3" => RerankV1RerankPostRequestDiscriminatorModel.JinaRerankerV3,
                _ => null,
            };
        }
    }
}