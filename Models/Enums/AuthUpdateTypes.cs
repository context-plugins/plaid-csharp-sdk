using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The possible types of auth data that may have changed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AuthUpdateTypes>))]
public sealed record AuthUpdateTypes : StringEnum<AuthUpdateTypes>
{
    private AuthUpdateTypes(string value) : base(value)
    {
    }

    public static readonly AuthUpdateTypes AccountNumber = new("ACCOUNT_NUMBER");

    public static readonly AuthUpdateTypes RoutingNumber = new("ROUTING_NUMBER");

    public static AuthUpdateTypes FromValue(string value) => FromValueCore(value);
}
