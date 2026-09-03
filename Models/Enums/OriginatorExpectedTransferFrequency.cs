using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The originator's expected transfer frequency.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OriginatorExpectedTransferFrequency>))]
public sealed record OriginatorExpectedTransferFrequency : StringEnum<OriginatorExpectedTransferFrequency>
{
    private OriginatorExpectedTransferFrequency(string value) : base(value)
    {
    }

    public static readonly OriginatorExpectedTransferFrequency OncePerMonth = new("once_per_month");

    public static readonly OriginatorExpectedTransferFrequency TwicePerMonth = new("twice_per_month");

    public static readonly OriginatorExpectedTransferFrequency OncePerWeek = new("once_per_week");

    public static readonly OriginatorExpectedTransferFrequency Daily = new("daily");

    public static OriginatorExpectedTransferFrequency FromValue(string value) => FromValueCore(value);
}
