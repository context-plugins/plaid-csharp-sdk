using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The warning code identifies a specific kind of warning. <c>OWNERS_UNAVAILABLE</c> indicates that account-owner information is not available. <c>INVESTMENTS_UNAVAILABLE</c> indicates that Investments specific information is not available. <c>TRANSACTIONS_UNAVAILABLE</c> indicates that transactions information associated with Credit and Depository accounts are unavailable. The <c>BANK_INCOME_INSIGHTS_*</c> codes apply to the Bank Income add-on: <c>BANK_INCOME_INSIGHTS_INSUFFICIENT_DATA</c> indicates there was not enough data to compute Bank Income Insights; <c>BANK_INCOME_INSIGHTS_INCOMPLETE</c> indicates the Bank Income Insights flow was not completed; <c>BANK_INCOME_INSIGHTS_STATUS_IN_PROGRESS</c> indicates Bank Income Insights are still being computed; <c>BANK_INCOME_INSIGHTS_INTERNAL_ERROR</c> indicates an internal error occurred while computing Bank Income Insights; <c>BANK_INCOME_INSIGHTS_MISMATCHED_DAYS_REQUESTED</c> indicates the days requested for Bank Income Insights did not match that of the Asset Report.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WarningCode>))]
public sealed record WarningCode : StringEnum<WarningCode>
{
    private WarningCode(string value) : base(value)
    {
    }

    public static readonly WarningCode OwnersUnavailable = new("OWNERS_UNAVAILABLE");

    public static readonly WarningCode InvestmentsUnavailable = new("INVESTMENTS_UNAVAILABLE");

    public static readonly WarningCode TransactionsUnavailable = new("TRANSACTIONS_UNAVAILABLE");

    public static readonly WarningCode BankIncomeInsightsInsufficientData = new("BANK_INCOME_INSIGHTS_INSUFFICIENT_DATA");

    public static readonly WarningCode BankIncomeInsightsIncomplete = new("BANK_INCOME_INSIGHTS_INCOMPLETE");

    public static readonly WarningCode BankIncomeInsightsStatusInProgress = new("BANK_INCOME_INSIGHTS_STATUS_IN_PROGRESS");

    public static readonly WarningCode BankIncomeInsightsInternalError = new("BANK_INCOME_INSIGHTS_INTERNAL_ERROR");

    public static readonly WarningCode BankIncomeInsightsMismatchedDaysRequested = new("BANK_INCOME_INSIGHTS_MISMATCHED_DAYS_REQUESTED");

    public static WarningCode FromValue(string value) => FromValueCore(value);
}
