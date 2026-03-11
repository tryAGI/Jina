
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrainV1TrainPostRequestVariant1DiscriminatorModel
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
        /// <summary>
        /// 
        /// </summary>
        JinaClipV1,
        /// <summary>
        /// 
        /// </summary>
        JinaClipV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainV1TrainPostRequestVariant1DiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainV1TrainPostRequestVariant1DiscriminatorModel value)
        {
            return value switch
            {
                TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseEn => "jina-embeddings-v2-base-en",
                TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseZh => "jina-embeddings-v2-base-zh",
                TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseDe => "jina-embeddings-v2-base-de",
                TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseEs => "jina-embeddings-v2-base-es",
                TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseCode => "jina-embeddings-v2-base-code",
                TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV3 => "jina-embeddings-v3",
                TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV4 => "jina-embeddings-v4",
                TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV5TextNano => "jina-embeddings-v5-text-nano",
                TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV5TextSmall => "jina-embeddings-v5-text-small",
                TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaClipV1 => "jina-clip-v1",
                TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaClipV2 => "jina-clip-v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainV1TrainPostRequestVariant1DiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-embeddings-v2-base-en" => TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseEn,
                "jina-embeddings-v2-base-zh" => TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseZh,
                "jina-embeddings-v2-base-de" => TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseDe,
                "jina-embeddings-v2-base-es" => TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseEs,
                "jina-embeddings-v2-base-code" => TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV2BaseCode,
                "jina-embeddings-v3" => TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV3,
                "jina-embeddings-v4" => TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV4,
                "jina-embeddings-v5-text-nano" => TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV5TextNano,
                "jina-embeddings-v5-text-small" => TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaEmbeddingsV5TextSmall,
                "jina-clip-v1" => TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaClipV1,
                "jina-clip-v2" => TrainV1TrainPostRequestVariant1DiscriminatorModel.JinaClipV2,
                _ => null,
            };
        }
    }
}