using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// How frequently data for subscription products like Investments, Transactions, and Liabilities, is being refreshed, relative to the institution's normal scheduling. The <c>refresh_interval</c> may be <c>DELAYED</c> or <c>STOPPED</c> even when the success rate is high.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RefreshInterval>))]
public sealed record RefreshInterval : OpenStringEnum<RefreshInterval>
{
    private RefreshInterval(string value) : base(value)
    {
    }

    public static readonly RefreshInterval Normal = new("NORMAL");

    public static readonly RefreshInterval Delayed = new("DELAYED");

    public static readonly RefreshInterval Stopped = new("STOPPED");

    public TResult Match<TResult>(Func<TResult> onNormal,
        Func<TResult> onDelayed,
        Func<TResult> onStopped,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Normal => onNormal(),
            _ when this == Delayed => onDelayed(),
            _ when this == Stopped => onStopped(),
            _ => otherwise(Value)
        };

    public void Match(Action onNormal, Action onDelayed, Action onStopped, Action<string> otherwise)
    {
        if (this == Normal) onNormal();
        else if (this == Delayed) onDelayed();
        else if (this == Stopped) onStopped();
        else otherwise(Value);
    }
}
