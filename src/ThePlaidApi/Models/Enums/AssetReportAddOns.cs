using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Add-ons that should be included in the Asset Report.
/// <para>
/// <c>investments</c>: The Investments add-on
/// <c>fast_assets</c>: The Fast Assets add-on
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetReportAddOns>))]
public sealed record AssetReportAddOns : OpenStringEnum<AssetReportAddOns>
{
    private AssetReportAddOns(string value) : base(value)
    {
    }

    public static readonly AssetReportAddOns Investments = new("investments");

    public static readonly AssetReportAddOns FastAssets = new("fast_assets");

    public TResult Match<TResult>(Func<TResult> onInvestments,
        Func<TResult> onFastAssets,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Investments => onInvestments(),
            _ when this == FastAssets => onFastAssets(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvestments, Action onFastAssets, Action<string> otherwise)
    {
        if (this == Investments) onInvestments();
        else if (this == FastAssets) onFastAssets();
        else otherwise(Value);
    }
}
