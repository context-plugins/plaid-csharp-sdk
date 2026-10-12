using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Whether or not the stock is restricted, i.e. "Restricted" or "Not Restricted"
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetHoldingRestrictedIndicator>))]
public sealed record AssetHoldingRestrictedIndicator : OpenStringEnum<AssetHoldingRestrictedIndicator>
{
    private AssetHoldingRestrictedIndicator(string value) : base(value)
    {
    }

    public static readonly AssetHoldingRestrictedIndicator Yes = new("Yes");

    public static readonly AssetHoldingRestrictedIndicator No = new("No");

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
