#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ClassifyV1ClassifyPostRequestVariant1 : global::System.IEquatable<ClassifyV1ClassifyPostRequestVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel? Model { get; }

        /// <summary>
        /// Zero-shot classification using Embeddings v2.<br/>
        /// Example: {"input":["Write a Python function to reverse a string.","Summarize the main findings of the research paper."],"labels":["Simple task","Complex reasoning","Creative writing"],"model":"jina-embeddings-v2-base-en"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV2ZeroShotClassificationRequest? JinaEmbeddingsV2BaseEn { get; init; }
#else
        public global::Jina.EmbeddingsV2ZeroShotClassificationRequest? JinaEmbeddingsV2BaseEn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV2BaseEn))]
#endif
        public bool IsJinaEmbeddingsV2BaseEn => JinaEmbeddingsV2BaseEn != null;

        /// <summary>
        /// Zero-shot classification using Embeddings v3.<br/>
        /// Example: {"input":["Explain the theory of relativity in simple terms.","Design a database schema for an e-commerce platform."],"labels":["Technical explanation","Creative writing","Business solution"],"model":"jina-embeddings-v3"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV3ZeroShotClassificationRequest? JinaEmbeddingsV3 { get; init; }
#else
        public global::Jina.EmbeddingsV3ZeroShotClassificationRequest? JinaEmbeddingsV3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV3))]
#endif
        public bool IsJinaEmbeddingsV3 => JinaEmbeddingsV3 != null;

        /// <summary>
        /// Zero-shot classification using Embeddings v4.<br/>
        /// Example: {"input":["Describe the process of photosynthesis.","Analyze the sentiment of the following review: \u0027The product exceeded my expectations.\u0027"],"labels":["Factual answer","Sentiment analysis","Marketing content"],"model":"jina-embeddings-v4"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV4ZeroShotClassificationRequest? JinaEmbeddingsV4 { get; init; }
#else
        public global::Jina.EmbeddingsV4ZeroShotClassificationRequest? JinaEmbeddingsV4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV4))]
#endif
        public bool IsJinaEmbeddingsV4 => JinaEmbeddingsV4 != null;

        /// <summary>
        /// Zero-shot classification using Embeddings v5 text models.<br/>
        /// Example: {"input":["Explain the theory of relativity in simple terms.","Design a database schema for an e-commerce platform."],"labels":["Technical explanation","Creative writing","Business solution"],"model":"jina-embeddings-v5-text-small"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV5ZeroShotClassificationRequest? JinaEmbeddingsV5TextNano { get; init; }
#else
        public global::Jina.EmbeddingsV5ZeroShotClassificationRequest? JinaEmbeddingsV5TextNano { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV5TextNano))]
#endif
        public bool IsJinaEmbeddingsV5TextNano => JinaEmbeddingsV5TextNano != null;

        /// <summary>
        /// Zero-shot classification using CLIP for text and images.<br/>
        /// Example: {"input":["A photo of a cat sitting on a windowsill.",{"image":"https://images.unsplash.com/photo-1518717758536-85ae29035b6d"}],"labels":["Animal","Object","Scene"],"model":"jina-clip-v2"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.ClipZeroShotClassificationRequest? JinaClipV1 { get; init; }
#else
        public global::Jina.ClipZeroShotClassificationRequest? JinaClipV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaClipV1))]
#endif
        public bool IsJinaClipV1 => JinaClipV1 != null;

        /// <summary>
        /// Zero-shot classification using code embedding models.<br/>
        /// Example: {"input":["def hello_world():\n    print(\u0027Hello, World!\u0027)","SELECT * FROM users WHERE id = 1;"],"labels":["Python","JavaScript","SQL","Rust"],"model":"jina-code-embeddings-0.5b"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.CodeEmbeddingsZeroShotClassificationRequest? JinaCodeEmbeddings05b { get; init; }
#else
        public global::Jina.CodeEmbeddingsZeroShotClassificationRequest? JinaCodeEmbeddings05b { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaCodeEmbeddings05b))]
#endif
        public bool IsJinaCodeEmbeddings05b => JinaCodeEmbeddings05b != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClassifyV1ClassifyPostRequestVariant1(global::Jina.EmbeddingsV2ZeroShotClassificationRequest value) => new ClassifyV1ClassifyPostRequestVariant1((global::Jina.EmbeddingsV2ZeroShotClassificationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV2ZeroShotClassificationRequest?(ClassifyV1ClassifyPostRequestVariant1 @this) => @this.JinaEmbeddingsV2BaseEn;

        /// <summary>
        /// 
        /// </summary>
        public ClassifyV1ClassifyPostRequestVariant1(global::Jina.EmbeddingsV2ZeroShotClassificationRequest? value)
        {
            JinaEmbeddingsV2BaseEn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClassifyV1ClassifyPostRequestVariant1(global::Jina.EmbeddingsV3ZeroShotClassificationRequest value) => new ClassifyV1ClassifyPostRequestVariant1((global::Jina.EmbeddingsV3ZeroShotClassificationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV3ZeroShotClassificationRequest?(ClassifyV1ClassifyPostRequestVariant1 @this) => @this.JinaEmbeddingsV3;

        /// <summary>
        /// 
        /// </summary>
        public ClassifyV1ClassifyPostRequestVariant1(global::Jina.EmbeddingsV3ZeroShotClassificationRequest? value)
        {
            JinaEmbeddingsV3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClassifyV1ClassifyPostRequestVariant1(global::Jina.EmbeddingsV4ZeroShotClassificationRequest value) => new ClassifyV1ClassifyPostRequestVariant1((global::Jina.EmbeddingsV4ZeroShotClassificationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV4ZeroShotClassificationRequest?(ClassifyV1ClassifyPostRequestVariant1 @this) => @this.JinaEmbeddingsV4;

        /// <summary>
        /// 
        /// </summary>
        public ClassifyV1ClassifyPostRequestVariant1(global::Jina.EmbeddingsV4ZeroShotClassificationRequest? value)
        {
            JinaEmbeddingsV4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClassifyV1ClassifyPostRequestVariant1(global::Jina.EmbeddingsV5ZeroShotClassificationRequest value) => new ClassifyV1ClassifyPostRequestVariant1((global::Jina.EmbeddingsV5ZeroShotClassificationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV5ZeroShotClassificationRequest?(ClassifyV1ClassifyPostRequestVariant1 @this) => @this.JinaEmbeddingsV5TextNano;

        /// <summary>
        /// 
        /// </summary>
        public ClassifyV1ClassifyPostRequestVariant1(global::Jina.EmbeddingsV5ZeroShotClassificationRequest? value)
        {
            JinaEmbeddingsV5TextNano = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClassifyV1ClassifyPostRequestVariant1(global::Jina.ClipZeroShotClassificationRequest value) => new ClassifyV1ClassifyPostRequestVariant1((global::Jina.ClipZeroShotClassificationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.ClipZeroShotClassificationRequest?(ClassifyV1ClassifyPostRequestVariant1 @this) => @this.JinaClipV1;

        /// <summary>
        /// 
        /// </summary>
        public ClassifyV1ClassifyPostRequestVariant1(global::Jina.ClipZeroShotClassificationRequest? value)
        {
            JinaClipV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClassifyV1ClassifyPostRequestVariant1(global::Jina.CodeEmbeddingsZeroShotClassificationRequest value) => new ClassifyV1ClassifyPostRequestVariant1((global::Jina.CodeEmbeddingsZeroShotClassificationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.CodeEmbeddingsZeroShotClassificationRequest?(ClassifyV1ClassifyPostRequestVariant1 @this) => @this.JinaCodeEmbeddings05b;

        /// <summary>
        /// 
        /// </summary>
        public ClassifyV1ClassifyPostRequestVariant1(global::Jina.CodeEmbeddingsZeroShotClassificationRequest? value)
        {
            JinaCodeEmbeddings05b = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ClassifyV1ClassifyPostRequestVariant1(
            global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel? model,
            global::Jina.EmbeddingsV2ZeroShotClassificationRequest? jinaEmbeddingsV2BaseEn,
            global::Jina.EmbeddingsV3ZeroShotClassificationRequest? jinaEmbeddingsV3,
            global::Jina.EmbeddingsV4ZeroShotClassificationRequest? jinaEmbeddingsV4,
            global::Jina.EmbeddingsV5ZeroShotClassificationRequest? jinaEmbeddingsV5TextNano,
            global::Jina.ClipZeroShotClassificationRequest? jinaClipV1,
            global::Jina.CodeEmbeddingsZeroShotClassificationRequest? jinaCodeEmbeddings05b
            )
        {
            Model = model;

            JinaEmbeddingsV2BaseEn = jinaEmbeddingsV2BaseEn;
            JinaEmbeddingsV3 = jinaEmbeddingsV3;
            JinaEmbeddingsV4 = jinaEmbeddingsV4;
            JinaEmbeddingsV5TextNano = jinaEmbeddingsV5TextNano;
            JinaClipV1 = jinaClipV1;
            JinaCodeEmbeddings05b = jinaCodeEmbeddings05b;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JinaCodeEmbeddings05b as object ??
            JinaClipV1 as object ??
            JinaEmbeddingsV5TextNano as object ??
            JinaEmbeddingsV4 as object ??
            JinaEmbeddingsV3 as object ??
            JinaEmbeddingsV2BaseEn as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JinaEmbeddingsV2BaseEn?.ToString() ??
            JinaEmbeddingsV3?.ToString() ??
            JinaEmbeddingsV4?.ToString() ??
            JinaEmbeddingsV5TextNano?.ToString() ??
            JinaClipV1?.ToString() ??
            JinaCodeEmbeddings05b?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJinaEmbeddingsV2BaseEn && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5TextNano && !IsJinaClipV1 && !IsJinaCodeEmbeddings05b || !IsJinaEmbeddingsV2BaseEn && IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5TextNano && !IsJinaClipV1 && !IsJinaCodeEmbeddings05b || !IsJinaEmbeddingsV2BaseEn && !IsJinaEmbeddingsV3 && IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5TextNano && !IsJinaClipV1 && !IsJinaCodeEmbeddings05b || !IsJinaEmbeddingsV2BaseEn && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && IsJinaEmbeddingsV5TextNano && !IsJinaClipV1 && !IsJinaCodeEmbeddings05b || !IsJinaEmbeddingsV2BaseEn && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5TextNano && IsJinaClipV1 && !IsJinaCodeEmbeddings05b || !IsJinaEmbeddingsV2BaseEn && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5TextNano && !IsJinaClipV1 && IsJinaCodeEmbeddings05b;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Jina.EmbeddingsV2ZeroShotClassificationRequest?, TResult>? jinaEmbeddingsV2BaseEn = null,
            global::System.Func<global::Jina.EmbeddingsV3ZeroShotClassificationRequest?, TResult>? jinaEmbeddingsV3 = null,
            global::System.Func<global::Jina.EmbeddingsV4ZeroShotClassificationRequest?, TResult>? jinaEmbeddingsV4 = null,
            global::System.Func<global::Jina.EmbeddingsV5ZeroShotClassificationRequest?, TResult>? jinaEmbeddingsV5TextNano = null,
            global::System.Func<global::Jina.ClipZeroShotClassificationRequest?, TResult>? jinaClipV1 = null,
            global::System.Func<global::Jina.CodeEmbeddingsZeroShotClassificationRequest?, TResult>? jinaCodeEmbeddings05b = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJinaEmbeddingsV2BaseEn && jinaEmbeddingsV2BaseEn != null)
            {
                return jinaEmbeddingsV2BaseEn(JinaEmbeddingsV2BaseEn!);
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
            else if (IsJinaCodeEmbeddings05b && jinaCodeEmbeddings05b != null)
            {
                return jinaCodeEmbeddings05b(JinaCodeEmbeddings05b!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Jina.EmbeddingsV2ZeroShotClassificationRequest?>? jinaEmbeddingsV2BaseEn = null,
            global::System.Action<global::Jina.EmbeddingsV3ZeroShotClassificationRequest?>? jinaEmbeddingsV3 = null,
            global::System.Action<global::Jina.EmbeddingsV4ZeroShotClassificationRequest?>? jinaEmbeddingsV4 = null,
            global::System.Action<global::Jina.EmbeddingsV5ZeroShotClassificationRequest?>? jinaEmbeddingsV5TextNano = null,
            global::System.Action<global::Jina.ClipZeroShotClassificationRequest?>? jinaClipV1 = null,
            global::System.Action<global::Jina.CodeEmbeddingsZeroShotClassificationRequest?>? jinaCodeEmbeddings05b = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJinaEmbeddingsV2BaseEn)
            {
                jinaEmbeddingsV2BaseEn?.Invoke(JinaEmbeddingsV2BaseEn!);
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
            else if (IsJinaCodeEmbeddings05b)
            {
                jinaCodeEmbeddings05b?.Invoke(JinaCodeEmbeddings05b!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JinaEmbeddingsV2BaseEn,
                typeof(global::Jina.EmbeddingsV2ZeroShotClassificationRequest),
                JinaEmbeddingsV3,
                typeof(global::Jina.EmbeddingsV3ZeroShotClassificationRequest),
                JinaEmbeddingsV4,
                typeof(global::Jina.EmbeddingsV4ZeroShotClassificationRequest),
                JinaEmbeddingsV5TextNano,
                typeof(global::Jina.EmbeddingsV5ZeroShotClassificationRequest),
                JinaClipV1,
                typeof(global::Jina.ClipZeroShotClassificationRequest),
                JinaCodeEmbeddings05b,
                typeof(global::Jina.CodeEmbeddingsZeroShotClassificationRequest),
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
        public bool Equals(ClassifyV1ClassifyPostRequestVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV2ZeroShotClassificationRequest?>.Default.Equals(JinaEmbeddingsV2BaseEn, other.JinaEmbeddingsV2BaseEn) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV3ZeroShotClassificationRequest?>.Default.Equals(JinaEmbeddingsV3, other.JinaEmbeddingsV3) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV4ZeroShotClassificationRequest?>.Default.Equals(JinaEmbeddingsV4, other.JinaEmbeddingsV4) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV5ZeroShotClassificationRequest?>.Default.Equals(JinaEmbeddingsV5TextNano, other.JinaEmbeddingsV5TextNano) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ClipZeroShotClassificationRequest?>.Default.Equals(JinaClipV1, other.JinaClipV1) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.CodeEmbeddingsZeroShotClassificationRequest?>.Default.Equals(JinaCodeEmbeddings05b, other.JinaCodeEmbeddings05b) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ClassifyV1ClassifyPostRequestVariant1 obj1, ClassifyV1ClassifyPostRequestVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ClassifyV1ClassifyPostRequestVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ClassifyV1ClassifyPostRequestVariant1 obj1, ClassifyV1ClassifyPostRequestVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ClassifyV1ClassifyPostRequestVariant1 o && Equals(o);
        }
    }
}
