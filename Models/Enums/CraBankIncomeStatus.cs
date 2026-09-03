using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the income sources.
/// <c>ACTIVE</c>: The income source is active.
/// <c>INACTIVE</c>: The income source is inactive.
/// <c>UNKNOWN</c>: The income source status is unknown.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraBankIncomeStatus>))]
public sealed record CraBankIncomeStatus : StringEnum<CraBankIncomeStatus>
{
    private CraBankIncomeStatus(string value) : base(value)
    {
    }

    public static readonly CraBankIncomeStatus Active = new("ACTIVE");

    public static readonly CraBankIncomeStatus Inactive = new("INACTIVE");

    public static readonly CraBankIncomeStatus Unknown = new("UNKNOWN");

    public static CraBankIncomeStatus FromValue(string value) => FromValueCore(value);
}
