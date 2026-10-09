#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EmbeddingsV1EmbeddingsPostRequest : global::System.IEquatable<EmbeddingsV1EmbeddingsPostRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel? Model { get; }

        /// <summary>
        /// Jina Embeddings v2 text embedding models.<br/>
        /// Example: {"embedding_type":"float","input":["A beautiful sunset over the beach","Jina AI - Your Search Foundation - Supercharged"],"model":"jina-embeddings-v2-base-en","normalized":true,"truncate":false}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV2Request? JinaEmbeddingsV2BaseCode { get; init; }
#else
        public global::Jina.EmbeddingsV2Request? JinaEmbeddingsV2BaseCode { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV2BaseCode))]
#endif
        public bool IsJinaEmbeddingsV2BaseCode => JinaEmbeddingsV2BaseCode != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJinaEmbeddingsV2BaseCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.EmbeddingsV2Request? value)
        {
            value = JinaEmbeddingsV2BaseCode;
            return IsJinaEmbeddingsV2BaseCode;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV2Request PickJinaEmbeddingsV2BaseCode() => JinaEmbeddingsV2BaseCode is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JinaEmbeddingsV2BaseCode' but the value was {ToString()}.");

        /// <summary>
        /// Jina Embeddings v3 with task-specific optimization and flexible dimensions.<br/>
        /// Example: {"dimensions":512,"embedding_type":"float","input":["A beautiful sunset over the beach"],"late_chunking":false,"model":"jina-embeddings-v3","normalized":true,"task":"retrieval.query"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV3Request? JinaEmbeddingsV3 { get; init; }
#else
        public global::Jina.EmbeddingsV3Request? JinaEmbeddingsV3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV3))]
#endif
        public bool IsJinaEmbeddingsV3 => JinaEmbeddingsV3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJinaEmbeddingsV3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.EmbeddingsV3Request? value)
        {
            value = JinaEmbeddingsV3;
            return IsJinaEmbeddingsV3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV3Request PickJinaEmbeddingsV3() => JinaEmbeddingsV3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JinaEmbeddingsV3' but the value was {ToString()}.");

        /// <summary>
        /// Jina Embeddings v4 multimodal model for text, images, and PDFs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV4Request? JinaEmbeddingsV4 { get; init; }
#else
        public global::Jina.EmbeddingsV4Request? JinaEmbeddingsV4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV4))]
#endif
        public bool IsJinaEmbeddingsV4 => JinaEmbeddingsV4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJinaEmbeddingsV4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.EmbeddingsV4Request? value)
        {
            value = JinaEmbeddingsV4;
            return IsJinaEmbeddingsV4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV4Request PickJinaEmbeddingsV4() => JinaEmbeddingsV4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JinaEmbeddingsV4' but the value was {ToString()}.");

        /// <summary>
        /// Jina Embeddings v5, with task-specific adapters and truncatable<br/>
        /// dimensions. Text, images, video, audio and PDFs share one vector space, so<br/>
        /// a query in any of them retrieves any other; the `omni` names are the ones<br/>
        /// to reach for when the corpus is not text.<br/>
        /// Each list item is one modality, except a `MergedContentGroup`<br/>
        /// (`{"content": [...]}`), which fuses several chunks into a single embedding<br/>
        /// in one forward pass.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV5Request? JinaEmbeddingsV5OmniNano { get; init; }
#else
        public global::Jina.EmbeddingsV5Request? JinaEmbeddingsV5OmniNano { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV5OmniNano))]
#endif
        public bool IsJinaEmbeddingsV5OmniNano => JinaEmbeddingsV5OmniNano != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJinaEmbeddingsV5OmniNano(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.EmbeddingsV5Request? value)
        {
            value = JinaEmbeddingsV5OmniNano;
            return IsJinaEmbeddingsV5OmniNano;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.EmbeddingsV5Request PickJinaEmbeddingsV5OmniNano() => JinaEmbeddingsV5OmniNano is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JinaEmbeddingsV5OmniNano' but the value was {ToString()}.");

        /// <summary>
        /// Code embeddings (0.5b) for search over source, and between source and prose.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.CodeEmbeddings500MRequest? JinaCodeEmbeddings05b { get; init; }
#else
        public global::Jina.CodeEmbeddings500MRequest? JinaCodeEmbeddings05b { get; }
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
        public bool TryPickJinaCodeEmbeddings05b(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.CodeEmbeddings500MRequest? value)
        {
            value = JinaCodeEmbeddings05b;
            return IsJinaCodeEmbeddings05b;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings500MRequest PickJinaCodeEmbeddings05b() => JinaCodeEmbeddings05b is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JinaCodeEmbeddings05b' but the value was {ToString()}.");

        /// <summary>
        /// Code embeddings (1.5b) for search over source, and between source and prose.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.CodeEmbeddings1500MRequest? JinaCodeEmbeddings15b { get; init; }
#else
        public global::Jina.CodeEmbeddings1500MRequest? JinaCodeEmbeddings15b { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaCodeEmbeddings15b))]
#endif
        public bool IsJinaCodeEmbeddings15b => JinaCodeEmbeddings15b != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJinaCodeEmbeddings15b(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.CodeEmbeddings1500MRequest? value)
        {
            value = JinaCodeEmbeddings15b;
            return IsJinaCodeEmbeddings15b;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.CodeEmbeddings1500MRequest PickJinaCodeEmbeddings15b() => JinaCodeEmbeddings15b is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JinaCodeEmbeddings15b' but the value was {ToString()}.");

        /// <summary>
        /// CLIP v1 multimodal model for images and text in a shared vector space.<br/>
        /// Example: {"embedding_type":"float","input":[{"image":"https://i.ibb.co/nQNGqL0/beach1.jpg"},"A beautiful sunset over the beach"],"model":"jina-clip-v1","normalized":true}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.ClipV1Request? JinaClipV1 { get; init; }
#else
        public global::Jina.ClipV1Request? JinaClipV1 { get; }
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
        public bool TryPickJinaClipV1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.ClipV1Request? value)
        {
            value = JinaClipV1;
            return IsJinaClipV1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClipV1Request PickJinaClipV1() => JinaClipV1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JinaClipV1' but the value was {ToString()}.");

        /// <summary>
        /// CLIP v2 with Matryoshka representation learning for flexible dimensions.<br/>
        /// Example: {"dimensions":512,"embedding_type":"float","input":[{"image":"https://i.ibb.co/nQNGqL0/beach1.jpg"},"Jina AI - Your Search Foundation - Supercharged"],"model":"jina-clip-v2","normalized":true,"task":"retrieval.query"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.ClipV2Request? JinaClipV2 { get; init; }
#else
        public global::Jina.ClipV2Request? JinaClipV2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaClipV2))]
#endif
        public bool IsJinaClipV2 => JinaClipV2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJinaClipV2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.ClipV2Request? value)
        {
            value = JinaClipV2;
            return IsJinaClipV2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.ClipV2Request PickJinaClipV2() => JinaClipV2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JinaClipV2' but the value was {ToString()}.");

        /// <summary>
        /// ColBERT v1 for token-level late interaction retrieval.<br/>
        /// Example: {"embedding_type":"float","input":["A beautiful sunset over the beach","Jina AI - Your Search Foundation - Supercharged"],"input_type":"document","model":"jina-colbert-v1-en"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.ColbertV1Request? JinaColbertV1En { get; init; }
#else
        public global::Jina.ColbertV1Request? JinaColbertV1En { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaColbertV1En))]
#endif
        public bool IsJinaColbertV1En => JinaColbertV1En != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJinaColbertV1En(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.ColbertV1Request? value)
        {
            value = JinaColbertV1En;
            return IsJinaColbertV1En;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV1Request PickJinaColbertV1En() => JinaColbertV1En is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JinaColbertV1En' but the value was {ToString()}.");

        /// <summary>
        /// ColBERT v2 with Matryoshka representation learning for flexible dimensions.<br/>
        /// Example: {"dimensions":128,"embedding_type":"float","input":["A beautiful sunset over the beach"],"input_type":"query","model":"jina-colbert-v2"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.ColbertV2Request? JinaColbertV2 { get; init; }
#else
        public global::Jina.ColbertV2Request? JinaColbertV2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaColbertV2))]
#endif
        public bool IsJinaColbertV2 => JinaColbertV2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJinaColbertV2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.ColbertV2Request? value)
        {
            value = JinaColbertV2;
            return IsJinaColbertV2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.ColbertV2Request PickJinaColbertV2() => JinaColbertV2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JinaColbertV2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingsV1EmbeddingsPostRequest(global::Jina.EmbeddingsV2Request value) => new EmbeddingsV1EmbeddingsPostRequest((global::Jina.EmbeddingsV2Request?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV2Request?(EmbeddingsV1EmbeddingsPostRequest @this) => @this.JinaEmbeddingsV2BaseCode;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(global::Jina.EmbeddingsV2Request? value)
        {
            JinaEmbeddingsV2BaseCode = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsV1EmbeddingsPostRequest FromJinaEmbeddingsV2BaseCode(global::Jina.EmbeddingsV2Request? value) => new EmbeddingsV1EmbeddingsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingsV1EmbeddingsPostRequest(global::Jina.EmbeddingsV3Request value) => new EmbeddingsV1EmbeddingsPostRequest((global::Jina.EmbeddingsV3Request?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV3Request?(EmbeddingsV1EmbeddingsPostRequest @this) => @this.JinaEmbeddingsV3;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(global::Jina.EmbeddingsV3Request? value)
        {
            JinaEmbeddingsV3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsV1EmbeddingsPostRequest FromJinaEmbeddingsV3(global::Jina.EmbeddingsV3Request? value) => new EmbeddingsV1EmbeddingsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingsV1EmbeddingsPostRequest(global::Jina.EmbeddingsV4Request value) => new EmbeddingsV1EmbeddingsPostRequest((global::Jina.EmbeddingsV4Request?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV4Request?(EmbeddingsV1EmbeddingsPostRequest @this) => @this.JinaEmbeddingsV4;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(global::Jina.EmbeddingsV4Request? value)
        {
            JinaEmbeddingsV4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsV1EmbeddingsPostRequest FromJinaEmbeddingsV4(global::Jina.EmbeddingsV4Request? value) => new EmbeddingsV1EmbeddingsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingsV1EmbeddingsPostRequest(global::Jina.EmbeddingsV5Request value) => new EmbeddingsV1EmbeddingsPostRequest((global::Jina.EmbeddingsV5Request?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV5Request?(EmbeddingsV1EmbeddingsPostRequest @this) => @this.JinaEmbeddingsV5OmniNano;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(global::Jina.EmbeddingsV5Request? value)
        {
            JinaEmbeddingsV5OmniNano = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsV1EmbeddingsPostRequest FromJinaEmbeddingsV5OmniNano(global::Jina.EmbeddingsV5Request? value) => new EmbeddingsV1EmbeddingsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingsV1EmbeddingsPostRequest(global::Jina.CodeEmbeddings500MRequest value) => new EmbeddingsV1EmbeddingsPostRequest((global::Jina.CodeEmbeddings500MRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.CodeEmbeddings500MRequest?(EmbeddingsV1EmbeddingsPostRequest @this) => @this.JinaCodeEmbeddings05b;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(global::Jina.CodeEmbeddings500MRequest? value)
        {
            JinaCodeEmbeddings05b = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsV1EmbeddingsPostRequest FromJinaCodeEmbeddings05b(global::Jina.CodeEmbeddings500MRequest? value) => new EmbeddingsV1EmbeddingsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingsV1EmbeddingsPostRequest(global::Jina.CodeEmbeddings1500MRequest value) => new EmbeddingsV1EmbeddingsPostRequest((global::Jina.CodeEmbeddings1500MRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.CodeEmbeddings1500MRequest?(EmbeddingsV1EmbeddingsPostRequest @this) => @this.JinaCodeEmbeddings15b;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(global::Jina.CodeEmbeddings1500MRequest? value)
        {
            JinaCodeEmbeddings15b = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsV1EmbeddingsPostRequest FromJinaCodeEmbeddings15b(global::Jina.CodeEmbeddings1500MRequest? value) => new EmbeddingsV1EmbeddingsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingsV1EmbeddingsPostRequest(global::Jina.ClipV1Request value) => new EmbeddingsV1EmbeddingsPostRequest((global::Jina.ClipV1Request?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.ClipV1Request?(EmbeddingsV1EmbeddingsPostRequest @this) => @this.JinaClipV1;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(global::Jina.ClipV1Request? value)
        {
            JinaClipV1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsV1EmbeddingsPostRequest FromJinaClipV1(global::Jina.ClipV1Request? value) => new EmbeddingsV1EmbeddingsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingsV1EmbeddingsPostRequest(global::Jina.ClipV2Request value) => new EmbeddingsV1EmbeddingsPostRequest((global::Jina.ClipV2Request?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.ClipV2Request?(EmbeddingsV1EmbeddingsPostRequest @this) => @this.JinaClipV2;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(global::Jina.ClipV2Request? value)
        {
            JinaClipV2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsV1EmbeddingsPostRequest FromJinaClipV2(global::Jina.ClipV2Request? value) => new EmbeddingsV1EmbeddingsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingsV1EmbeddingsPostRequest(global::Jina.ColbertV1Request value) => new EmbeddingsV1EmbeddingsPostRequest((global::Jina.ColbertV1Request?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.ColbertV1Request?(EmbeddingsV1EmbeddingsPostRequest @this) => @this.JinaColbertV1En;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(global::Jina.ColbertV1Request? value)
        {
            JinaColbertV1En = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsV1EmbeddingsPostRequest FromJinaColbertV1En(global::Jina.ColbertV1Request? value) => new EmbeddingsV1EmbeddingsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingsV1EmbeddingsPostRequest(global::Jina.ColbertV2Request value) => new EmbeddingsV1EmbeddingsPostRequest((global::Jina.ColbertV2Request?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.ColbertV2Request?(EmbeddingsV1EmbeddingsPostRequest @this) => @this.JinaColbertV2;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(global::Jina.ColbertV2Request? value)
        {
            JinaColbertV2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsV1EmbeddingsPostRequest FromJinaColbertV2(global::Jina.ColbertV2Request? value) => new EmbeddingsV1EmbeddingsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(
            global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel? model,
            global::Jina.EmbeddingsV2Request? jinaEmbeddingsV2BaseCode,
            global::Jina.EmbeddingsV3Request? jinaEmbeddingsV3,
            global::Jina.EmbeddingsV4Request? jinaEmbeddingsV4,
            global::Jina.EmbeddingsV5Request? jinaEmbeddingsV5OmniNano,
            global::Jina.CodeEmbeddings500MRequest? jinaCodeEmbeddings05b,
            global::Jina.CodeEmbeddings1500MRequest? jinaCodeEmbeddings15b,
            global::Jina.ClipV1Request? jinaClipV1,
            global::Jina.ClipV2Request? jinaClipV2,
            global::Jina.ColbertV1Request? jinaColbertV1En,
            global::Jina.ColbertV2Request? jinaColbertV2
            )
        {
            Model = model;

            JinaEmbeddingsV2BaseCode = jinaEmbeddingsV2BaseCode;
            JinaEmbeddingsV3 = jinaEmbeddingsV3;
            JinaEmbeddingsV4 = jinaEmbeddingsV4;
            JinaEmbeddingsV5OmniNano = jinaEmbeddingsV5OmniNano;
            JinaCodeEmbeddings05b = jinaCodeEmbeddings05b;
            JinaCodeEmbeddings15b = jinaCodeEmbeddings15b;
            JinaClipV1 = jinaClipV1;
            JinaClipV2 = jinaClipV2;
            JinaColbertV1En = jinaColbertV1En;
            JinaColbertV2 = jinaColbertV2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            JinaColbertV2 as object ??
            JinaColbertV1En as object ??
            JinaClipV2 as object ??
            JinaClipV1 as object ??
            JinaCodeEmbeddings15b as object ??
            JinaCodeEmbeddings05b as object ??
            JinaEmbeddingsV5OmniNano as object ??
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
            JinaEmbeddingsV5OmniNano?.ToString() ??
            JinaCodeEmbeddings05b?.ToString() ??
            JinaCodeEmbeddings15b?.ToString() ??
            JinaClipV1?.ToString() ??
            JinaClipV2?.ToString() ??
            JinaColbertV1En?.ToString() ??
            JinaColbertV2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5OmniNano && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 || !IsJinaEmbeddingsV2BaseCode && IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5OmniNano && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5OmniNano && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && IsJinaEmbeddingsV5OmniNano && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5OmniNano && IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5OmniNano && !IsJinaCodeEmbeddings05b && IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5OmniNano && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5OmniNano && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5OmniNano && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && IsJinaColbertV1En && !IsJinaColbertV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV4 && !IsJinaEmbeddingsV5OmniNano && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && IsJinaColbertV2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Jina.EmbeddingsV2Request, TResult>? jinaEmbeddingsV2BaseCode = null,
            global::System.Func<global::Jina.EmbeddingsV3Request, TResult>? jinaEmbeddingsV3 = null,
            global::System.Func<global::Jina.EmbeddingsV4Request, TResult>? jinaEmbeddingsV4 = null,
            global::System.Func<global::Jina.EmbeddingsV5Request, TResult>? jinaEmbeddingsV5OmniNano = null,
            global::System.Func<global::Jina.CodeEmbeddings500MRequest, TResult>? jinaCodeEmbeddings05b = null,
            global::System.Func<global::Jina.CodeEmbeddings1500MRequest, TResult>? jinaCodeEmbeddings15b = null,
            global::System.Func<global::Jina.ClipV1Request, TResult>? jinaClipV1 = null,
            global::System.Func<global::Jina.ClipV2Request, TResult>? jinaClipV2 = null,
            global::System.Func<global::Jina.ColbertV1Request, TResult>? jinaColbertV1En = null,
            global::System.Func<global::Jina.ColbertV2Request, TResult>? jinaColbertV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JinaEmbeddingsV2BaseCode is { } __value0 && jinaEmbeddingsV2BaseCode != null)
            {
                return jinaEmbeddingsV2BaseCode(__value0);
            }
            else if (JinaEmbeddingsV3 is { } __value1 && jinaEmbeddingsV3 != null)
            {
                return jinaEmbeddingsV3(__value1);
            }
            else if (JinaEmbeddingsV4 is { } __value2 && jinaEmbeddingsV4 != null)
            {
                return jinaEmbeddingsV4(__value2);
            }
            else if (JinaEmbeddingsV5OmniNano is { } __value3 && jinaEmbeddingsV5OmniNano != null)
            {
                return jinaEmbeddingsV5OmniNano(__value3);
            }
            else if (JinaCodeEmbeddings05b is { } __value4 && jinaCodeEmbeddings05b != null)
            {
                return jinaCodeEmbeddings05b(__value4);
            }
            else if (JinaCodeEmbeddings15b is { } __value5 && jinaCodeEmbeddings15b != null)
            {
                return jinaCodeEmbeddings15b(__value5);
            }
            else if (JinaClipV1 is { } __value6 && jinaClipV1 != null)
            {
                return jinaClipV1(__value6);
            }
            else if (JinaClipV2 is { } __value7 && jinaClipV2 != null)
            {
                return jinaClipV2(__value7);
            }
            else if (JinaColbertV1En is { } __value8 && jinaColbertV1En != null)
            {
                return jinaColbertV1En(__value8);
            }
            else if (JinaColbertV2 is { } __value9 && jinaColbertV2 != null)
            {
                return jinaColbertV2(__value9);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Jina.EmbeddingsV2Request>? jinaEmbeddingsV2BaseCode = null,

            global::System.Action<global::Jina.EmbeddingsV3Request>? jinaEmbeddingsV3 = null,

            global::System.Action<global::Jina.EmbeddingsV4Request>? jinaEmbeddingsV4 = null,

            global::System.Action<global::Jina.EmbeddingsV5Request>? jinaEmbeddingsV5OmniNano = null,

            global::System.Action<global::Jina.CodeEmbeddings500MRequest>? jinaCodeEmbeddings05b = null,

            global::System.Action<global::Jina.CodeEmbeddings1500MRequest>? jinaCodeEmbeddings15b = null,

            global::System.Action<global::Jina.ClipV1Request>? jinaClipV1 = null,

            global::System.Action<global::Jina.ClipV2Request>? jinaClipV2 = null,

            global::System.Action<global::Jina.ColbertV1Request>? jinaColbertV1En = null,

            global::System.Action<global::Jina.ColbertV2Request>? jinaColbertV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JinaEmbeddingsV2BaseCode is { } __value0)
            {
                jinaEmbeddingsV2BaseCode?.Invoke(__value0);
            }
            else if (JinaEmbeddingsV3 is { } __value1)
            {
                jinaEmbeddingsV3?.Invoke(__value1);
            }
            else if (JinaEmbeddingsV4 is { } __value2)
            {
                jinaEmbeddingsV4?.Invoke(__value2);
            }
            else if (JinaEmbeddingsV5OmniNano is { } __value3)
            {
                jinaEmbeddingsV5OmniNano?.Invoke(__value3);
            }
            else if (JinaCodeEmbeddings05b is { } __value4)
            {
                jinaCodeEmbeddings05b?.Invoke(__value4);
            }
            else if (JinaCodeEmbeddings15b is { } __value5)
            {
                jinaCodeEmbeddings15b?.Invoke(__value5);
            }
            else if (JinaClipV1 is { } __value6)
            {
                jinaClipV1?.Invoke(__value6);
            }
            else if (JinaClipV2 is { } __value7)
            {
                jinaClipV2?.Invoke(__value7);
            }
            else if (JinaColbertV1En is { } __value8)
            {
                jinaColbertV1En?.Invoke(__value8);
            }
            else if (JinaColbertV2 is { } __value9)
            {
                jinaColbertV2?.Invoke(__value9);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Jina.EmbeddingsV2Request>? jinaEmbeddingsV2BaseCode = null,
            global::System.Action<global::Jina.EmbeddingsV3Request>? jinaEmbeddingsV3 = null,
            global::System.Action<global::Jina.EmbeddingsV4Request>? jinaEmbeddingsV4 = null,
            global::System.Action<global::Jina.EmbeddingsV5Request>? jinaEmbeddingsV5OmniNano = null,
            global::System.Action<global::Jina.CodeEmbeddings500MRequest>? jinaCodeEmbeddings05b = null,
            global::System.Action<global::Jina.CodeEmbeddings1500MRequest>? jinaCodeEmbeddings15b = null,
            global::System.Action<global::Jina.ClipV1Request>? jinaClipV1 = null,
            global::System.Action<global::Jina.ClipV2Request>? jinaClipV2 = null,
            global::System.Action<global::Jina.ColbertV1Request>? jinaColbertV1En = null,
            global::System.Action<global::Jina.ColbertV2Request>? jinaColbertV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JinaEmbeddingsV2BaseCode is { } __value0)
            {
                jinaEmbeddingsV2BaseCode?.Invoke(__value0);
            }
            else if (JinaEmbeddingsV3 is { } __value1)
            {
                jinaEmbeddingsV3?.Invoke(__value1);
            }
            else if (JinaEmbeddingsV4 is { } __value2)
            {
                jinaEmbeddingsV4?.Invoke(__value2);
            }
            else if (JinaEmbeddingsV5OmniNano is { } __value3)
            {
                jinaEmbeddingsV5OmniNano?.Invoke(__value3);
            }
            else if (JinaCodeEmbeddings05b is { } __value4)
            {
                jinaCodeEmbeddings05b?.Invoke(__value4);
            }
            else if (JinaCodeEmbeddings15b is { } __value5)
            {
                jinaCodeEmbeddings15b?.Invoke(__value5);
            }
            else if (JinaClipV1 is { } __value6)
            {
                jinaClipV1?.Invoke(__value6);
            }
            else if (JinaClipV2 is { } __value7)
            {
                jinaClipV2?.Invoke(__value7);
            }
            else if (JinaColbertV1En is { } __value8)
            {
                jinaColbertV1En?.Invoke(__value8);
            }
            else if (JinaColbertV2 is { } __value9)
            {
                jinaColbertV2?.Invoke(__value9);
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
                typeof(global::Jina.EmbeddingsV2Request),
                JinaEmbeddingsV3,
                typeof(global::Jina.EmbeddingsV3Request),
                JinaEmbeddingsV4,
                typeof(global::Jina.EmbeddingsV4Request),
                JinaEmbeddingsV5OmniNano,
                typeof(global::Jina.EmbeddingsV5Request),
                JinaCodeEmbeddings05b,
                typeof(global::Jina.CodeEmbeddings500MRequest),
                JinaCodeEmbeddings15b,
                typeof(global::Jina.CodeEmbeddings1500MRequest),
                JinaClipV1,
                typeof(global::Jina.ClipV1Request),
                JinaClipV2,
                typeof(global::Jina.ClipV2Request),
                JinaColbertV1En,
                typeof(global::Jina.ColbertV1Request),
                JinaColbertV2,
                typeof(global::Jina.ColbertV2Request),
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
        public bool Equals(EmbeddingsV1EmbeddingsPostRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV2Request?>.Default.Equals(JinaEmbeddingsV2BaseCode, other.JinaEmbeddingsV2BaseCode) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV3Request?>.Default.Equals(JinaEmbeddingsV3, other.JinaEmbeddingsV3) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV4Request?>.Default.Equals(JinaEmbeddingsV4, other.JinaEmbeddingsV4) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV5Request?>.Default.Equals(JinaEmbeddingsV5OmniNano, other.JinaEmbeddingsV5OmniNano) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.CodeEmbeddings500MRequest?>.Default.Equals(JinaCodeEmbeddings05b, other.JinaCodeEmbeddings05b) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.CodeEmbeddings1500MRequest?>.Default.Equals(JinaCodeEmbeddings15b, other.JinaCodeEmbeddings15b) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ClipV1Request?>.Default.Equals(JinaClipV1, other.JinaClipV1) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ClipV2Request?>.Default.Equals(JinaClipV2, other.JinaClipV2) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ColbertV1Request?>.Default.Equals(JinaColbertV1En, other.JinaColbertV1En) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ColbertV2Request?>.Default.Equals(JinaColbertV2, other.JinaColbertV2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EmbeddingsV1EmbeddingsPostRequest obj1, EmbeddingsV1EmbeddingsPostRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsV1EmbeddingsPostRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EmbeddingsV1EmbeddingsPostRequest obj1, EmbeddingsV1EmbeddingsPostRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsV1EmbeddingsPostRequest o && Equals(o);
        }
    }
}
