using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Risk indicators focus on providing signal on the possibility of a borrower defaulting on their loan repayments by providing data points related to its payment behavior, debt, and other relevant financial information, helping lenders gauge the level of risk involved in a certain operation.
/// </summary>
public record RiskIndicators
{
    /// <summary>
    /// Insights into bank penalties and fees, including overdraft fees, NSF fees, and other bank-imposed charges.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_penalties")]
    public BankPenaltiesIndicators? BankPenalties { get; init; }

    /// <summary>
    /// Insights into gambling-related transactions, including frequency, amounts, and top merchants.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gambling")]
    public GamblingIndicators? Gambling { get; init; }

    /// <summary>
    /// Insights into loan disbursement transactions received by the user, tracking incoming funds from loan providers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loan_disbursements")]
    public LoanDisbursementsIndicators? LoanDisbursements { get; init; }

    /// <summary>
    /// Insights into loan payment transactions made by the user, tracking outgoing payments to loan providers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loan_payments")]
    public LoanPaymentsIndicators? LoanPayments { get; init; }

    /// <summary>
    /// Insights into negative balance occurrences, including frequency, duration, and minimum balance details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("negative_balance")]
    public NegativeBalanceInsights? NegativeBalance { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
