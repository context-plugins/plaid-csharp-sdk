using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of data being disputed by the consumer
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConsumerReportCategory>))]
public sealed record ConsumerReportCategory : StringEnum<ConsumerReportCategory>
{
    private ConsumerReportCategory(string value) : base(value)
    {
    }

    public static readonly ConsumerReportCategory Transaction = new("TRANSACTION");

    public static readonly ConsumerReportCategory Balance = new("BALANCE");

    public static readonly ConsumerReportCategory Identity = new("IDENTITY");

    public static readonly ConsumerReportCategory Other = new("OTHER");

    public static ConsumerReportCategory FromValue(string value) => FromValueCore(value);
}
