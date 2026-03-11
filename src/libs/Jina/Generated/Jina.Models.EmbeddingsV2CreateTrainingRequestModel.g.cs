
#nullable enable

namespace Jina
{
    /// <summary>
    /// Text embedding model for zero-shot classification.
    /// </summary>
    public enum EmbeddingsV2CreateTrainingRequestModel
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
    public static class EmbeddingsV2CreateTrainingRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV2CreateTrainingRequestModel value)
        {
            return value switch
            {
                EmbeddingsV2CreateTrainingRequestModel.JinaEmbeddingsV2BaseEn => "jina-embeddings-v2-base-en",
                EmbeddingsV2CreateTrainingRequestModel.JinaEmbeddingsV2BaseZh => "jina-embeddings-v2-base-zh",
                EmbeddingsV2CreateTrainingRequestModel.JinaEmbeddingsV2BaseDe => "jina-embeddings-v2-base-de",
                EmbeddingsV2CreateTrainingRequestModel.JinaEmbeddingsV2BaseEs => "jina-embeddings-v2-base-es",
                EmbeddingsV2CreateTrainingRequestModel.JinaEmbeddingsV2BaseCode => "jina-embeddings-v2-base-code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV2CreateTrainingRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-embeddings-v2-base-en" => EmbeddingsV2CreateTrainingRequestModel.JinaEmbeddingsV2BaseEn,
                "jina-embeddings-v2-base-zh" => EmbeddingsV2CreateTrainingRequestModel.JinaEmbeddingsV2BaseZh,
                "jina-embeddings-v2-base-de" => EmbeddingsV2CreateTrainingRequestModel.JinaEmbeddingsV2BaseDe,
                "jina-embeddings-v2-base-es" => EmbeddingsV2CreateTrainingRequestModel.JinaEmbeddingsV2BaseEs,
                "jina-embeddings-v2-base-code" => EmbeddingsV2CreateTrainingRequestModel.JinaEmbeddingsV2BaseCode,
                _ => null,
            };
        }
    }
}