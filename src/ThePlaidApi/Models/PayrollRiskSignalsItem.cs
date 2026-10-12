using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Object containing fraud risk data pertaining to the Item linked as part of the verification.
/// </summary>
public record PayrollRiskSignalsItem
{
    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// Array of payroll income document authenticity data retrieved for each of the user's accounts.
    /// </summary>
    [JsonPropertyName("verification_risk_signals")]
    public required IReadOnlyList<DocumentRiskSignalsObject> VerificationRiskSignals { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
