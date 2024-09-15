using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingInput : global::System.IEquatable<EmbeddingInput>
    {
        /// <summary>
        /// The input to the API for text embedding. OpenAI compatible
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.TextEmbeddingInput? Text { get; init; }
#else
        public global::Jina.TextEmbeddingInput? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingInput(global::Jina.TextEmbeddingInput value) => new EmbeddingInput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.TextEmbeddingInput?(EmbeddingInput @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(global::Jina.TextEmbeddingInput? value)
        {
            Text = value;
        }

        /// <summary>
        /// The input to the API for text embedding. OpenAI compatible
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.ImageEmbeddingInput? Image { get; init; }
#else
        public global::Jina.ImageEmbeddingInput? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingInput(global::Jina.ImageEmbeddingInput value) => new EmbeddingInput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.ImageEmbeddingInput?(EmbeddingInput @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(global::Jina.ImageEmbeddingInput? value)
        {
            Image = value;
        }

        /// <summary>
        /// The input to the API for text embedding. OpenAI compatible
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.MixedEmbeddingInput? Mixed { get; init; }
#else
        public global::Jina.MixedEmbeddingInput? Mixed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mixed))]
#endif
        public bool IsMixed => Mixed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingInput(global::Jina.MixedEmbeddingInput value) => new EmbeddingInput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.MixedEmbeddingInput?(EmbeddingInput @this) => @this.Mixed;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(global::Jina.MixedEmbeddingInput? value)
        {
            Mixed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(
            global::Jina.TextEmbeddingInput? text,
            global::Jina.ImageEmbeddingInput? image,
            global::Jina.MixedEmbeddingInput? mixed
            )
        {
            Text = text;
            Image = image;
            Mixed = mixed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Mixed as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText || IsImage || IsMixed;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Jina.TextEmbeddingInput),
                Image,
                typeof(global::Jina.ImageEmbeddingInput),
                Mixed,
                typeof(global::Jina.MixedEmbeddingInput),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(EmbeddingInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Jina.TextEmbeddingInput?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ImageEmbeddingInput?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.MixedEmbeddingInput?>.Default.Equals(Mixed, other.Mixed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingInput obj1, EmbeddingInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingInput obj1, EmbeddingInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingInput o && Equals(o);
        }
    }
}
