using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Field describing whether the associated address is being used for commercial or residential purposes.
/// <para>
/// Note: This value will be <c>no_data</c> when Plaid does not have sufficient data to determine the address's use.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AddressPurposeLabel>))]
public sealed record AddressPurposeLabel : OpenStringEnum<AddressPurposeLabel>
{
    private AddressPurposeLabel(string value) : base(value)
    {
    }

    public static readonly AddressPurposeLabel Residential = new("residential");

    public static readonly AddressPurposeLabel Commercial = new("commercial");

    public static readonly AddressPurposeLabel NoData = new("no_data");

    public TResult Match<TResult>(Func<TResult> onResidential,
        Func<TResult> onCommercial,
        Func<TResult> onNoData,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Residential => onResidential(),
            _ when this == Commercial => onCommercial(),
            _ when this == NoData => onNoData(),
            _ => otherwise(Value)
        };

    public void Match(Action onResidential, Action onCommercial, Action onNoData, Action<string> otherwise)
    {
        if (this == Residential) onResidential();
        else if (this == Commercial) onCommercial();
        else if (this == NoData) onNoData();
        else otherwise(Value);
    }
}
