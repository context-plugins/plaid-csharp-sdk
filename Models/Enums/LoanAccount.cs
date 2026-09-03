using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A loan type account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoanAccount>))]
public sealed record LoanAccount : StringEnum<LoanAccount>
{
    private LoanAccount(string value) : base(value)
    {
    }

    public static readonly LoanAccount Auto = new("auto");

    public static readonly LoanAccount Business = new("business");

    public static readonly LoanAccount Commercial = new("commercial");

    public static readonly LoanAccount Construction = new("construction");

    public static readonly LoanAccount Consumer = new("consumer");

    public static readonly LoanAccount HomeEquity = new("home equity");

    public static readonly LoanAccount LineOfCredit = new("line of credit");

    public static readonly LoanAccount Loan = new("loan");

    public static readonly LoanAccount Mortgage = new("mortgage");

    public static readonly LoanAccount Other = new("other");

    public static readonly LoanAccount Overdraft = new("overdraft");

    public static readonly LoanAccount Student = new("student");

    public static LoanAccount FromValue(string value) => FromValueCore(value);
}
