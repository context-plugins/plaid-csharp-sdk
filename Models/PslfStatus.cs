using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the student's eligibility in the Public Service Loan Forgiveness program. This is only returned if the institution is FedLoan (<c>ins_116527</c>). Since FedLoan no longer services student loans, this field is no longer returned.
/// </summary>
public record PslfStatus
{
    /// <summary>
    /// The estimated date borrower will have completed 120 qualifying monthly payments. Returned in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("estimated_eligibility_date")]
    public required DateTimeOffset? EstimatedEligibilityDate { get; init; }

    /// <summary>
    /// The number of qualifying payments that have been made.
    /// </summary>
    [JsonPropertyName("payments_made")]
    public required int? PaymentsMade { get; init; }

    /// <summary>
    /// The number of qualifying payments remaining.
    /// </summary>
    [JsonPropertyName("payments_remaining")]
    public required int? PaymentsRemaining { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
