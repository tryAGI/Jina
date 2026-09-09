#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContentVariant2Item : global::System.IEquatable<ContentVariant2Item>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ChatMessageContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.TextContentPart? Text { get; init; }
#else
        public global::Jina.TextContentPart? Text { get; }
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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.TextContentPart? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.TextContentPart PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.ImageContentPart? ImageUrl { get; init; }
#else
        public global::Jina.ImageContentPart? ImageUrl { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.ImageContentPart? value)
        {
            value = ImageUrl;
            return IsImageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.ImageContentPart PickImageUrl() => IsImageUrl
            ? ImageUrl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUrl' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::Jina.TextContentPart value) => new ContentVariant2Item((global::Jina.TextContentPart?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.TextContentPart?(ContentVariant2Item @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::Jina.TextContentPart? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromText(global::Jina.TextContentPart? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::Jina.ImageContentPart value) => new ContentVariant2Item((global::Jina.ImageContentPart?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.ImageContentPart?(ContentVariant2Item @this) => @this.ImageUrl;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::Jina.ImageContentPart? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromImageUrl(global::Jina.ImageContentPart? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(
            global::Jina.ChatMessageContentVariant2ItemDiscriminatorType? type,
            global::Jina.TextContentPart? text,
            global::Jina.ImageContentPart? imageUrl
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ImageUrl as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl || !IsText && IsImageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Jina.TextContentPart, TResult>? text = null,
            global::System.Func<global::Jina.ImageContentPart, TResult>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Jina.TextContentPart>? text = null,

            global::System.Action<global::Jina.ImageContentPart>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Jina.TextContentPart>? text = null,
            global::System.Action<global::Jina.ImageContentPart>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Jina.TextContentPart),
                ImageUrl,
                typeof(global::Jina.ImageContentPart),
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
        public bool Equals(ContentVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Jina.TextContentPart?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ImageContentPart?>.Default.Equals(ImageUrl, other.ImageUrl)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item o && Equals(o);
        }
    }
}
