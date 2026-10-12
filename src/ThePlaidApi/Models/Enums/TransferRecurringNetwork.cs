using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Networks eligible for recurring transfers.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferRecurringNetwork>))]
public sealed record TransferRecurringNetwork : OpenStringEnum<TransferRecurringNetwork>
{
    private TransferRecurringNetwork(string value) : base(value)
    {
    }

    public static readonly TransferRecurringNetwork Ach = new("ach");

    public static readonly TransferRecurringNetwork SameDayAch = new("same-day-ach");

    public static readonly TransferRecurringNetwork Rtp = new("rtp");

    public TResult Match<TResult>(Func<TResult> onAch,
        Func<TResult> onSameDayAch,
        Func<TResult> onRtp,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ach => onAch(),
            _ when this == SameDayAch => onSameDayAch(),
            _ when this == Rtp => onRtp(),
            _ => otherwise(Value)
        };

    public void Match(Action onAch, Action onSameDayAch, Action onRtp, Action<string> otherwise)
    {
        if (this == Ach) onAch();
        else if (this == SameDayAch) onSameDayAch();
        else if (this == Rtp) onRtp();
        else otherwise(Value);
    }
}
