using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the loan exposure subcategory of the report
/// </summary>
public record MonitoringLoanInsights
{
    /// <summary>
    /// Details regarding the number of loan payments
    /// </summary>
    [JsonPropertyName("loan_payments_counts")]
    public required LoanPaymentsCounts LoanPaymentsCounts { get; init; }

    /// <summary>
    /// The number of loan disbursements detected in the last 30 days
    /// </summary>
    [JsonPropertyName("loan_disbursements_count")]
    public required double LoanDisbursementsCount { get; init; }

    /// <summary>
    /// Details regarding the number of unique loan payment merchants
    /// </summary>
    [JsonPropertyName("loan_payment_merchants_counts")]
    public required LoanPaymentsMerchantCounts LoanPaymentMerchantsCounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
