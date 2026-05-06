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
        /// Jina Embeddings v5 model with task-specific LoRA adapters and flexible<br/>
        /// dimensions. Small/nano sizes support text-only; the omni variant also<br/>
        /// accepts images, videos, audio, and PDFs in a single shared vector space.<br/>
        /// Each top-level list item is a single modality (one Doc class), with one<br/>
        /// exception: a `MergedContentGroup` (`{"content": [...]}`) fuses multiple<br/>
        /// chunks (text + image/video/audio) into a single embedding via one model<br/>
        /// forward pass.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.EmbeddingsV5Request? JinaEmbeddingsV5OmniSmall { get; init; }
#else
        public global::Jina.EmbeddingsV5Request? JinaEmbeddingsV5OmniSmall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaEmbeddingsV5OmniSmall))]
#endif
        public bool IsJinaEmbeddingsV5OmniSmall => JinaEmbeddingsV5OmniSmall != null;

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
        /// Code embedding model (500M) for code search and understanding.
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
        /// Code embedding model (1.5B) for code search and understanding.
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
        /// ELSER v2 request schema.<br/>
        /// Example: {"input":["What is machine learning?","How does AI work?"],"model":"elser-v2","task":"retrieval.query"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.ELSERV2Request? ElserV2 { get; init; }
#else
        public global::Jina.ELSERV2Request? ElserV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElserV2))]
#endif
        public bool IsElserV2 => ElserV2 != null;
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
        public static implicit operator EmbeddingsV1EmbeddingsPostRequest(global::Jina.EmbeddingsV5Request value) => new EmbeddingsV1EmbeddingsPostRequest((global::Jina.EmbeddingsV5Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.EmbeddingsV5Request?(EmbeddingsV1EmbeddingsPostRequest @this) => @this.JinaEmbeddingsV5OmniSmall;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(global::Jina.EmbeddingsV5Request? value)
        {
            JinaEmbeddingsV5OmniSmall = value;
        }

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
        public static implicit operator EmbeddingsV1EmbeddingsPostRequest(global::Jina.ELSERV2Request value) => new EmbeddingsV1EmbeddingsPostRequest((global::Jina.ELSERV2Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.ELSERV2Request?(EmbeddingsV1EmbeddingsPostRequest @this) => @this.ElserV2;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(global::Jina.ELSERV2Request? value)
        {
            ElserV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequest(
            global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel? model,
            global::Jina.EmbeddingsV2Request? jinaEmbeddingsV2BaseCode,
            global::Jina.EmbeddingsV3Request? jinaEmbeddingsV3,
            global::Jina.EmbeddingsV5Request? jinaEmbeddingsV5OmniSmall,
            global::Jina.EmbeddingsV4Request? jinaEmbeddingsV4,
            global::Jina.CodeEmbeddings500MRequest? jinaCodeEmbeddings05b,
            global::Jina.CodeEmbeddings1500MRequest? jinaCodeEmbeddings15b,
            global::Jina.ClipV1Request? jinaClipV1,
            global::Jina.ClipV2Request? jinaClipV2,
            global::Jina.ColbertV1Request? jinaColbertV1En,
            global::Jina.ColbertV2Request? jinaColbertV2,
            global::Jina.ELSERV2Request? elserV2
            )
        {
            Model = model;

            JinaEmbeddingsV2BaseCode = jinaEmbeddingsV2BaseCode;
            JinaEmbeddingsV3 = jinaEmbeddingsV3;
            JinaEmbeddingsV5OmniSmall = jinaEmbeddingsV5OmniSmall;
            JinaEmbeddingsV4 = jinaEmbeddingsV4;
            JinaCodeEmbeddings05b = jinaCodeEmbeddings05b;
            JinaCodeEmbeddings15b = jinaCodeEmbeddings15b;
            JinaClipV1 = jinaClipV1;
            JinaClipV2 = jinaClipV2;
            JinaColbertV1En = jinaColbertV1En;
            JinaColbertV2 = jinaColbertV2;
            ElserV2 = elserV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ElserV2 as object ??
            JinaColbertV2 as object ??
            JinaColbertV1En as object ??
            JinaClipV2 as object ??
            JinaClipV1 as object ??
            JinaCodeEmbeddings15b as object ??
            JinaCodeEmbeddings05b as object ??
            JinaEmbeddingsV4 as object ??
            JinaEmbeddingsV5OmniSmall as object ??
            JinaEmbeddingsV3 as object ??
            JinaEmbeddingsV2BaseCode as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JinaEmbeddingsV2BaseCode?.ToString() ??
            JinaEmbeddingsV3?.ToString() ??
            JinaEmbeddingsV5OmniSmall?.ToString() ??
            JinaEmbeddingsV4?.ToString() ??
            JinaCodeEmbeddings05b?.ToString() ??
            JinaCodeEmbeddings15b?.ToString() ??
            JinaClipV1?.ToString() ??
            JinaClipV2?.ToString() ??
            JinaColbertV1En?.ToString() ??
            JinaColbertV2?.ToString() ??
            ElserV2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV5OmniSmall && !IsJinaEmbeddingsV4 && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 && !IsElserV2 || !IsJinaEmbeddingsV2BaseCode && IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV5OmniSmall && !IsJinaEmbeddingsV4 && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 && !IsElserV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && IsJinaEmbeddingsV5OmniSmall && !IsJinaEmbeddingsV4 && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 && !IsElserV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV5OmniSmall && IsJinaEmbeddingsV4 && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 && !IsElserV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV5OmniSmall && !IsJinaEmbeddingsV4 && IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 && !IsElserV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV5OmniSmall && !IsJinaEmbeddingsV4 && !IsJinaCodeEmbeddings05b && IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 && !IsElserV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV5OmniSmall && !IsJinaEmbeddingsV4 && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 && !IsElserV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV5OmniSmall && !IsJinaEmbeddingsV4 && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 && !IsElserV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV5OmniSmall && !IsJinaEmbeddingsV4 && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && IsJinaColbertV1En && !IsJinaColbertV2 && !IsElserV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV5OmniSmall && !IsJinaEmbeddingsV4 && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && IsJinaColbertV2 && !IsElserV2 || !IsJinaEmbeddingsV2BaseCode && !IsJinaEmbeddingsV3 && !IsJinaEmbeddingsV5OmniSmall && !IsJinaEmbeddingsV4 && !IsJinaCodeEmbeddings05b && !IsJinaCodeEmbeddings15b && !IsJinaClipV1 && !IsJinaClipV2 && !IsJinaColbertV1En && !IsJinaColbertV2 && IsElserV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Jina.EmbeddingsV2Request?, TResult>? jinaEmbeddingsV2BaseCode = null,
            global::System.Func<global::Jina.EmbeddingsV3Request?, TResult>? jinaEmbeddingsV3 = null,
            global::System.Func<global::Jina.EmbeddingsV5Request?, TResult>? jinaEmbeddingsV5OmniSmall = null,
            global::System.Func<global::Jina.EmbeddingsV4Request?, TResult>? jinaEmbeddingsV4 = null,
            global::System.Func<global::Jina.CodeEmbeddings500MRequest?, TResult>? jinaCodeEmbeddings05b = null,
            global::System.Func<global::Jina.CodeEmbeddings1500MRequest?, TResult>? jinaCodeEmbeddings15b = null,
            global::System.Func<global::Jina.ClipV1Request?, TResult>? jinaClipV1 = null,
            global::System.Func<global::Jina.ClipV2Request?, TResult>? jinaClipV2 = null,
            global::System.Func<global::Jina.ColbertV1Request?, TResult>? jinaColbertV1En = null,
            global::System.Func<global::Jina.ColbertV2Request?, TResult>? jinaColbertV2 = null,
            global::System.Func<global::Jina.ELSERV2Request?, TResult>? elserV2 = null,
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
            else if (IsJinaEmbeddingsV5OmniSmall && jinaEmbeddingsV5OmniSmall != null)
            {
                return jinaEmbeddingsV5OmniSmall(JinaEmbeddingsV5OmniSmall!);
            }
            else if (IsJinaEmbeddingsV4 && jinaEmbeddingsV4 != null)
            {
                return jinaEmbeddingsV4(JinaEmbeddingsV4!);
            }
            else if (IsJinaCodeEmbeddings05b && jinaCodeEmbeddings05b != null)
            {
                return jinaCodeEmbeddings05b(JinaCodeEmbeddings05b!);
            }
            else if (IsJinaCodeEmbeddings15b && jinaCodeEmbeddings15b != null)
            {
                return jinaCodeEmbeddings15b(JinaCodeEmbeddings15b!);
            }
            else if (IsJinaClipV1 && jinaClipV1 != null)
            {
                return jinaClipV1(JinaClipV1!);
            }
            else if (IsJinaClipV2 && jinaClipV2 != null)
            {
                return jinaClipV2(JinaClipV2!);
            }
            else if (IsJinaColbertV1En && jinaColbertV1En != null)
            {
                return jinaColbertV1En(JinaColbertV1En!);
            }
            else if (IsJinaColbertV2 && jinaColbertV2 != null)
            {
                return jinaColbertV2(JinaColbertV2!);
            }
            else if (IsElserV2 && elserV2 != null)
            {
                return elserV2(ElserV2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Jina.EmbeddingsV2Request?>? jinaEmbeddingsV2BaseCode = null,
            global::System.Action<global::Jina.EmbeddingsV3Request?>? jinaEmbeddingsV3 = null,
            global::System.Action<global::Jina.EmbeddingsV5Request?>? jinaEmbeddingsV5OmniSmall = null,
            global::System.Action<global::Jina.EmbeddingsV4Request?>? jinaEmbeddingsV4 = null,
            global::System.Action<global::Jina.CodeEmbeddings500MRequest?>? jinaCodeEmbeddings05b = null,
            global::System.Action<global::Jina.CodeEmbeddings1500MRequest?>? jinaCodeEmbeddings15b = null,
            global::System.Action<global::Jina.ClipV1Request?>? jinaClipV1 = null,
            global::System.Action<global::Jina.ClipV2Request?>? jinaClipV2 = null,
            global::System.Action<global::Jina.ColbertV1Request?>? jinaColbertV1En = null,
            global::System.Action<global::Jina.ColbertV2Request?>? jinaColbertV2 = null,
            global::System.Action<global::Jina.ELSERV2Request?>? elserV2 = null,
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
            else if (IsJinaEmbeddingsV5OmniSmall)
            {
                jinaEmbeddingsV5OmniSmall?.Invoke(JinaEmbeddingsV5OmniSmall!);
            }
            else if (IsJinaEmbeddingsV4)
            {
                jinaEmbeddingsV4?.Invoke(JinaEmbeddingsV4!);
            }
            else if (IsJinaCodeEmbeddings05b)
            {
                jinaCodeEmbeddings05b?.Invoke(JinaCodeEmbeddings05b!);
            }
            else if (IsJinaCodeEmbeddings15b)
            {
                jinaCodeEmbeddings15b?.Invoke(JinaCodeEmbeddings15b!);
            }
            else if (IsJinaClipV1)
            {
                jinaClipV1?.Invoke(JinaClipV1!);
            }
            else if (IsJinaClipV2)
            {
                jinaClipV2?.Invoke(JinaClipV2!);
            }
            else if (IsJinaColbertV1En)
            {
                jinaColbertV1En?.Invoke(JinaColbertV1En!);
            }
            else if (IsJinaColbertV2)
            {
                jinaColbertV2?.Invoke(JinaColbertV2!);
            }
            else if (IsElserV2)
            {
                elserV2?.Invoke(ElserV2!);
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
                JinaEmbeddingsV5OmniSmall,
                typeof(global::Jina.EmbeddingsV5Request),
                JinaEmbeddingsV4,
                typeof(global::Jina.EmbeddingsV4Request),
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
                ElserV2,
                typeof(global::Jina.ELSERV2Request),
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
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV5Request?>.Default.Equals(JinaEmbeddingsV5OmniSmall, other.JinaEmbeddingsV5OmniSmall) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.EmbeddingsV4Request?>.Default.Equals(JinaEmbeddingsV4, other.JinaEmbeddingsV4) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.CodeEmbeddings500MRequest?>.Default.Equals(JinaCodeEmbeddings05b, other.JinaCodeEmbeddings05b) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.CodeEmbeddings1500MRequest?>.Default.Equals(JinaCodeEmbeddings15b, other.JinaCodeEmbeddings15b) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ClipV1Request?>.Default.Equals(JinaClipV1, other.JinaClipV1) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ClipV2Request?>.Default.Equals(JinaClipV2, other.JinaClipV2) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ColbertV1Request?>.Default.Equals(JinaColbertV1En, other.JinaColbertV1En) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ColbertV2Request?>.Default.Equals(JinaColbertV2, other.JinaColbertV2) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ELSERV2Request?>.Default.Equals(ElserV2, other.ElserV2) 
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
