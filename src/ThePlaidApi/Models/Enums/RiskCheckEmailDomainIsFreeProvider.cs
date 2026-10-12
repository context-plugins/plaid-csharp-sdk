using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether the email address domain is a free provider such as Gmail or Hotmail if known.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckEmailDomainIsFreeProvider>))]
public sealed record RiskCheckEmailDomainIsFreeProvider : OpenStringEnum<RiskCheckEmailDomainIsFreeProvider>
{
    private RiskCheckEmailDomainIsFreeProvider(string value) : base(value)
    {
    }

    public static readonly RiskCheckEmailDomainIsFreeProvider Yes = new("yes");

    public static readonly RiskCheckEmailDomainIsFreeProvider No = new("no");

    public static readonly RiskCheckEmailDomainIsFreeProvider NoData = new("no_data");

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
