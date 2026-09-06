
#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public enum CodeEmbeddings500MRequestTask
    {
        /// <summary>
        ///
        /// </summary>
        Code2codePassage,
        /// <summary>
        ///
        /// </summary>
        Code2codeQuery,
        /// <summary>
        ///
        /// </summary>
        Code2completionPassage,
        /// <summary>
        ///
        /// </summary>
        Code2completionQuery,
        /// <summary>
        ///
        /// </summary>
        Code2nlPassage,
        /// <summary>
        ///
        /// </summary>
        Code2nlQuery,
        /// <summary>
        ///
        /// </summary>
        Nl2codePassage,
        /// <summary>
        ///
        /// </summary>
        Nl2codeQuery,
        /// <summary>
        ///
        /// </summary>
        QaPassage,
        /// <summary>
        ///
        /// </summary>
        QaQuery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeEmbeddings500MRequestTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeEmbeddings500MRequestTask value)
        {
            return value switch
            {
                CodeEmbeddings500MRequestTask.Code2codePassage => "code2code.passage",
                CodeEmbeddings500MRequestTask.Code2codeQuery => "code2code.query",
                CodeEmbeddings500MRequestTask.Code2completionPassage => "code2completion.passage",
                CodeEmbeddings500MRequestTask.Code2completionQuery => "code2completion.query",
                CodeEmbeddings500MRequestTask.Code2nlPassage => "code2nl.passage",
                CodeEmbeddings500MRequestTask.Code2nlQuery => "code2nl.query",
                CodeEmbeddings500MRequestTask.Nl2codePassage => "nl2code.passage",
                CodeEmbeddings500MRequestTask.Nl2codeQuery => "nl2code.query",
                CodeEmbeddings500MRequestTask.QaPassage => "qa.passage",
                CodeEmbeddings500MRequestTask.QaQuery => "qa.query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeEmbeddings500MRequestTask? ToEnum(string value)
        {
            return value switch
            {
                "code2code.passage" => CodeEmbeddings500MRequestTask.Code2codePassage,
                "code2code.query" => CodeEmbeddings500MRequestTask.Code2codeQuery,
                "code2completion.passage" => CodeEmbeddings500MRequestTask.Code2completionPassage,
                "code2completion.query" => CodeEmbeddings500MRequestTask.Code2completionQuery,
                "code2nl.passage" => CodeEmbeddings500MRequestTask.Code2nlPassage,
                "code2nl.query" => CodeEmbeddings500MRequestTask.Code2nlQuery,
                "nl2code.passage" => CodeEmbeddings500MRequestTask.Nl2codePassage,
                "nl2code.query" => CodeEmbeddings500MRequestTask.Nl2codeQuery,
                "qa.passage" => CodeEmbeddings500MRequestTask.QaPassage,
                "qa.query" => CodeEmbeddings500MRequestTask.QaQuery,
                _ => null,
            };
        }
    }
}