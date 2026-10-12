using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Whether the account is employer sponsored retirement account or not (e.g., 401K, 403b, 457, thrift savings plan)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetEmployerSponsoredIndicator>))]
public sealed record AssetEmployerSponsoredIndicator : OpenStringEnum<AssetEmployerSponsoredIndicator>
{
    private AssetEmployerSponsoredIndicator(string value) : base(value)
    {
    }

    public static readonly AssetEmployerSponsoredIndicator Yes = new("Yes");

    public static readonly AssetEmployerSponsoredIndicator No = new("No");

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
