using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The pay type - <c>GROSS</c>, <c>NET</c>, or <c>UNKNOWN</c> for a specified income source
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UserStatedIncomeSourcePayType>))]
public sealed record UserStatedIncomeSourcePayType : StringEnum<UserStatedIncomeSourcePayType>
{
    private UserStatedIncomeSourcePayType(string value) : base(value)
    {
    }

    public static readonly UserStatedIncomeSourcePayType Unknown = new("UNKNOWN");

    public static readonly UserStatedIncomeSourcePayType Gross = new("GROSS");

    public static readonly UserStatedIncomeSourcePayType Net = new("NET");

    public static UserStatedIncomeSourcePayType FromValue(string value) => FromValueCore(value);
}
