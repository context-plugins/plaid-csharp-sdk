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
public sealed record AddressPurposeLabel : StringEnum<AddressPurposeLabel>
{
    private AddressPurposeLabel(string value) : base(value)
    {
    }

    public static readonly AddressPurposeLabel Residential = new("residential");

    public static readonly AddressPurposeLabel Commercial = new("commercial");

    public static readonly AddressPurposeLabel NoData = new("no_data");

    public static AddressPurposeLabel FromValue(string value) => FromValueCore(value);
}
