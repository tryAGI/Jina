#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrainV1TrainPostRequestVariant1 : global::System.IEquatable<TrainV1TrainPostRequestVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel? Model { get; }

        /// <summary>
        /// Example: {"access":"private","input":[{"label":"Biology","text":"Explain the process of photosynthesis."},{"label":"Geography","text":"What is the capital of France?"}],"model":"jina-embeddings-v2-base-en","num_iters":15}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV2CreateTrainingRequest? JinaEmbeddingsV2BaseCode { get; init; }
#else
        public global::Jina.EmbeddingsV2CreateTrainingRequest? JinaEmbeddingsV2BaseCode { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV2BaseCode))]
#endif
        public bool IsJinaEmbeddingsV2BaseCode => JinaEmbeddingsV2BaseCode != null;

        /// <summary>
        /// Example: {"access":"public","input":[{"label":"Biology","text":"Describe the structure of a plant cell."},{"label":"Creative writing","text":"Write a poem about the ocean."}],"model":"jina-embeddings-v3","num_iters":20}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV3CreateTrainingRequest? JinaEmbeddingsV3 { get; init; }
#else
        public global::Jina.EmbeddingsV3CreateTrainingRequest? JinaEmbeddingsV3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV3))]
#endif
        public bool IsJinaEmbeddingsV3 => JinaEmbeddingsV3 != null;

        /// <summary>
        /// Example: {"access":"private","input":[{"label":"Dog","text":"A dog playing in the park."},{"image":"https://images.unsplash.com/photo-1465101046530-73398c7f28ca","label":"Rocket"}],"model":"jina-embeddings-v4","num_iters":25}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV4CreateTrainingRequest? JinaEmbeddingsV4 { get; init; }
#else
        public global::Jina.EmbeddingsV4CreateTrainingRequest? JinaEmbeddingsV4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV4))]
#endif
        public bool IsJinaEmbeddingsV4 => JinaEmbeddingsV4 != null;

        /// <summary>
        /// Example: {"access":"public","input":[{"label":"Biology","text":"Describe the structure of a plant cell."},{"label":"Creative writing","text":"Write a poem about the ocean."}],"model":"jina-embeddings-v5-text-small","num_iters":20}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV5CreateTrainingRequest? JinaEmbeddingsV5TextNano { get; init; }
#else
        public global::Jina.EmbeddingsV5CreateTrainingRequest? JinaEmbeddingsV5TextNano { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV5TextNano))]
#endif
        public bool IsJinaEmbeddingsV5TextNano => JinaEmbeddingsV5TextNano != null;

        /// <summary>
        /// Example: {"access":"public","input":[{"image":"https://images.unsplash.com/photo-1518717758536-85ae29035b6d","label":"Cat"},{"label":"Art","text":"A painting of a sunset over the mountains."}],"model":"jina-clip-v2","num_iters":12}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.ClipCreateTrainingRequest? JinaClipV1 { get; init; }
#else
        public global::Jina.ClipCreateTrainingRequest? JinaClipV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaClipV1))]
#endif
        public bool IsJinaClipV1 => JinaClipV1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrainV1TrainPostRequestVariant1(global::Jina.EmbeddingsV2CreateTrainingRequest value) => new TrainV1TrainPostRequestVariant1((global::Jina.EmbeddingsV2CreateTrainingRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV2CreateTrainingRequest?(TrainV1TrainPostRequestVariant1 @this) => @this.JinaEmbeddingsV2BaseCode;

        /// <summary>
        /// 
        /// </summary>
        public TrainV1TrainPostRequestVariant1(global::Jina.EmbeddingsV2CreateTrainingRequest? value)
        {
            JinaEmbeddingsV2BaseCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrainV1TrainPostRequestVariant1(global::Jina.EmbeddingsV3CreateTrainingRequest value) => new TrainV1TrainPostRequestVariant1((global::Jina.EmbeddingsV3CreateTrainingRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV3CreateTrainingRequest?(TrainV1TrainPostRequestVariant1 @this) => @this.JinaEmbeddingsV3;

        /// <summary>
        /// 
        /// </summary>
        public TrainV1TrainPostRequestVariant1(global::Jina.EmbeddingsV3CreateTrainingRequest? value)
        {
            JinaEmbeddingsV3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrainV1TrainPostRequestVariant1(global::Jina.EmbeddingsV4CreateTrainingRequest value) => new TrainV1TrainPostRequestVariant1((global::Jina.EmbeddingsV4CreateTrainingRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV4CreateTrainingRequest?(TrainV1TrainPostRequestVariant1 @this) => @this.JinaEmbeddingsV4;

        /// <summary>
        /// 
        /// </summary>
        public TrainV1TrainPostRequestVariant1(global::Jina.EmbeddingsV4CreateTrainingRequest? value)
        {
            JinaEmbeddingsV4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrainV1TrainPostRequestVariant1(global::Jina.EmbeddingsV5CreateTrainingRequest value) => new TrainV1TrainPostRequestVariant1((global::Jina.EmbeddingsV5CreateTrainingRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV5CreateTrainingRequest?(TrainV1TrainPostRequestVariant1 @this) => @this.JinaEmbeddingsV5TextNano;

        /// <summary>
        /// 
        /// </summary>
        public TrainV1TrainPostRequestVariant1(global::Jina.EmbeddingsV5CreateTrainingRequest? value)
        {
            JinaEmbeddingsV5TextNano = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrainV1TrainPostRequestVariant1(global::Jina.ClipCreateTrainingRequest value) => new TrainV1TrainPostRequestVariant1((global::Jina.ClipCreateTrainingRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.ClipCreateTrainingRequest?(TrainV1TrainPostRequestVariant1 @this) => @this.JinaClipV1;

        /// <summary>
        /// 
        /// </summary>
        public TrainV1TrainPostRequestVariant1(global::Jina.ClipCreateTrainingRequest? value)
        {
            JinaClipV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TrainV1TrainPostRequestVariant1(
            global::Jina.TrainV1TrainPostRequestVariant1DiscriminatorModel? model,
            global::Jina.EmbeddingsV2CreateTrainingRequest? jinaEmbeddingsV2BaseCode,
            global::Jina.EmbeddingsV3CreateTrainingRequest? jinaEmbeddingsV3,
            global::Jina.EmbeddingsV4CreateTrainingRequest? jinaEmbeddingsV4,
            global::Jina.EmbeddingsV5CreateTrainingRequest? jinaEmbeddingsV5TextNano,
            global::Jina.ClipCreateTrainingRequest? jinaClipV1
            )
        {
            Model = model;

            JinaEmbeddingsV2BaseCode = jinaEmbeddingsV2BaseCode;
            JinaEmbeddingsV3 = jinaEmbeddingsV3;
            JinaEmbeddingsV4 = jinaEmbeddingsV4;
            JinaEmbeddingsV5TextNano = jinaEmbeddingsV5TextNano;
            JinaClipV1 = jinaClipV1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JinaClipV1 as object ??
            JinaEmbeddingsV5TextNano as object ??
            JinaEmbeddingsV4 as object ??
            JinaEmbeddingsV3 as object ??
            JinaEmbeddingsV2BaseCode as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JinaEmbeddingsV2BaseCode?.ToString() ??
            JinaEmbeddingsV3?.ToString() ??
            JinaEmbeddingsV4?.ToString() ??
            JinaEmbeddingsV5TextNano?.ToString() ??
            JinaClipV1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5TextNano && !IsJinaClipV1 || !IsJinaEmbeddingsV2BaseCode && IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5TextNano && !IsJinaClipV1 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5TextNano && !IsJinaClipV1 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && IsJinaEmbeddingsV5TextNano && !IsJinaClipV1 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5TextNano && IsJinaClipV1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Jina.EmbeddingsV2CreateTrainingRequest?, TResult>? jinaEmbeddingsV2BaseCode = null,
            global::System.Func<global::Jina.EmbeddingsV3CreateTrainingRequest?, TResult>? jinaEmbeddingsV3 = null,
            global::System.Func<global::Jina.EmbeddingsV4CreateTrainingRequest?, TResult>? jinaEmbeddingsV4 = null,
            global::System.Func<global::Jina.EmbeddingsV5CreateTrainingRequest?, TResult>? jinaEmbeddingsV5TextNano = null,
            global::System.Func<global::Jina.ClipCreateTrainingRequest?, TResult>? jinaClipV1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJinaEmbeddingsV2BaseCode && jinaEmbeddingsV2BaseCode != null)
            {
                return jinaEmbeddingsV2BaseCode(JinaEmbeddingsV2BaseCode!);
            }
            else if (IsJinaEmbeddingsV3 && jinaEmbeddingsV3 != null)
            {
                return jinaEmbeddingsV3(JinaEmbeddingsV3!);
            }
            else if (IsJinaEmbeddingsV4 && jinaEmbeddingsV4 != null)
            {
                return jinaEmbeddingsV4(JinaEmbeddingsV4!);
            }
            else if (IsJinaEmbeddingsV5TextNano && jinaEmbeddingsV5TextNano != null)
            {
                return jinaEmbeddingsV5TextNano(JinaEmbeddingsV5TextNano!);
            }
            else if (IsJinaClipV1 && jinaClipV1 != null)
            {
                return jinaClipV1(JinaClipV1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Jina.EmbeddingsV2CreateTrainingRequest?>? jinaEmbeddingsV2BaseCode = null,
            global::System.Action<global::Jina.EmbeddingsV3CreateTrainingRequest?>? jinaEmbeddingsV3 = null,
            global::System.Action<global::Jina.EmbeddingsV4CreateTrainingRequest?>? jinaEmbeddingsV4 = null,
            global::System.Action<global::Jina.EmbeddingsV5CreateTrainingRequest?>? jinaEmbeddingsV5TextNano = null,
            global::System.Action<global::Jina.ClipCreateTrainingRequest?>? jinaClipV1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJinaEmbeddingsV2BaseCode)
            {
                jinaEmbeddingsV2BaseCode?.Invoke(JinaEmbeddingsV2BaseCode!);
            }
            else if (IsJinaEmbeddingsV3)
            {
                jinaEmbeddingsV3?.Invoke(JinaEmbeddingsV3!);
            }
            else if (IsJinaEmbeddingsV4)
            {
                jinaEmbeddingsV4?.Invoke(JinaEmbeddingsV4!);
            }
            else if (IsJinaEmbeddingsV5TextNano)
            {
                jinaEmbeddingsV5TextNano?.Invoke(JinaEmbeddingsV5TextNano!);
            }
            else if (IsJinaClipV1)
            {
                jinaClipV1?.Invoke(JinaClipV1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JinaEmbeddingsV2BaseCode,
                typeof(global::Jina.EmbeddingsV2CreateTrainingRequest),
                JinaEmbeddingsV3,
                typeof(global::Jina.EmbeddingsV3CreateTrainingRequest),
                JinaEmbeddingsV4,
                typeof(global::Jina.EmbeddingsV4CreateTrainingRequest),
                JinaEmbeddingsV5TextNano,
                typeof(global::Jina.EmbeddingsV5CreateTrainingRequest),
                JinaClipV1,
                typeof(global::Jina.ClipCreateTrainingRequest),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TrainV1TrainPostRequestVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV2CreateTrainingRequest?>.Default.Equals(JinaEmbeddingsV2BaseCode, other.JinaEmbeddingsV2BaseCode) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV3CreateTrainingRequest?>.Default.Equals(JinaEmbeddingsV3, other.JinaEmbeddingsV3) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV4CreateTrainingRequest?>.Default.Equals(JinaEmbeddingsV4, other.JinaEmbeddingsV4) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV5CreateTrainingRequest?>.Default.Equals(JinaEmbeddingsV5TextNano, other.JinaEmbeddingsV5TextNano) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ClipCreateTrainingRequest?>.Default.Equals(JinaClipV1, other.JinaClipV1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrainV1TrainPostRequestVariant1 obj1, TrainV1TrainPostRequestVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrainV1TrainPostRequestVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrainV1TrainPostRequestVariant1 obj1, TrainV1TrainPostRequestVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrainV1TrainPostRequestVariant1 o && Equals(o);
        }
    }
}
