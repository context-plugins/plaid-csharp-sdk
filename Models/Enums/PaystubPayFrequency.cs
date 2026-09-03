using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The frequency at which the employee is paid. Possible values: <c>MONTHLY</c>, <c>BI-WEEKLY</c>, <c>WEEKLY</c>, <c>SEMI-MONTHLY</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaystubPayFrequency>))]
public sealed record PaystubPayFrequency : StringEnum<PaystubPayFrequency>
{
    private PaystubPayFrequency(string value) : base(value)
    {
    }

    public static readonly PaystubPayFrequency Monthly = new("MONTHLY");

    public static readonly PaystubPayFrequency BiWeekly = new("BI-WEEKLY");

    public static readonly PaystubPayFrequency Weekly = new("WEEKLY");

    public static readonly PaystubPayFrequency SemiMonthly = new("SEMI-MONTHLY");

    public static PaystubPayFrequency FromValue(string value) => FromValueCore(value);
}
