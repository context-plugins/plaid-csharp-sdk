using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The income category for a specified income source
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UserStatedIncomeSourceCategory>))]
public sealed record UserStatedIncomeSourceCategory : StringEnum<UserStatedIncomeSourceCategory>
{
    private UserStatedIncomeSourceCategory(string value) : base(value)
    {
    }

    public static readonly UserStatedIncomeSourceCategory Other = new("OTHER");

    public static readonly UserStatedIncomeSourceCategory Salary = new("SALARY");

    public static readonly UserStatedIncomeSourceCategory Unemployment = new("UNEMPLOYMENT");

    public static readonly UserStatedIncomeSourceCategory Cash = new("CASH");

    public static readonly UserStatedIncomeSourceCategory GigEconomy = new("GIG_ECONOMY");

    public static readonly UserStatedIncomeSourceCategory Rental = new("RENTAL");

    public static readonly UserStatedIncomeSourceCategory ChildSupport = new("CHILD_SUPPORT");

    public static readonly UserStatedIncomeSourceCategory Military = new("MILITARY");

    public static readonly UserStatedIncomeSourceCategory Retirement = new("RETIREMENT");

    public static readonly UserStatedIncomeSourceCategory LongTermDisability = new("LONG_TERM_DISABILITY");

    public static readonly UserStatedIncomeSourceCategory BankInterest = new("BANK_INTEREST");

    public static UserStatedIncomeSourceCategory FromValue(string value) => FromValueCore(value);
}
