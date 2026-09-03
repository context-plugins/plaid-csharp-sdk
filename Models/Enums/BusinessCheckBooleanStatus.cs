using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Tri-state boolean status, where <c>no_data</c> indicates the check could not determine a value.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessCheckBooleanStatus>))]
public sealed record BusinessCheckBooleanStatus : StringEnum<BusinessCheckBooleanStatus>
{
    private BusinessCheckBooleanStatus(string value) : base(value)
    {
    }

    public static readonly BusinessCheckBooleanStatus Yes = new("yes");

    public static readonly BusinessCheckBooleanStatus No = new("no");

    public static readonly BusinessCheckBooleanStatus NoData = new("no_data");

    public static BusinessCheckBooleanStatus FromValue(string value) => FromValueCore(value);
}
