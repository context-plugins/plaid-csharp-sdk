using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the transfer intent.
/// <para>
/// <c>PENDING</c>: The transfer intent is pending.
/// <c>SUCCEEDED</c>: The transfer intent was successfully created.
/// <c>FAILED</c>: The transfer intent was unable to be created.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferIntentStatus>))]
public sealed record TransferIntentStatus : OpenStringEnum<TransferIntentStatus>
{
    private TransferIntentStatus(string value) : base(value)
    {
    }

    public static readonly TransferIntentStatus Pending = new("PENDING");

    public static readonly TransferIntentStatus Succeeded = new("SUCCEEDED");

    public static readonly TransferIntentStatus Failed = new("FAILED");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onSucceeded,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Succeeded => onSucceeded(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onSucceeded, Action onFailed, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Succeeded) onSucceeded();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
