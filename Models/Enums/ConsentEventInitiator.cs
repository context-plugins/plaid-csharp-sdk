using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The entity that initiated collection of consent.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConsentEventInitiator>))]
public sealed record ConsentEventInitiator : StringEnum<ConsentEventInitiator>
{
    private ConsentEventInitiator(string value) : base(value)
    {
    }

    public static readonly ConsentEventInitiator Plaid = new("PLAID");

    public static readonly ConsentEventInitiator DataProvider = new("DATA_PROVIDER");

    public static readonly ConsentEventInitiator Customer = new("CUSTOMER");

    public static readonly ConsentEventInitiator EndUser = new("END_USER");

    public static ConsentEventInitiator FromValue(string value) => FromValueCore(value);
}
