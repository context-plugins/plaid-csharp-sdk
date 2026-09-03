using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The types of source employment data that users should be able to share
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EmploymentSourceType>))]
public sealed record EmploymentSourceType : StringEnum<EmploymentSourceType>
{
    private EmploymentSourceType(string value) : base(value)
    {
    }

    public static readonly EmploymentSourceType Bank = new("bank");

    public static readonly EmploymentSourceType Payroll = new("payroll");

    public static EmploymentSourceType FromValue(string value) => FromValueCore(value);
}
