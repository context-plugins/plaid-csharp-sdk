using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Current status of a consent grant. One of <c>ACTIVE</c>, <c>REVOKED</c>, <c>EXPIRED</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FdxConsentGrantStatus>))]
public sealed record FdxConsentGrantStatus : StringEnum<FdxConsentGrantStatus>
{
    private FdxConsentGrantStatus(string value) : base(value)
    {
    }

    public static readonly FdxConsentGrantStatus Active = new("ACTIVE");

    public static readonly FdxConsentGrantStatus Revoked = new("REVOKED");

    public static readonly FdxConsentGrantStatus Expired = new("EXPIRED");

    public static FdxConsentGrantStatus FromValue(string value) => FromValueCore(value);
}
