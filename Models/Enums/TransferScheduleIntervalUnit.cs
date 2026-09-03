using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The unit of the recurring interval.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferScheduleIntervalUnit>))]
public sealed record TransferScheduleIntervalUnit : StringEnum<TransferScheduleIntervalUnit>
{
    private TransferScheduleIntervalUnit(string value) : base(value)
    {
    }

    public static readonly TransferScheduleIntervalUnit Week = new("week");

    public static readonly TransferScheduleIntervalUnit Month = new("month");

    public static TransferScheduleIntervalUnit FromValue(string value) => FromValueCore(value);
}
