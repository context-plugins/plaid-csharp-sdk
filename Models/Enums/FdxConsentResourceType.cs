using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of resource permissioned on a consent grant.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FdxConsentResourceType>))]
public sealed record FdxConsentResourceType : StringEnum<FdxConsentResourceType>
{
    private FdxConsentResourceType(string value) : base(value)
    {
    }

    public static readonly FdxConsentResourceType Account = new("ACCOUNT");

    public static readonly FdxConsentResourceType Customer = new("CUSTOMER");

    public static readonly FdxConsentResourceType Document = new("DOCUMENT");

    public static FdxConsentResourceType FromValue(string value) => FromValueCore(value);
}
