using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Risk level for the given risk check type, when available.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskLevelWithNoData>))]
public sealed record RiskLevelWithNoData : OpenStringEnum<RiskLevelWithNoData>
{
    private RiskLevelWithNoData(string value) : base(value)
    {
    }

    public static readonly RiskLevelWithNoData Low = new("low");

    public static readonly RiskLevelWithNoData Medium = new("medium");

    public static readonly RiskLevelWithNoData High = new("high");

    public static readonly RiskLevelWithNoData NoData = new("no_data");

    public TResult Match<TResult>(Func<TResult> onLow,
        Func<TResult> onMedium,
        Func<TResult> onHigh,
        Func<TResult> onNoData,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Low => onLow(),
            _ when this == Medium => onMedium(),
            _ when this == High => onHigh(),
            _ when this == NoData => onNoData(),
            _ => otherwise(Value)
        };

    public void Match(Action onLow, Action onMedium, Action onHigh, Action onNoData, Action<string> otherwise)
    {
        if (this == Low) onLow();
        else if (this == Medium) onMedium();
        else if (this == High) onHigh();
        else if (this == NoData) onNoData();
        else otherwise(Value);
    }
}
