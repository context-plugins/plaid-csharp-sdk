using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of home lending report.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraCheckReportVerificationGetReportType>))]
public sealed record CraCheckReportVerificationGetReportType : StringEnum<CraCheckReportVerificationGetReportType>
{
    private CraCheckReportVerificationGetReportType(string value) : base(value)
    {
    }

    public static readonly CraCheckReportVerificationGetReportType Voa = new("VOA");

    public static readonly CraCheckReportVerificationGetReportType EmploymentRefresh = new("EMPLOYMENT_REFRESH");

    public static readonly CraCheckReportVerificationGetReportType Income = new("INCOME");

    public static CraCheckReportVerificationGetReportType FromValue(string value) => FromValueCore(value);
}
