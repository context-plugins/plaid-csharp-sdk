using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The originator's expected transfer frequency.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OriginatorExpectedTransferFrequency>))]
public sealed record OriginatorExpectedTransferFrequency : OpenStringEnum<OriginatorExpectedTransferFrequency>
{
    private OriginatorExpectedTransferFrequency(string value) : base(value)
    {
    }

    public static readonly OriginatorExpectedTransferFrequency OncePerMonth = new("once_per_month");

    public static readonly OriginatorExpectedTransferFrequency TwicePerMonth = new("twice_per_month");

    public static readonly OriginatorExpectedTransferFrequency OncePerWeek = new("once_per_week");

    public static readonly OriginatorExpectedTransferFrequency Daily = new("daily");

    public TResult Match<TResult>(Func<TResult> onOncePerMonth,
        Func<TResult> onTwicePerMonth,
        Func<TResult> onOncePerWeek,
        Func<TResult> onDaily,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OncePerMonth => onOncePerMonth(),
            _ when this == TwicePerMonth => onTwicePerMonth(),
            _ when this == OncePerWeek => onOncePerWeek(),
            _ when this == Daily => onDaily(),
            _ => otherwise(Value)
        };

    public void Match(Action onOncePerMonth,
        Action onTwicePerMonth,
        Action onOncePerWeek,
        Action onDaily,
        Action<string> otherwise)
    {
        if (this == OncePerMonth) onOncePerMonth();
        else if (this == TwicePerMonth) onTwicePerMonth();
        else if (this == OncePerWeek) onOncePerWeek();
        else if (this == Daily) onDaily();
        else otherwise(Value);
    }
}
