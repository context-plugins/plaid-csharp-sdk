using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The details of an Item add in Link.
/// </summary>
public record LinkSessionItemAddResult
{
    /// <summary>
    /// Returned once a user has successfully linked their Item.
    /// </summary>
    [JsonPropertyName("public_token")]
    public required string PublicToken { get; init; }

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
