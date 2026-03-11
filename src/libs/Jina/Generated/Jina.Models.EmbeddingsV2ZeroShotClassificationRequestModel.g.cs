
#nullable enable

namespace Jina
{
    /// <summary>
    /// The embedding model to use.
    /// </summary>
    public enum EmbeddingsV2ZeroShotClassificationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV2BaseEn,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV2BaseZh,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV2BaseDe,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV2BaseEs,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV2BaseCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV2ZeroShotClassificationRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV2ZeroShotClassificationRequestModel value)
        {
            return value switch
            {
                EmbeddingsV2ZeroShotClassificationRequestModel.JinaEmbeddingsV2BaseEn => "jina-embeddings-v2-base-en",
                EmbeddingsV2ZeroShotClassificationRequestModel.JinaEmbeddingsV2BaseZh => "jina-embeddings-v2-base-zh",
                EmbeddingsV2ZeroShotClassificationRequestModel.JinaEmbeddingsV2BaseDe => "jina-embeddings-v2-base-de",
                EmbeddingsV2ZeroShotClassificationRequestModel.JinaEmbeddingsV2BaseEs => "jina-embeddings-v2-base-es",
                EmbeddingsV2ZeroShotClassificationRequestModel.JinaEmbeddingsV2BaseCode => "jina-embeddings-v2-base-code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV2ZeroShotClassificationRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-embeddings-v2-base-en" => EmbeddingsV2ZeroShotClassificationRequestModel.JinaEmbeddingsV2BaseEn,
                "jina-embeddings-v2-base-zh" => EmbeddingsV2ZeroShotClassificationRequestModel.JinaEmbeddingsV2BaseZh,
                "jina-embeddings-v2-base-de" => EmbeddingsV2ZeroShotClassificationRequestModel.JinaEmbeddingsV2BaseDe,
                "jina-embeddings-v2-base-es" => EmbeddingsV2ZeroShotClassificationRequestModel.JinaEmbeddingsV2BaseEs,
                "jina-embeddings-v2-base-code" => EmbeddingsV2ZeroShotClassificationRequestModel.JinaEmbeddingsV2BaseCode,
                _ => null,
            };
        }
    }
}