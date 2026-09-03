using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains loan data for the loan being unregistered.
/// </summary>
public record CraLoanUnregister
{
    /// <summary>
    /// A unique identifier for the loan.
    /// Personally identifiable information, such as an email address or phone number, should not be used in the <c>loan_id</c>.
    /// </summary>
    [JsonPropertyName("loan_id")]
    public required string LoanId { get; init; }

    /// <summary>
    /// Contains the status and date information of the loan when unregistering.
    /// </summary>
    [JsonPropertyName("closed_with_status")]
    public required CraLoanClosedStatus ClosedWithStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
