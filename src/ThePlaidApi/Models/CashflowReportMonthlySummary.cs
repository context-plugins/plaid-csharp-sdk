using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Monthly summary statistics derived from transaction-level data.
/// </summary>
public record CashflowReportMonthlySummary
{
    /// <summary>
    /// The start date of the period covered in this monthly summary.
    /// <para>
    /// This date will be the first day of the month, unless the month being covered is a partial month because it is the first month included in the summary and the date range being requested does not begin with the first day of the month.
    /// </para>
    /// <para>
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </para>
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// The end date of the period included in this monthly summary.
    /// <para>
    /// This date will be the last day of the month, unless the month being covered is a partial month because it is the last month included in the summary and the date range being requested does not end with the last day of the month.
    /// </para>
    /// <para>
    /// The date will be returned in an ISO 8601 format (YYYY-MM-DD).
    /// </para>
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset EndDate { get; init; }

    /// <summary>
    /// The starting balance of the month. This will be the same as the ending balance of the previous month. This field will not be available for the first monthly summary.
    /// </summary>
    [JsonPropertyName("starting_balance")]
    public required CashflowReportMonthlySummaryStartingBalance? StartingBalance { get; init; }

    /// <summary>
    /// The ending balance of the month. This will be the same as the starting balance of the next month. This field will not be available for the last monthly summary.
    /// </summary>
    [JsonPropertyName("ending_balance")]
    public required CashflowReportMonthlySummaryEndingBalance? EndingBalance { get; init; }

    /// <summary>
    /// Calendar-day average of the ending balance.
    /// </summary>
    [JsonPropertyName("average_daily_ending_balance")]
    public required CashflowReportMonthlySummaryAverageDailyEndingBalance AverageDailyEndingBalance { get; init; }

    /// <summary>
    /// The average daily sum of inflow transactions, calculated over the month. Always represented as a positive monetary amount.
    /// </summary>
    [JsonPropertyName("average_daily_inflow_amount")]
    public required CashflowReportMonthlySummaryAverageDailyInflowAmount AverageDailyInflowAmount { get; init; }

    /// <summary>
    /// The average daily sum of outflow transactions, calculated over the month. Always represented as a positive monetary amount.
    /// </summary>
    [JsonPropertyName("average_daily_outflow_amount")]
    public required CashflowReportMonthlySummaryAverageDailyOutflowAmount AverageDailyOutflowAmount { get; init; }

    /// <summary>
    /// The average daily net cash flow amount, calculated as total daily inflows less total daily outflows.
    /// </summary>
    [JsonPropertyName("average_daily_net_cashflow_amount")]
    public required CashflowReportMonthlySummaryAverageDailyNetCashflowAmount AverageDailyNetCashflowAmount { get; init; }

    /// <summary>
    /// The average count of the number of daily inflow transactions. Rounded to 2 decimal places.
    /// </summary>
    [JsonPropertyName("average_daily_inflow_transaction_count")]
    public required double AverageDailyInflowTransactionCount { get; init; }

    /// <summary>
    /// The average count of the number of daily outflow transactions. Rounded to 2 decimal places.
    /// </summary>
    [JsonPropertyName("average_daily_outflow_transaction_count")]
    public required double AverageDailyOutflowTransactionCount { get; init; }

    /// <summary>
    /// The total amount of all revenue transactions during this month.
    /// </summary>
    [JsonPropertyName("total_revenue")]
    public required CashflowReportMonthlySummaryTotalRevenue TotalRevenue { get; init; }

    /// <summary>
    /// The total amount of all loan payment transactions during this month.
    /// </summary>
    [JsonPropertyName("total_loan_payment")]
    public required CashflowReportMonthlySummaryTotalLoanPayment TotalLoanPayment { get; init; }

    /// <summary>
    /// The total amount of all variable expense transactions during this month.
    /// </summary>
    [JsonPropertyName("total_variable_expense")]
    public required CashflowReportMonthlySummaryTotalVariableExpense TotalVariableExpense { get; init; }

    /// <summary>
    /// The total amount of all payroll transactions during this month.
    /// </summary>
    [JsonPropertyName("total_payroll")]
    public required CashflowReportMonthlySummaryTotalPayroll TotalPayroll { get; init; }

    /// <summary>
    /// The total number of all NSF transactions during this month.
    /// </summary>
    [JsonPropertyName("nsf_transaction_count")]
    public required int NsfTransactionCount { get; init; }

    /// <summary>
    /// The total number of all overdraft transactions during this month.
    /// </summary>
    [JsonPropertyName("overdraft_transaction_count")]
    public required int OverdraftTransactionCount { get; init; }

    /// <summary>
    /// The number of days with a negative daily average ending balance. The daily average is calculated across all valid accounts. Values will be in the range [0, 31].
    /// </summary>
    [JsonPropertyName("negative_ending_balance_day_count")]
    public required int NegativeEndingBalanceDayCount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
