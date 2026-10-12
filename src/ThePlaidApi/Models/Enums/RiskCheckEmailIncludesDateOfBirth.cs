using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether the email address includes the date of birth or year of birth if known.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckEmailIncludesDateOfBirth>))]
public sealed record RiskCheckEmailIncludesDateOfBirth : OpenStringEnum<RiskCheckEmailIncludesDateOfBirth>
{
    private RiskCheckEmailIncludesDateOfBirth(string value) : base(value)
    {
    }

    public static readonly RiskCheckEmailIncludesDateOfBirth Yes = new("yes");

    public static readonly RiskCheckEmailIncludesDateOfBirth No = new("no");

    public static readonly RiskCheckEmailIncludesDateOfBirth NoData = new("no_data");

    public TResult Match<TResult>(Func<TResult> onYes,
        Func<TResult> onNo,
        Func<TResult> onNoData,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Yes => onYes(),
            _ when this == No => onNo(),
            _ when this == NoData => onNoData(),
            _ => otherwise(Value)
        };

    public void Match(Action onYes, Action onNo, Action onNoData, Action<string> otherwise)
    {
        if (this == Yes) onYes();
        else if (this == No) onNo();
        else if (this == NoData) onNoData();
        else otherwise(Value);
    }
}
