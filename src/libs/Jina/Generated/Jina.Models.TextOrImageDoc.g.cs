
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// BaseDoc is the base class for all Documents. This class should be subclassed<br/>
    /// to create new Document types with a specific schema.<br/>
    /// The schema of a Document is defined by the fields of the class.<br/>
    /// Example:<br/>
    /// ```python<br/>
    /// from docarray import BaseDoc<br/>
    /// from docarray.typing import NdArray, ImageUrl<br/>
    /// import numpy as np<br/>
    /// class MyDoc(BaseDoc):<br/>
    ///     embedding: NdArray[512]<br/>
    ///     image: ImageUrl<br/>
    /// doc = MyDoc(embedding=np.zeros(512), image='https://example.com/image.jpg')<br/>
    /// ```<br/>
    /// BaseDoc is a subclass of [pydantic.BaseModel](<br/>
    /// https://docs.pydantic.dev/usage/models/) and can be used in a similar way.
    /// </summary>
    public sealed partial class TextOrImageDoc
    {
        /// <summary>
        /// The ID of the BaseDoc. This is useful for indexing in vector stores. If not set by user, it will automatically be assigned a random value<br/>
        /// Example: 50336949b5bd1f1ed97f3085d76258a1
        /// </summary>
        /// <example>50336949b5bd1f1ed97f3085d76258a1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// URL of an image file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// base64 representation of the Image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public byte[]? Bytes { get; set; }

        /// <summary>
        /// base64 representation of the Image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytesname")]
        public string? Bytesname { get; set; }

        /// <summary>
        /// Image representation that can hold URL of an image or a base64 representation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, byte[]>))]
        public global::Jina.AnyOf<string, byte[]>? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextOrImageDoc" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the BaseDoc. This is useful for indexing in vector stores. If not set by user, it will automatically be assigned a random value<br/>
        /// Example: 50336949b5bd1f1ed97f3085d76258a1
        /// </param>
        /// <param name="text"></param>
        /// <param name="url">
        /// URL of an image file
        /// </param>
        /// <param name="bytes">
        /// base64 representation of the Image.
        /// </param>
        /// <param name="bytesname">
        /// base64 representation of the Image.
        /// </param>
        /// <param name="image">
        /// Image representation that can hold URL of an image or a base64 representation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextOrImageDoc(
            string? id,
            string? text,
            string? url,
            byte[]? bytes,
            string? bytesname,
            global::Jina.AnyOf<string, byte[]>? image)
        {
            this.Id = id;
            this.Text = text;
            this.Url = url;
            this.Bytes = bytes;
            this.Bytesname = bytesname;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextOrImageDoc" /> class.
        /// </summary>
        public TextOrImageDoc()
        {
        }
    }
}