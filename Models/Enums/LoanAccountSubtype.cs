using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Valid account subtypes for loan accounts. For a list containing descriptions of each subtype, see <see href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-loan">Account schemas</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoanAccountSubtype>))]
public sealed record LoanAccountSubtype : StringEnum<LoanAccountSubtype>
{
    private LoanAccountSubtype(string value) : base(value)
    {
    }

    public static readonly LoanAccountSubtype Auto = new("auto");

    public static readonly LoanAccountSubtype Business = new("business");

    public static readonly LoanAccountSubtype Commercial = new("commercial");

    public static readonly LoanAccountSubtype Construction = new("construction");

    public static readonly LoanAccountSubtype Consumer = new("consumer");

    public static readonly LoanAccountSubtype HomeEquity = new("home equity");

    public static readonly LoanAccountSubtype Loan = new("loan");

    public static readonly LoanAccountSubtype Mortgage = new("mortgage");

    public static readonly LoanAccountSubtype Overdraft = new("overdraft");

    public static readonly LoanAccountSubtype LineOfCredit = new("line of credit");

    public static readonly LoanAccountSubtype Student = new("student");

    public static readonly LoanAccountSubtype Other = new("other");

    public static readonly LoanAccountSubtype All = new("all");

    public static LoanAccountSubtype FromValue(string value) => FromValueCore(value);
}
