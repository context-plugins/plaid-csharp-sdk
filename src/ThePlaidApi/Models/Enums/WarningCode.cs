using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The warning code identifies a specific kind of warning. <c>OWNERS_UNAVAILABLE</c> indicates that account-owner information is not available. <c>INVESTMENTS_UNAVAILABLE</c> indicates that Investments specific information is not available. <c>TRANSACTIONS_UNAVAILABLE</c> indicates that transactions information associated with Credit and Depository accounts are unavailable. The <c>BANK_INCOME_INSIGHTS_*</c> codes apply to the Bank Income add-on: <c>BANK_INCOME_INSIGHTS_INSUFFICIENT_DATA</c> indicates there was not enough data to compute Bank Income Insights; <c>BANK_INCOME_INSIGHTS_INCOMPLETE</c> indicates the Bank Income Insights flow was not completed; <c>BANK_INCOME_INSIGHTS_STATUS_IN_PROGRESS</c> indicates Bank Income Insights are still being computed; <c>BANK_INCOME_INSIGHTS_INTERNAL_ERROR</c> indicates an internal error occurred while computing Bank Income Insights; <c>BANK_INCOME_INSIGHTS_MISMATCHED_DAYS_REQUESTED</c> indicates the days requested for Bank Income Insights did not match that of the Asset Report.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WarningCode>))]
public sealed record WarningCode : OpenStringEnum<WarningCode>
{
    private WarningCode(string value) : base(value)
    {
    }

    public static readonly WarningCode OwnersUnavailable = new("OWNERS_UNAVAILABLE");

    public static readonly WarningCode InvestmentsUnavailable = new("INVESTMENTS_UNAVAILABLE");

    public static readonly WarningCode TransactionsUnavailable = new("TRANSACTIONS_UNAVAILABLE");

    public static readonly WarningCode BankIncomeInsightsInsufficientData = new(
        "BANK_INCOME_INSIGHTS_INSUFFICIENT_DATA");

    public static readonly WarningCode BankIncomeInsightsIncomplete = new("BANK_INCOME_INSIGHTS_INCOMPLETE");

    public static readonly WarningCode BankIncomeInsightsStatusInProgress = new(
        "BANK_INCOME_INSIGHTS_STATUS_IN_PROGRESS");

    public static readonly WarningCode BankIncomeInsightsInternalError = new("BANK_INCOME_INSIGHTS_INTERNAL_ERROR");

    public static readonly WarningCode BankIncomeInsightsMismatchedDaysRequested = new(
        "BANK_INCOME_INSIGHTS_MISMATCHED_DAYS_REQUESTED");

    public TResult Match<TResult>(Func<TResult> onOwnersUnavailable,
        Func<TResult> onInvestmentsUnavailable,
        Func<TResult> onTransactionsUnavailable,
        Func<TResult> onBankIncomeInsightsInsufficientData,
        Func<TResult> onBankIncomeInsightsIncomplete,
        Func<TResult> onBankIncomeInsightsStatusInProgress,
        Func<TResult> onBankIncomeInsightsInternalError,
        Func<TResult> onBankIncomeInsightsMismatchedDaysRequested,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OwnersUnavailable => onOwnersUnavailable(),
            _ when this == InvestmentsUnavailable => onInvestmentsUnavailable(),
            _ when this == TransactionsUnavailable => onTransactionsUnavailable(),
            _ when this == BankIncomeInsightsInsufficientData => onBankIncomeInsightsInsufficientData(),
            _ when this == BankIncomeInsightsIncomplete => onBankIncomeInsightsIncomplete(),
            _ when this == BankIncomeInsightsStatusInProgress => onBankIncomeInsightsStatusInProgress(),
            _ when this == BankIncomeInsightsInternalError => onBankIncomeInsightsInternalError(),
            _ when this == BankIncomeInsightsMismatchedDaysRequested => onBankIncomeInsightsMismatchedDaysRequested(),
            _ => otherwise(Value)
        };

    public void Match(Action onOwnersUnavailable,
        Action onInvestmentsUnavailable,
        Action onTransactionsUnavailable,
        Action onBankIncomeInsightsInsufficientData,
        Action onBankIncomeInsightsIncomplete,
        Action onBankIncomeInsightsStatusInProgress,
        Action onBankIncomeInsightsInternalError,
        Action onBankIncomeInsightsMismatchedDaysRequested,
        Action<string> otherwise)
    {
        if (this == OwnersUnavailable) onOwnersUnavailable();
        else if (this == InvestmentsUnavailable) onInvestmentsUnavailable();
        else if (this == TransactionsUnavailable) onTransactionsUnavailable();
        else if (this == BankIncomeInsightsInsufficientData) onBankIncomeInsightsInsufficientData();
        else if (this == BankIncomeInsightsIncomplete) onBankIncomeInsightsIncomplete();
        else if (this == BankIncomeInsightsStatusInProgress) onBankIncomeInsightsStatusInProgress();
        else if (this == BankIncomeInsightsInternalError) onBankIncomeInsightsInternalError();
        else if (this == BankIncomeInsightsMismatchedDaysRequested) onBankIncomeInsightsMismatchedDaysRequested();
        else otherwise(Value);
    }
}
