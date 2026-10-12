using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of cashflow attributes. Required if using Cash Flow Insights.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CashflowAttributesVersion>))]
public sealed record CashflowAttributesVersion : OpenStringEnum<CashflowAttributesVersion>
{
    private CashflowAttributesVersion(string value) : base(value)
    {
    }

    public static readonly CashflowAttributesVersion V10 = new("v1.0");

    public static readonly CashflowAttributesVersion V20 = new("v2.0");

    public static readonly CashflowAttributesVersion Cfi1 = new("CFI1");

    public TResult Match<TResult>(Func<TResult> onV10,
        Func<TResult> onV20,
        Func<TResult> onCfi1,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == V10 => onV10(),
            _ when this == V20 => onV20(),
            _ when this == Cfi1 => onCfi1(),
            _ => otherwise(Value)
        };

    public void Match(Action onV10, Action onV20, Action onCfi1, Action<string> otherwise)
    {
        if (this == V10) onV10();
        else if (this == V20) onV20();
        else if (this == Cfi1) onCfi1();
        else otherwise(Value);
    }
}
