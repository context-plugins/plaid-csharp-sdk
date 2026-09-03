using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A status enum indicating whether autofill succeeded or failed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentityVerificationAutofillStatus>))]
public sealed record IdentityVerificationAutofillStatus : StringEnum<IdentityVerificationAutofillStatus>
{
    private IdentityVerificationAutofillStatus(string value) : base(value)
    {
    }

    public static readonly IdentityVerificationAutofillStatus Success = new("success");

    public static readonly IdentityVerificationAutofillStatus Failed = new("failed");

    public static IdentityVerificationAutofillStatus FromValue(string value) => FromValueCore(value);
}
