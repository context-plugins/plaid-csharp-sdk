using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A broad categorization of the consent event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConsentEventType>))]
public sealed record ConsentEventType : StringEnum<ConsentEventType>
{
    private ConsentEventType(string value) : base(value)
    {
    }

    public static readonly ConsentEventType ConsentGranted = new("CONSENT_GRANTED");

    public static readonly ConsentEventType ConsentRevoked = new("CONSENT_REVOKED");

    public static readonly ConsentEventType ConsentUpdated = new("CONSENT_UPDATED");

    public static ConsentEventType FromValue(string value) => FromValueCore(value);
}
