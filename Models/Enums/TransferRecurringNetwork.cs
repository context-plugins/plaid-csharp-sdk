using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Networks eligible for recurring transfers.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferRecurringNetwork>))]
public sealed record TransferRecurringNetwork : StringEnum<TransferRecurringNetwork>
{
    private TransferRecurringNetwork(string value) : base(value)
    {
    }

    public static readonly TransferRecurringNetwork Ach = new("ach");

    public static readonly TransferRecurringNetwork SameDayAch = new("same-day-ach");

    public static readonly TransferRecurringNetwork Rtp = new("rtp");

    public static TransferRecurringNetwork FromValue(string value) => FromValueCore(value);
}
