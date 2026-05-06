
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        ElserV2,
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
        JinaColbertV1En,
        /// <summary>
        /// 
        /// </summary>
        JinaColbertV2,
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
        JinaEmbeddingsV5OmniSmall,
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
    public static class EmbeddingsV1EmbeddingsPostRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel value)
        {
            return value switch
            {
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.ElserV2 => "elser-v2",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaClipV1 => "jina-clip-v1",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaClipV2 => "jina-clip-v2",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaCodeEmbeddings05b => "jina-code-embeddings-0.5b",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaCodeEmbeddings15b => "jina-code-embeddings-1.5b",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaColbertV1En => "jina-colbert-v1-en",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaColbertV2 => "jina-colbert-v2",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV2BaseCode => "jina-embeddings-v2-base-code",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV2BaseDe => "jina-embeddings-v2-base-de",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV2BaseEn => "jina-embeddings-v2-base-en",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV2BaseEs => "jina-embeddings-v2-base-es",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV2BaseZh => "jina-embeddings-v2-base-zh",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV3 => "jina-embeddings-v3",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV4 => "jina-embeddings-v4",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV5OmniSmall => "jina-embeddings-v5-omni-small",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV5TextNano => "jina-embeddings-v5-text-nano",
                EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV5TextSmall => "jina-embeddings-v5-text-small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "elser-v2" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.ElserV2,
                "jina-clip-v1" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaClipV1,
                "jina-clip-v2" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaClipV2,
                "jina-code-embeddings-0.5b" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaCodeEmbeddings05b,
                "jina-code-embeddings-1.5b" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaCodeEmbeddings15b,
                "jina-colbert-v1-en" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaColbertV1En,
                "jina-colbert-v2" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaColbertV2,
                "jina-embeddings-v2-base-code" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV2BaseCode,
                "jina-embeddings-v2-base-de" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV2BaseDe,
                "jina-embeddings-v2-base-en" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV2BaseEn,
                "jina-embeddings-v2-base-es" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV2BaseEs,
                "jina-embeddings-v2-base-zh" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV2BaseZh,
                "jina-embeddings-v3" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV3,
                "jina-embeddings-v4" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV4,
                "jina-embeddings-v5-omni-small" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV5OmniSmall,
                "jina-embeddings-v5-text-nano" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV5TextNano,
                "jina-embeddings-v5-text-small" => EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel.JinaEmbeddingsV5TextSmall,
                _ => null,
            };
        }
    }
}