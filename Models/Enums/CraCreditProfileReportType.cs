using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The product type for the credit profile report request.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraCreditProfileReportType>))]
public sealed record CraCreditProfileReportType : StringEnum<CraCreditProfileReportType>
{
    private CraCreditProfileReportType(string value) : base(value)
    {
    }

    public static readonly CraCreditProfileReportType Qualify = new("QUALIFY");

    public static CraCreditProfileReportType FromValue(string value) => FromValueCore(value);
}
