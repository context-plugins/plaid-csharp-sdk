using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of the repayment plan.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : StringEnum<Type3>
{
    private Type3(string value) : base(value)
    {
    }

    public static readonly Type3 ExtendedGraduated = new("extended graduated");

    public static readonly Type3 ExtendedStandard = new("extended standard");

    public static readonly Type3 Graduated = new("graduated");

    public static readonly Type3 IncomeContingentRepayment = new("income-contingent repayment");

    public static readonly Type3 IncomeBasedRepayment = new("income-based repayment");

    public static readonly Type3 IncomeSensitiveRepayment = new("income-sensitive repayment");

    public static readonly Type3 InterestOnly = new("interest only");

    public static readonly Type3 Other = new("other");

    public static readonly Type3 PayAsYouEarn = new("pay as you earn");

    public static readonly Type3 RevisedPayAsYouEarn = new("revised pay as you earn");

    public static readonly Type3 Standard = new("standard");

    public static readonly Type3 SavingOnAValuableEducation = new("saving on a valuable education");

    public static Type3 FromValue(string value) => FromValueCore(value);
}
