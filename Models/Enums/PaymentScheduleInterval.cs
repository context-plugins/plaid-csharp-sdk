using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The frequency interval of the payment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentScheduleInterval>))]
public sealed record PaymentScheduleInterval : StringEnum<PaymentScheduleInterval>
{
    private PaymentScheduleInterval(string value) : base(value)
    {
    }

    public static readonly PaymentScheduleInterval Weekly = new("WEEKLY");

    public static readonly PaymentScheduleInterval Monthly = new("MONTHLY");

    public static PaymentScheduleInterval FromValue(string value) => FromValueCore(value);
}
