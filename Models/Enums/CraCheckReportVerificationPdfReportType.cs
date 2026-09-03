using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of verification PDF report to fetch.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraCheckReportVerificationPdfReportType>))]
public sealed record CraCheckReportVerificationPdfReportType : StringEnum<CraCheckReportVerificationPdfReportType>
{
    private CraCheckReportVerificationPdfReportType(string value) : base(value)
    {
    }

    public static readonly CraCheckReportVerificationPdfReportType Voa = new("voa");

    public static readonly CraCheckReportVerificationPdfReportType EmploymentRefresh = new("employment_refresh");

    public static readonly CraCheckReportVerificationPdfReportType Income = new("income");

    public static CraCheckReportVerificationPdfReportType FromValue(string value) => FromValueCore(value);
}
