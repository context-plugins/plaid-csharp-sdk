using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The report type. It can be <c>asset</c>. Income report types are not yet supported.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReportType>))]
public sealed record ReportType : StringEnum<ReportType>
{
    private ReportType(string value) : base(value)
    {
    }

    public static readonly ReportType Asset = new("asset");

    public static ReportType FromValue(string value) => FromValueCore(value);
}
