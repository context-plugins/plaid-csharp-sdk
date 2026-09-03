using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An individual LendScore result within a credit profile report.
/// </summary>
public record CraCreditProfileLendScore
{
    /// <summary>
    /// The score returned by the LendScore model. Will be an integer in the range 1 to 99. Higher scores indicate lower credit risk.
    /// </summary>
    [JsonPropertyName("score")]
    public required int? Score { get; init; }

    /// <summary>
    /// The reasons for an individual having risk according to the LendScore. For a full list of possible reason codes and a mapping of reason codes to human-readable reasons, contact your Plaid account manager. Different LendScore versions will use different sets of reason codes.
    /// </summary>
    [JsonPropertyName("reason_codes")]
    public required IReadOnlyList<string> ReasonCodes { get; init; }

    /// <summary>
    /// The variant identifier for this LendScore result.
    /// </summary>
    [JsonPropertyName("variant")]
    public required string Variant { get; init; }

    /// <summary>
    /// Human-readable description of why the LendScore could not be computed.
    /// </summary>
    [JsonPropertyName("error_reason")]
    public required string? ErrorReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
