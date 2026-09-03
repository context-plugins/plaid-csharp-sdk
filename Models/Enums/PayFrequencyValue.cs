using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The frequency of the pay period.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayFrequencyValue>))]
public sealed record PayFrequencyValue : StringEnum<PayFrequencyValue>
{
    private PayFrequencyValue(string value) : base(value)
    {
    }

    public static readonly PayFrequencyValue Monthly = new("monthly");

    public static readonly PayFrequencyValue Semimonthly = new("semimonthly");

    public static readonly PayFrequencyValue Weekly = new("weekly");

    public static readonly PayFrequencyValue Biweekly = new("biweekly");

    public static readonly PayFrequencyValue Unknown = new("unknown");

    public static PayFrequencyValue FromValue(string value) => FromValueCore(value);
}
