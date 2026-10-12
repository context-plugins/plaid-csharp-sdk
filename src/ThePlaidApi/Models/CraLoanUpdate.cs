using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains loan data to update.
/// </summary>
public record CraLoanUpdate
{
    /// <summary>
    /// A unique identifier for the loan.
    /// Personally identifiable information, such as an email address or phone number, should not be used in the <c>loan_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loan_id")]
    public string? LoanId { get; init; }

    /// <summary>
    /// A list of status update history of the loan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status_history")]
    public IReadOnlyList<CraLoanStatusHistoryUpdate>? StatusHistory { get; init; }

    /// <summary>
    /// The updates to the payment history for the loan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_history")]
    public IReadOnlyList<CraLoanPaymentHistory>? PaymentHistory { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
