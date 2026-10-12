using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A description of the update status for transaction pulls of an Item. This field contains the same information provided by transactions webhooks, and may be helpful for webhook troubleshooting or when recovering from missed webhooks.
/// <para>
/// <c>TRANSACTIONS_UPDATE_STATUS_UNKNOWN</c>: Unable to fetch transactions update status for Item.
/// <c>NOT_READY</c>: The Item is pending transaction pull.
/// <c>INITIAL_UPDATE_COMPLETE</c>: Initial pull for the Item is complete, historical pull is pending.
/// <c>HISTORICAL_UPDATE_COMPLETE</c>: Both initial and historical pull for Item are complete.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionsUpdateStatus>))]
public sealed record TransactionsUpdateStatus : OpenStringEnum<TransactionsUpdateStatus>
{
    private TransactionsUpdateStatus(string value) : base(value)
    {
    }

    public static readonly TransactionsUpdateStatus TransactionsUpdateStatusUnknown = new(
        "TRANSACTIONS_UPDATE_STATUS_UNKNOWN");

    public static readonly TransactionsUpdateStatus NotReady = new("NOT_READY");

    public static readonly TransactionsUpdateStatus InitialUpdateComplete = new("INITIAL_UPDATE_COMPLETE");

    public static readonly TransactionsUpdateStatus HistoricalUpdateComplete = new("HISTORICAL_UPDATE_COMPLETE");

    public TResult Match<TResult>(Func<TResult> onTransactionsUpdateStatusUnknown,
        Func<TResult> onNotReady,
        Func<TResult> onInitialUpdateComplete,
        Func<TResult> onHistoricalUpdateComplete,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TransactionsUpdateStatusUnknown => onTransactionsUpdateStatusUnknown(),
            _ when this == NotReady => onNotReady(),
            _ when this == InitialUpdateComplete => onInitialUpdateComplete(),
            _ when this == HistoricalUpdateComplete => onHistoricalUpdateComplete(),
            _ => otherwise(Value)
        };

    public void Match(Action onTransactionsUpdateStatusUnknown,
        Action onNotReady,
        Action onInitialUpdateComplete,
        Action onHistoricalUpdateComplete,
        Action<string> otherwise)
    {
        if (this == TransactionsUpdateStatusUnknown) onTransactionsUpdateStatusUnknown();
        else if (this == NotReady) onNotReady();
        else if (this == InitialUpdateComplete) onInitialUpdateComplete();
        else if (this == HistoricalUpdateComplete) onHistoricalUpdateComplete();
        else otherwise(Value);
    }
}
