using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The pay frequency of a specified income source
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UserStatedIncomeSourceFrequency>))]
public sealed record UserStatedIncomeSourceFrequency : StringEnum<UserStatedIncomeSourceFrequency>
{
    private UserStatedIncomeSourceFrequency(string value) : base(value)
    {
    }

    public static readonly UserStatedIncomeSourceFrequency Unknown = new("UNKNOWN");

    public static readonly UserStatedIncomeSourceFrequency Weekly = new("WEEKLY");

    public static readonly UserStatedIncomeSourceFrequency Biweekly = new("BIWEEKLY");

    public static readonly UserStatedIncomeSourceFrequency SemiMonthly = new("SEMI_MONTHLY");

    public static readonly UserStatedIncomeSourceFrequency Monthly = new("MONTHLY");

    public static UserStatedIncomeSourceFrequency FromValue(string value) => FromValueCore(value);
}
