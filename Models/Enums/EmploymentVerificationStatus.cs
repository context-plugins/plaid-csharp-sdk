using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Current employment status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EmploymentVerificationStatus>))]
public sealed record EmploymentVerificationStatus : StringEnum<EmploymentVerificationStatus>
{
    private EmploymentVerificationStatus(string value) : base(value)
    {
    }

    public static readonly EmploymentVerificationStatus EmploymentStatusActive = new("EMPLOYMENT_STATUS_ACTIVE");

    public static readonly EmploymentVerificationStatus EmploymentStatusInactive = new("EMPLOYMENT_STATUS_INACTIVE");

    public static EmploymentVerificationStatus FromValue(string value) => FromValueCore(value);
}
