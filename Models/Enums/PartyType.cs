using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Identifies the type of a party
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartyType>))]
public sealed record PartyType : StringEnum<PartyType>
{
    private PartyType(string value) : base(value)
    {
    }

    public static readonly PartyType DataAccessPlatform = new("DATA_ACCESS_PLATFORM");

    public static readonly PartyType DataProvider = new("DATA_PROVIDER");

    public static readonly PartyType DataRecipient = new("DATA_RECIPIENT");

    public static readonly PartyType Individual = new("INDIVIDUAL");

    public static readonly PartyType Merchant = new("MERCHANT");

    public static readonly PartyType Vendor = new("VENDOR");

    public static PartyType FromValue(string value) => FromValueCore(value);
}
