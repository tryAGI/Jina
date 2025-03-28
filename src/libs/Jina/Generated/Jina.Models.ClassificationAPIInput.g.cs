
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// The input to the API for classify endpoint. OpenAI compatible
    /// </summary>
    public sealed partial class ClassificationAPIInput
    {
        /// <summary>
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// - `jina-clip-v2`,	865M,	1024<br/>
        /// - `jina-embeddings-v2-base-en`,	137M,	768<br/>
        /// - `jina-embeddings-v2-base-es`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-de`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-zh`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-code`,	137M,	768<br/>
        /// - `jina-embeddings-v3`,	570M,	1024<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The identifier of the classifier. If not provided, a new classifier will be created.<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_id")]
        public string? ClassifierId { get; set; }

        /// <summary>
        /// List of text and images or a single text and image for classification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.ApiSchemasClassificationTextDoc, global::Jina.ApiSchemasClassificationImageDoc, string>>, global::Jina.ApiSchemasClassificationTextDoc, global::Jina.ApiSchemasClassificationImageDoc, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.ApiSchemasClassificationTextDoc, global::Jina.ApiSchemasClassificationImageDoc, string>>, global::Jina.ApiSchemasClassificationTextDoc, global::Jina.ApiSchemasClassificationImageDoc, string> Input { get; set; }

        /// <summary>
        /// List of labels or a dictionary of structured labels for zero-shot classification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>))]
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationAPIInput" /> class.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// - `jina-clip-v2`,	865M,	1024<br/>
        /// - `jina-embeddings-v2-base-en`,	137M,	768<br/>
        /// - `jina-embeddings-v2-base-es`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-de`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-zh`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-code`,	137M,	768<br/>
        /// - `jina-embeddings-v3`,	570M,	1024<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).
        /// </param>
        /// <param name="classifierId">
        /// The identifier of the classifier. If not provided, a new classifier will be created.<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </param>
        /// <param name="input">
        /// List of text and images or a single text and image for classification
        /// </param>
        /// <param name="labels">
        /// List of labels or a dictionary of structured labels for zero-shot classification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassificationAPIInput(
            global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.ApiSchemasClassificationTextDoc, global::Jina.ApiSchemasClassificationImageDoc, string>>, global::Jina.ApiSchemasClassificationTextDoc, global::Jina.ApiSchemasClassificationImageDoc, string> input,
            string? model,
            string? classifierId,
            global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? labels)
        {
            this.Input = input;
            this.Model = model;
            this.ClassifierId = classifierId;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationAPIInput" /> class.
        /// </summary>
        public ClassificationAPIInput()
        {
        }
    }
}