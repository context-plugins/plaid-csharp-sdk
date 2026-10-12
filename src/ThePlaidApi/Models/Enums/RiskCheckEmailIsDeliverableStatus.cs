using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// SMTP-MX check to confirm the email address exists if known.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckEmailIsDeliverableStatus>))]
public sealed record RiskCheckEmailIsDeliverableStatus : OpenStringEnum<RiskCheckEmailIsDeliverableStatus>
{
    private RiskCheckEmailIsDeliverableStatus(string value) : base(value)
    {
    }

    public static readonly RiskCheckEmailIsDeliverableStatus Yes = new("yes");

    public static readonly RiskCheckEmailIsDeliverableStatus No = new("no");

    public static readonly RiskCheckEmailIsDeliverableStatus NoData = new("no_data");

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
