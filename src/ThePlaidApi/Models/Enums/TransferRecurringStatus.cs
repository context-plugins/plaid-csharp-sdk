using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the recurring transfer.
/// <para>
/// <c>active</c>: The recurring transfer is currently active.
/// <c>cancelled</c>: The recurring transfer was cancelled by the client or Plaid.
/// <c>expired</c>: The recurring transfer has completed all originations according to its recurring schedule.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferRecurringStatus>))]
public sealed record TransferRecurringStatus : OpenStringEnum<TransferRecurringStatus>
{
    private TransferRecurringStatus(string value) : base(value)
    {
    }

    public static readonly TransferRecurringStatus Active = new("active");

    public static readonly TransferRecurringStatus Cancelled = new("cancelled");

    public static readonly TransferRecurringStatus Expired = new("expired");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onCancelled,
        Func<TResult> onExpired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Cancelled => onCancelled(),
            _ when this == Expired => onExpired(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onCancelled, Action onExpired, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Cancelled) onCancelled();
        else if (this == Expired) onExpired();
        else otherwise(Value);
    }
}
