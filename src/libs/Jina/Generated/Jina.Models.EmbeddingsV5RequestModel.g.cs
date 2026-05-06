
#nullable enable

namespace Jina
{
    /// <summary>
    /// The embedding model to use.
    /// </summary>
    public enum EmbeddingsV5RequestModel
    {
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
    public static class EmbeddingsV5RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV5RequestModel value)
        {
            return value switch
            {
                EmbeddingsV5RequestModel.JinaEmbeddingsV5OmniSmall => "jina-embeddings-v5-omni-small",
                EmbeddingsV5RequestModel.JinaEmbeddingsV5TextNano => "jina-embeddings-v5-text-nano",
                EmbeddingsV5RequestModel.JinaEmbeddingsV5TextSmall => "jina-embeddings-v5-text-small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV5RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-embeddings-v5-omni-small" => EmbeddingsV5RequestModel.JinaEmbeddingsV5OmniSmall,
                "jina-embeddings-v5-text-nano" => EmbeddingsV5RequestModel.JinaEmbeddingsV5TextNano,
                "jina-embeddings-v5-text-small" => EmbeddingsV5RequestModel.JinaEmbeddingsV5TextSmall,
                _ => null,
            };
        }
    }
}