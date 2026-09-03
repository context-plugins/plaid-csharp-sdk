using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Enum representing the entity authenticating the user.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ItemCreateAuthentication>))]
public sealed record ItemCreateAuthentication : StringEnum<ItemCreateAuthentication>
{
    private ItemCreateAuthentication(string value) : base(value)
    {
    }

    public static readonly ItemCreateAuthentication Unknown = new("UNKNOWN");

    public static readonly ItemCreateAuthentication DataPartner = new("DATA_PARTNER");

    public static readonly ItemCreateAuthentication Plaid = new("PLAID");

    public static ItemCreateAuthentication FromValue(string value) => FromValueCore(value);
}
