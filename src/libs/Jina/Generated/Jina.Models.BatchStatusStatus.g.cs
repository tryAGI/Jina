
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
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
                BatchStatusStatus.Pending => "pending",
                BatchStatusStatus.Processing => "processing",
                BatchStatusStatus.Completed => "completed",
                BatchStatusStatus.Failed => "failed",
                BatchStatusStatus.Expired => "expired",
                BatchStatusStatus.Cancelled => "cancelled",
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
                "pending" => BatchStatusStatus.Pending,
                "processing" => BatchStatusStatus.Processing,
                "completed" => BatchStatusStatus.Completed,
                "failed" => BatchStatusStatus.Failed,
                "expired" => BatchStatusStatus.Expired,
                "cancelled" => BatchStatusStatus.Cancelled,
                _ => null,
            };
        }
    }
}