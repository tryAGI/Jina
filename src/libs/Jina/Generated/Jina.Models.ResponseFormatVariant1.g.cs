#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResponseFormatVariant1 : global::System.IEquatable<ResponseFormatVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Jina.ChatCompletionRequestResponseFormatVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.ResponseFormatText? Text { get; init; }
#else
        public global::Jina.ResponseFormatText? Text { get; }
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
            out global::Jina.ResponseFormatText? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.ResponseFormatText PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.ResponseFormatJSONObject? JsonObject { get; init; }
#else
        public global::Jina.ResponseFormatJSONObject? JsonObject { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonObject))]
#endif
        public bool IsJsonObject => JsonObject != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJsonObject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.ResponseFormatJSONObject? value)
        {
            value = JsonObject;
            return IsJsonObject;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.ResponseFormatJSONObject PickJsonObject() => IsJsonObject
            ? JsonObject!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonObject' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Jina.ResponseFormatJSONSchema? JsonSchema { get; init; }
#else
        public global::Jina.ResponseFormatJSONSchema? JsonSchema { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchema))]
#endif
        public bool IsJsonSchema => JsonSchema != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJsonSchema(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Jina.ResponseFormatJSONSchema? value)
        {
            value = JsonSchema;
            return IsJsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Jina.ResponseFormatJSONSchema PickJsonSchema() => IsJsonSchema
            ? JsonSchema!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonSchema' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormatVariant1(global::Jina.ResponseFormatText value) => new ResponseFormatVariant1((global::Jina.ResponseFormatText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.ResponseFormatText?(ResponseFormatVariant1 @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormatVariant1(global::Jina.ResponseFormatText? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormatVariant1 FromText(global::Jina.ResponseFormatText? value) => new ResponseFormatVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormatVariant1(global::Jina.ResponseFormatJSONObject value) => new ResponseFormatVariant1((global::Jina.ResponseFormatJSONObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.ResponseFormatJSONObject?(ResponseFormatVariant1 @this) => @this.JsonObject;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormatVariant1(global::Jina.ResponseFormatJSONObject? value)
        {
            JsonObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormatVariant1 FromJsonObject(global::Jina.ResponseFormatJSONObject? value) => new ResponseFormatVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormatVariant1(global::Jina.ResponseFormatJSONSchema value) => new ResponseFormatVariant1((global::Jina.ResponseFormatJSONSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Jina.ResponseFormatJSONSchema?(ResponseFormatVariant1 @this) => @this.JsonSchema;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormatVariant1(global::Jina.ResponseFormatJSONSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormatVariant1 FromJsonSchema(global::Jina.ResponseFormatJSONSchema? value) => new ResponseFormatVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseFormatVariant1(
            global::Jina.ChatCompletionRequestResponseFormatVariant1DiscriminatorType? type,
            global::Jina.ResponseFormatText? text,
            global::Jina.ResponseFormatJSONObject? jsonObject,
            global::Jina.ResponseFormatJSONSchema? jsonSchema
            )
        {
            Type = type;

            Text = text;
            JsonObject = jsonObject;
            JsonSchema = jsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            JsonSchema as object ??
            JsonObject as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            JsonObject?.ToString() ??
            JsonSchema?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJsonObject && !IsJsonSchema || !IsText && IsJsonObject && !IsJsonSchema || !IsText && !IsJsonObject && IsJsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Jina.ResponseFormatText, TResult>? text = null,
            global::System.Func<global::Jina.ResponseFormatJSONObject, TResult>? jsonObject = null,
            global::System.Func<global::Jina.ResponseFormatJSONSchema, TResult>? jsonSchema = null,
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
            else if (IsJsonObject && jsonObject != null)
            {
                return jsonObject(JsonObject!);
            }
            else if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Jina.ResponseFormatText>? text = null,

            global::System.Action<global::Jina.ResponseFormatJSONObject>? jsonObject = null,

            global::System.Action<global::Jina.ResponseFormatJSONSchema>? jsonSchema = null,
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
            else if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Jina.ResponseFormatText>? text = null,
            global::System.Action<global::Jina.ResponseFormatJSONObject>? jsonObject = null,
            global::System.Action<global::Jina.ResponseFormatJSONSchema>? jsonSchema = null,
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
            else if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
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
                typeof(global::Jina.ResponseFormatText),
                JsonObject,
                typeof(global::Jina.ResponseFormatJSONObject),
                JsonSchema,
                typeof(global::Jina.ResponseFormatJSONSchema),
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
        public bool Equals(ResponseFormatVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Jina.ResponseFormatText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ResponseFormatJSONObject?>.Default.Equals(JsonObject, other.JsonObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Jina.ResponseFormatJSONSchema?>.Default.Equals(JsonSchema, other.JsonSchema)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseFormatVariant1 obj1, ResponseFormatVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormatVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseFormatVariant1 obj1, ResponseFormatVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormatVariant1 o && Equals(o);
        }
    }
}
