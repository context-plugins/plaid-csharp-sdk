using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Codes describing the object of a consent event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConsentEventCode>))]
public sealed record ConsentEventCode : StringEnum<ConsentEventCode>
{
    private ConsentEventCode(string value) : base(value)
    {
    }

    public static readonly ConsentEventCode UserAgreement = new("USER_AGREEMENT");

    public static readonly ConsentEventCode UseCases = new("USE_CASES");

    public static readonly ConsentEventCode DataScopes = new("DATA_SCOPES");

    public static readonly ConsentEventCode AccountScopes = new("ACCOUNT_SCOPES");

    public static readonly ConsentEventCode Revocation = new("REVOCATION");

    public static ConsentEventCode FromValue(string value) => FromValueCore(value);
}
