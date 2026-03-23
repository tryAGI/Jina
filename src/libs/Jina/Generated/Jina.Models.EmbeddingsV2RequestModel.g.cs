
#nullable enable

namespace Jina
{
    /// <summary>
    /// The embedding model to use.
    /// </summary>
    public enum EmbeddingsV2RequestModel
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV2RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV2RequestModel value)
        {
            return value switch
            {
                EmbeddingsV2RequestModel.JinaEmbeddingsV2BaseCode => "jina-embeddings-v2-base-code",
                EmbeddingsV2RequestModel.JinaEmbeddingsV2BaseDe => "jina-embeddings-v2-base-de",
                EmbeddingsV2RequestModel.JinaEmbeddingsV2BaseEn => "jina-embeddings-v2-base-en",
                EmbeddingsV2RequestModel.JinaEmbeddingsV2BaseEs => "jina-embeddings-v2-base-es",
                EmbeddingsV2RequestModel.JinaEmbeddingsV2BaseZh => "jina-embeddings-v2-base-zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV2RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-embeddings-v2-base-code" => EmbeddingsV2RequestModel.JinaEmbeddingsV2BaseCode,
                "jina-embeddings-v2-base-de" => EmbeddingsV2RequestModel.JinaEmbeddingsV2BaseDe,
                "jina-embeddings-v2-base-en" => EmbeddingsV2RequestModel.JinaEmbeddingsV2BaseEn,
                "jina-embeddings-v2-base-es" => EmbeddingsV2RequestModel.JinaEmbeddingsV2BaseEs,
                "jina-embeddings-v2-base-zh" => EmbeddingsV2RequestModel.JinaEmbeddingsV2BaseZh,
                _ => null,
            };
        }
    }
}