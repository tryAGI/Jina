#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RerankV1RerankPostRequest : global::System.IEquatable<RerankV1RerankPostRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Jina.RerankV1RerankPostRequestDiscriminatorModel? Model { get; }

        /// <summary>
        /// Text reranking request for v1/v2 models.<br/>
        /// Example: {"documents":["Climate Change and Renewable Energy: A Global Perspective. Rising temperatures and extreme weather events are accelerating the transition to solar and wind power worldwide.","Le changement climatique et l\u0027\u00E9nergie renouvelable : une perspective europ\u00E9enne. L\u0027Union europ\u00E9enne investit massivement dans les technologies vertes pour atteindre la neutralit\u00E9 carbone d\u0027ici 2050.","Klimawandel und erneuerbare Energien: Deutsche Energiewende. Deutschland f\u00FChrt die Transformation des Energiesektors durch innovative Technologien und politische Ma\u00DFnahmen an.","\u6C14\u5019\u53D8\u5316\u5BF9\u53EF\u518D\u751F\u80FD\u6E90\u7684\u5F71\u54CD\uFF1A\u4E2D\u56FD\u7684\u7EFF\u8272\u53D1\u5C55\u6218\u7565\u3002\u4E2D\u56FD\u6B63\u5728\u5927\u529B\u63A8\u8FDB\u592A\u9633\u80FD\u548C\u98CE\u80FD\u9879\u76EE\uFF0C\u4EE5\u5B9E\u73B0\u78B3\u4E2D\u548C\u76EE\u6807\u3002","Artificial Intelligence in Healthcare: Revolutionizing Medical Diagnosis. AI-powered systems are improving accuracy in disease detection and treatment recommendations.","Blockchain Technology: Transforming Financial Services. Decentralized finance applications are reshaping traditional banking and payment systems."],"model":"jina-reranker-v2-base-multilingual","query":"Climate change impact on renewable energy adoption","return_documents":false,"top_n":4}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.TextRerankerRequest? JinaRerankerV2BaseMultilingual { get; init; }
#else
        public global::Jina.TextRerankerRequest? JinaRerankerV2BaseMultilingual { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaRerankerV2BaseMultilingual))]
#endif
        public bool IsJinaRerankerV2BaseMultilingual => JinaRerankerV2BaseMultilingual != null;

        /// <summary>
        /// Multimodal reranking for text and images.<br/>
        /// Example: {"documents":[{"image":"https://raw.githubusercontent.com/jina-ai/multimodal-reranker-test/main/paper-11.png"},{"text":"Attention Is All You Need: This groundbreaking paper introduced the Transformer architecture, revolutionizing natural language processing and becoming the foundation for modern large language models like GPT and BERT."},"Recent advances in computer vision have led to the development of vision transformers (ViTs) that achieve state-of-the-art performance on image classification tasks by treating images as sequences of patches.",{"image":"https://raw.githubusercontent.com/jina-ai/multimodal-reranker-test/main/wired-preview.png"},{"text":"Graph Neural Networks: A Review of Methods and Applications. This comprehensive survey covers the latest developments in graph-based machine learning, including graph convolutional networks and graph attention mechanisms."},"Traditional database systems struggle with the volume and variety of modern data workloads, leading to the adoption of distributed computing frameworks like Apache Spark and Hadoop for big data processing."],"model":"jina-reranker-m0","query":"innovative artificial intelligence research papers and visual data analysis","return_documents":false,"top_n":4}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.RerankerM0Request? JinaRerankerM0 { get; init; }
#else
        public global::Jina.RerankerM0Request? JinaRerankerM0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaRerankerM0))]
#endif
        public bool IsJinaRerankerM0 => JinaRerankerM0 != null;

        /// <summary>
        /// Reranker v3 listwise model for high-quality multilingual retrieval.<br/>
        /// Example: {"documents":["Climate Change and Renewable Energy: A Global Perspective. Rising temperatures and extreme weather events are accelerating the transition to solar and wind power worldwide.","Le changement climatique et l\u0027\u00E9nergie renouvelable : une perspective europ\u00E9enne. L\u0027Union europ\u00E9enne investit massivement dans les technologies vertes pour atteindre la neutralit\u00E9 carbone d\u0027ici 2050.","Klimawandel und erneuerbare Energien: Deutsche Energiewende. Deutschland f\u00FChrt die Transformation des Energiesektors durch innovative Technologien und politische Ma\u00DFnahmen an.","\u6C14\u5019\u53D8\u5316\u5BF9\u53EF\u518D\u751F\u80FD\u6E90\u7684\u5F71\u54CD\uFF1A\u4E2D\u56FD\u7684\u7EFF\u8272\u53D1\u5C55\u6218\u7565\u3002\u4E2D\u56FD\u6B63\u5728\u5927\u529B\u63A8\u8FDB\u592A\u9633\u80FD\u548C\u98CE\u80FD\u9879\u76EE\uFF0C\u4EE5\u5B9E\u73B0\u78B3\u4E2D\u548C\u76EE\u6807\u3002","Artificial Intelligence in Healthcare: Revolutionizing Medical Diagnosis. AI-powered systems are improving accuracy in disease detection and treatment recommendations.","Blockchain Technology: Transforming Financial Services. Decentralized finance applications are reshaping traditional banking and payment systems."],"model":"jina-reranker-v3","query":"Climate change impact on renewable energy adoption","return_documents":false,"return_embeddings":false,"top_n":4}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.RerankerV3Request? JinaRerankerV3 { get; init; }
#else
        public global::Jina.RerankerV3Request? JinaRerankerV3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinaRerankerV3))]
#endif
        public bool IsJinaRerankerV3 => JinaRerankerV3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankV1RerankPostRequest(global::Jina.TextRerankerRequest value) => new RerankV1RerankPostRequest((global::Jina.TextRerankerRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.TextRerankerRequest?(RerankV1RerankPostRequest @this) => @this.JinaRerankerV2BaseMultilingual;

        /// <summary>
        /// 
        /// </summary>
        public RerankV1RerankPostRequest(global::Jina.TextRerankerRequest? value)
        {
            JinaRerankerV2BaseMultilingual = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankV1RerankPostRequest(global::Jina.RerankerM0Request value) => new RerankV1RerankPostRequest((global::Jina.RerankerM0Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.RerankerM0Request?(RerankV1RerankPostRequest @this) => @this.JinaRerankerM0;

        /// <summary>
        /// 
        /// </summary>
        public RerankV1RerankPostRequest(global::Jina.RerankerM0Request? value)
        {
            JinaRerankerM0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankV1RerankPostRequest(global::Jina.RerankerV3Request value) => new RerankV1RerankPostRequest((global::Jina.RerankerV3Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Jina.RerankerV3Request?(RerankV1RerankPostRequest @this) => @this.JinaRerankerV3;

        /// <summary>
        /// 
        /// </summary>
        public RerankV1RerankPostRequest(global::Jina.RerankerV3Request? value)
        {
            JinaRerankerV3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RerankV1RerankPostRequest(
            global::Jina.RerankV1RerankPostRequestDiscriminatorModel? model,
            global::Jina.TextRerankerRequest? jinaRerankerV2BaseMultilingual,
            global::Jina.RerankerM0Request? jinaRerankerM0,
            global::Jina.RerankerV3Request? jinaRerankerV3
            )
        {
            Model = model;

            JinaRerankerV2BaseMultilingual = jinaRerankerV2BaseMultilingual;
            JinaRerankerM0 = jinaRerankerM0;
            JinaRerankerV3 = jinaRerankerV3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JinaRerankerV3 as object ??
            JinaRerankerM0 as object ??
            JinaRerankerV2BaseMultilingual as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JinaRerankerV2BaseMultilingual?.ToString() ??
            JinaRerankerM0?.ToString() ??
            JinaRerankerV3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJinaRerankerV2BaseMultilingual && !IsJinaRerankerM0 && !IsJinaRerankerV3 || !IsJinaRerankerV2BaseMultilingual && IsJinaRerankerM0 && !IsJinaRerankerV3 || !IsJinaRerankerV2BaseMultilingual && !IsJinaRerankerM0 && IsJinaRerankerV3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Jina.TextRerankerRequest?, TResult>? jinaRerankerV2BaseMultilingual = null,
            global::System.Func<global::Jina.RerankerM0Request?, TResult>? jinaRerankerM0 = null,
            global::System.Func<global::Jina.RerankerV3Request?, TResult>? jinaRerankerV3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJinaRerankerV2BaseMultilingual && jinaRerankerV2BaseMultilingual != null)
            {
                return jinaRerankerV2BaseMultilingual(JinaRerankerV2BaseMultilingual!);
            }
            else if (IsJinaRerankerM0 && jinaRerankerM0 != null)
            {
                return jinaRerankerM0(JinaRerankerM0!);
            }
            else if (IsJinaRerankerV3 && jinaRerankerV3 != null)
            {
                return jinaRerankerV3(JinaRerankerV3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Jina.TextRerankerRequest?>? jinaRerankerV2BaseMultilingual = null,
            global::System.Action<global::Jina.RerankerM0Request?>? jinaRerankerM0 = null,
            global::System.Action<global::Jina.RerankerV3Request?>? jinaRerankerV3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJinaRerankerV2BaseMultilingual)
            {
                jinaRerankerV2BaseMultilingual?.Invoke(JinaRerankerV2BaseMultilingual!);
            }
            else if (IsJinaRerankerM0)
            {
                jinaRerankerM0?.Invoke(JinaRerankerM0!);
            }
            else if (IsJinaRerankerV3)
            {
                jinaRerankerV3?.Invoke(JinaRerankerV3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JinaRerankerV2BaseMultilingual,
                typeof(global::Jina.TextRerankerRequest),
                JinaRerankerM0,
                typeof(global::Jina.RerankerM0Request),
                JinaRerankerV3,
                typeof(global::Jina.RerankerV3Request),
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
        public bool Equals(RerankV1RerankPostRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Jina.TextRerankerRequest?>.Default.Equals(JinaRerankerV2BaseMultilingual, other.JinaRerankerV2BaseMultilingual) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.RerankerM0Request?>.Default.Equals(JinaRerankerM0, other.JinaRerankerM0) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.RerankerV3Request?>.Default.Equals(JinaRerankerV3, other.JinaRerankerV3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RerankV1RerankPostRequest obj1, RerankV1RerankPostRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RerankV1RerankPostRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RerankV1RerankPostRequest obj1, RerankV1RerankPostRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RerankV1RerankPostRequest o && Equals(o);
        }
    }
}
