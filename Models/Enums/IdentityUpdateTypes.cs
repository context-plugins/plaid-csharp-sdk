using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The possible types of identity data that may have changed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentityUpdateTypes>))]
public sealed record IdentityUpdateTypes : StringEnum<IdentityUpdateTypes>
{
    private IdentityUpdateTypes(string value) : base(value)
    {
    }

    public static readonly IdentityUpdateTypes Phones = new("PHONES");

    public static readonly IdentityUpdateTypes Addresses = new("ADDRESSES");

    public static readonly IdentityUpdateTypes Emails = new("EMAILS");

    public static readonly IdentityUpdateTypes Names = new("NAMES");

    public static IdentityUpdateTypes FromValue(string value) => FromValueCore(value);
}
