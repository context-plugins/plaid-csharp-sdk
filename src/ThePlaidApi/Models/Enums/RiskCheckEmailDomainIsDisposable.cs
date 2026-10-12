using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether the email domain is listed as disposable if known. Disposable domains are often used to create email addresses that are part of a fake set of user details.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckEmailDomainIsDisposable>))]
public sealed record RiskCheckEmailDomainIsDisposable : OpenStringEnum<RiskCheckEmailDomainIsDisposable>
{
    private RiskCheckEmailDomainIsDisposable(string value) : base(value)
    {
    }

    public static readonly RiskCheckEmailDomainIsDisposable Yes = new("yes");

    public static readonly RiskCheckEmailDomainIsDisposable No = new("no");

    public static readonly RiskCheckEmailDomainIsDisposable NoData = new("no_data");

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
