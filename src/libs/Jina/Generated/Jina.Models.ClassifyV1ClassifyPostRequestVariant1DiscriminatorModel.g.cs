
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaClipV1,
        /// <summary>
        /// 
        /// </summary>
        JinaClipV2,
        /// <summary>
        /// 
        /// </summary>
        JinaCodeEmbeddings05b,
        /// <summary>
        /// 
        /// </summary>
        JinaCodeEmbeddings15b,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV2BaseCode,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV2BaseDe,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV2BaseEn,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV2BaseEs,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV2BaseZh,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV3,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV4,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV5TextNano,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV5TextSmall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifyV1ClassifyPostRequestVariant1DiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel value)
        {
            return value switch
            {
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaClipV1 => "jina-clip-v1",
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaClipV2 => "jina-clip-v2",
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaCodeEmbeddings05b => "jina-code-embeddings-0.5b",
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaCodeEmbeddings15b => "jina-code-embeddings-1.5b",
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseCode => "jina-embeddings-v2-base-code",
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseDe => "jina-embeddings-v2-base-de",
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseEn => "jina-embeddings-v2-base-en",
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseEs => "jina-embeddings-v2-base-es",
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseZh => "jina-embeddings-v2-base-zh",
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV3 => "jina-embeddings-v3",
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV4 => "jina-embeddings-v4",
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV5TextNano => "jina-embeddings-v5-text-nano",
                ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV5TextSmall => "jina-embeddings-v5-text-small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-clip-v1" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaClipV1,
                "jina-clip-v2" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaClipV2,
                "jina-code-embeddings-0.5b" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaCodeEmbeddings05b,
                "jina-code-embeddings-1.5b" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaCodeEmbeddings15b,
                "jina-embeddings-v2-base-code" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseCode,
                "jina-embeddings-v2-base-de" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseDe,
                "jina-embeddings-v2-base-en" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseEn,
                "jina-embeddings-v2-base-es" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseEs,
                "jina-embeddings-v2-base-zh" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseZh,
                "jina-embeddings-v3" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV3,
                "jina-embeddings-v4" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV4,
                "jina-embeddings-v5-text-nano" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV5TextNano,
                "jina-embeddings-v5-text-small" => ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV5TextSmall,
                _ => null,
            };
        }
    }
}