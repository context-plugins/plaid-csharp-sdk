using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of the credit profile report to retrieve.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraCreditProfileReportVersion>))]
public sealed record CraCreditProfileReportVersion : StringEnum<CraCreditProfileReportVersion>
{
    private CraCreditProfileReportVersion(string value) : base(value)
    {
    }

    public static readonly CraCreditProfileReportVersion V1 = new("v1");

    public static CraCreditProfileReportVersion FromValue(string value) => FromValueCore(value);
}
