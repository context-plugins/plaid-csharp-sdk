using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Configuration parameters for the Investments Move product
/// </summary>
public record LinkTokenInvestmentsAuth
{
    /// <summary>
    /// If <c>true</c>, show institutions that use the manual entry fallback flow.
    /// </summary>
    [JsonPropertyName("manual_entry_enabled")]
    public bool? ManualEntryEnabled { get; init; } = false;

    /// <summary>
    /// If <c>true</c>, show institutions that use the masked number match fallback flow.
    /// </summary>
    [JsonPropertyName("masked_number_match_enabled")]
    public bool? MaskedNumberMatchEnabled { get; init; } = false;

    /// <summary>
    /// If <c>true</c>, show institutions that use the stated account number fallback flow.
    /// </summary>
    [JsonPropertyName("stated_account_number_enabled")]
    public bool? StatedAccountNumberEnabled { get; init; } = false;

    /// <summary>
    /// If <c>true</c>, the fee and contribution details for 401k accounts will be returned.
    /// </summary>
    [JsonPropertyName("rollover_401k_enabled")]
    public bool? Rollover401KEnabled { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
