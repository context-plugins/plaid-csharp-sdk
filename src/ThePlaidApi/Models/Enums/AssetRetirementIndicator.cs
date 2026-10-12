using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Whether or not the account is a retirement account (e.g., 401K, 403b, 457, thrift savings plans, traditional and Roth, IRAs, SEP-IRA, SIMPLE-IRA, KEOGH, state retirement savings plans, other independent and IRS-qualified employer retirement plans)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetRetirementIndicator>))]
public sealed record AssetRetirementIndicator : OpenStringEnum<AssetRetirementIndicator>
{
    private AssetRetirementIndicator(string value) : base(value)
    {
    }

    public static readonly AssetRetirementIndicator Yes = new("Yes");

    public static readonly AssetRetirementIndicator No = new("No");

    public TResult Match<TResult>(Func<TResult> onYes, Func<TResult> onNo, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Yes => onYes(),
            _ when this == No => onNo(),
            _ => otherwise(Value)
        };

    public void Match(Action onYes, Action onNo, Action<string> otherwise)
    {
        if (this == Yes) onYes();
        else if (this == No) onNo();
        else otherwise(Value);
    }
}
