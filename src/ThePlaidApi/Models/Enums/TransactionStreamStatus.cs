using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The current status of the transaction stream.
/// <para>
/// <c>MATURE</c>: A <c>MATURE</c> recurring stream should have at least 3 transactions and happen on a regular cadence (For Annual recurring stream, we will mark it <c>MATURE</c> after 2 instances).
/// </para>
/// <para>
/// <c>EARLY_DETECTION</c>: When a recurring transaction first appears in the transaction history and before it fulfills the requirement of a mature stream, the status will be <c>EARLY_DETECTION</c>.
/// </para>
/// <para>
/// <c>TOMBSTONED</c>: A stream that was previously in the <c>EARLY_DETECTION</c> status will move to the <c>TOMBSTONED</c> status when no further transactions were found at the next expected date.
/// </para>
/// <para>
/// <c>UNKNOWN</c>: A stream is assigned an <c>UNKNOWN</c> status when none of the other statuses are applicable.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionStreamStatus>))]
public sealed record TransactionStreamStatus : OpenStringEnum<TransactionStreamStatus>
{
    private TransactionStreamStatus(string value) : base(value)
    {
    }

    public static readonly TransactionStreamStatus Unknown = new("UNKNOWN");

    public static readonly TransactionStreamStatus Mature = new("MATURE");

    public static readonly TransactionStreamStatus EarlyDetection = new("EARLY_DETECTION");

    public static readonly TransactionStreamStatus Tombstoned = new("TOMBSTONED");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onMature,
        Func<TResult> onEarlyDetection,
        Func<TResult> onTombstoned,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == Mature => onMature(),
            _ when this == EarlyDetection => onEarlyDetection(),
            _ when this == Tombstoned => onTombstoned(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown,
        Action onMature,
        Action onEarlyDetection,
        Action onTombstoned,
        Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == Mature) onMature();
        else if (this == EarlyDetection) onEarlyDetection();
        else if (this == Tombstoned) onTombstoned();
        else otherwise(Value);
    }
}
