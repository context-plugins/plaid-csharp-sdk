using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the income source.
/// <c>ACTIVE</c>: The income source is active.
/// <c>INACTIVE</c>: The income source is inactive.
/// <c>UNKNOWN</c>: The income source status is unknown.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraVerificationIncomeStatus>))]
public sealed record CraVerificationIncomeStatus : StringEnum<CraVerificationIncomeStatus>
{
    private CraVerificationIncomeStatus(string value) : base(value)
    {
    }

    public static readonly CraVerificationIncomeStatus Active = new("ACTIVE");

    public static readonly CraVerificationIncomeStatus Inactive = new("INACTIVE");

    public static readonly CraVerificationIncomeStatus Unknown = new("UNKNOWN");

    public static CraVerificationIncomeStatus FromValue(string value) => FromValueCore(value);
}
