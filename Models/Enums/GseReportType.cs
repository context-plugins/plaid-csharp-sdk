using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The types of GSE Reports supported by the Plaid API
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GseReportType>))]
public sealed record GseReportType : StringEnum<GseReportType>
{
    private GseReportType(string value) : base(value)
    {
    }

    public static readonly GseReportType Voa = new("VOA");

    public static readonly GseReportType EmploymentRefresh = new("EMPLOYMENT_REFRESH");

    public static GseReportType FromValue(string value) => FromValueCore(value);
}
