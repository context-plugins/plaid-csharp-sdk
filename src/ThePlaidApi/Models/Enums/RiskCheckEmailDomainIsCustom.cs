using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether the email address domain is custom if known, i.e. a company domain and not free or disposable.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckEmailDomainIsCustom>))]
public sealed record RiskCheckEmailDomainIsCustom : OpenStringEnum<RiskCheckEmailDomainIsCustom>
{
    private RiskCheckEmailDomainIsCustom(string value) : base(value)
    {
    }

    public static readonly RiskCheckEmailDomainIsCustom Yes = new("yes");

    public static readonly RiskCheckEmailDomainIsCustom No = new("no");

    public static readonly RiskCheckEmailDomainIsCustom NoData = new("no_data");

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
