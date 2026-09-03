using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The details of a Plaid Check Item update via update mode in Link.
/// </summary>
public record LinkSessionCraUpdateResult
{
    /// <summary>
    /// The Plaid Check Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. The <c>item_id</c> is case-sensitive.
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    /// <summary>
    /// A list of accounts attached to the connected Item. If Account Select is enabled via the developer dashboard, <c>accounts</c> will only include selected accounts.
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<LinkSessionSuccessMetadataAccount> Accounts { get; init; }

    /// <summary>
    /// An institution object. If the Item was created via Same-Day or Instant micro-deposit verification, will be <c>null</c>.
    /// </summary>
    [JsonPropertyName("institution")]
    public required LinkSessionSuccessMetadataInstitution? Institution { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
