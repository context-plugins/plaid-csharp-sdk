using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Status of the Bank Income Link session.
/// <para>
/// <c>APPROVED</c>: User has approved and verified their income
/// </para>
/// <para>
/// <c>NO_DEPOSITS_FOUND</c>: We attempted, but were unable to find any income in the connected account.
/// </para>
/// <para>
/// <c>USER_REPORTED_NO_INCOME</c>: The user explicitly indicated that they don't receive income in the connected account.
/// </para>
/// <para>
/// <c>STARTED</c>: The user began the bank income portion of the link flow.
/// </para>
/// <para>
/// <c>INTERNAL_ERROR</c>: The user encountered an internal error.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditSessionBankIncomeStatus>))]
public sealed record CreditSessionBankIncomeStatus : StringEnum<CreditSessionBankIncomeStatus>
{
    private CreditSessionBankIncomeStatus(string value) : base(value)
    {
    }

    public static readonly CreditSessionBankIncomeStatus Approved = new("APPROVED");

    public static readonly CreditSessionBankIncomeStatus NoDepositsFound = new("NO_DEPOSITS_FOUND");

    public static readonly CreditSessionBankIncomeStatus UserReportedNoIncome = new("USER_REPORTED_NO_INCOME");

    public static readonly CreditSessionBankIncomeStatus Started = new("STARTED");

    public static readonly CreditSessionBankIncomeStatus InternalError = new("INTERNAL_ERROR");

    public static CreditSessionBankIncomeStatus FromValue(string value) => FromValueCore(value);
}
