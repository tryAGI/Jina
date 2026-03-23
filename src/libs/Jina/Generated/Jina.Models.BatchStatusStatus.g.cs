
#nullable enable

namespace Jina
{
    /// <summary>
    /// Current status of the batch job.
    /// </summary>
    public enum BatchStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchStatusStatus value)
        {
            return value switch
            {
                BatchStatusStatus.Cancelled => "cancelled",
                BatchStatusStatus.Completed => "completed",
                BatchStatusStatus.Expired => "expired",
                BatchStatusStatus.Failed => "failed",
                BatchStatusStatus.Pending => "pending",
                BatchStatusStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => BatchStatusStatus.Cancelled,
                "completed" => BatchStatusStatus.Completed,
                "expired" => BatchStatusStatus.Expired,
                "failed" => BatchStatusStatus.Failed,
                "pending" => BatchStatusStatus.Pending,
                "processing" => BatchStatusStatus.Processing,
                _ => null,
            };
        }
    }
}