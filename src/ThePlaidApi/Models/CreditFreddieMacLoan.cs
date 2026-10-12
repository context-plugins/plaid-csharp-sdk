using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information specific to a mortgage loan agreement between one or more borrowers and a mortgage lender.
/// </summary>
public record CreditFreddieMacLoan
{
    /// <summary>
    /// Collection of current and previous identifiers for this loan.
    /// </summary>
    [JsonPropertyName("LOAN_IDENTIFIERS")]
    public required CreditFreddieMacLoanIdentifiers LoanIdentifiers { get; init; }

    /// <summary>
    /// Type of loan. The value can only be "SubjectLoan".
    /// </summary>
    [JsonPropertyName("LoanRoleType")]
    public required string LoanRoleType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
