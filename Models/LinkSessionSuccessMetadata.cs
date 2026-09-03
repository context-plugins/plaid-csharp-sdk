using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Displayed once a user has successfully linked their Item.
/// </summary>
public record LinkSessionSuccessMetadata
{
    /// <summary>
    /// An institution object. If the Item was created via Same-Day or Instant micro-deposit verification, will be <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution")]
    public LinkSessionSuccessMetadataInstitution? Institution { get; init; }

    /// <summary>
    /// A list of accounts attached to the connected Item. If Account Select is enabled via the developer dashboard, <c>accounts</c> will only include selected accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accounts")]
    public IReadOnlyList<LinkSessionSuccessMetadataAccount>? Accounts { get; init; }

    /// <summary>
    /// A unique identifier associated with a user's actions and events through the Link flow. Include this identifier when opening a support ticket for faster turnaround.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link_session_id")]
    public string? LinkSessionId { get; init; }

    /// <summary>
    /// The status of a transfer. Returned only when <see href="https://plaid.com/docs/transfer/using-transfer-ui">Transfer UI</see> is implemented.
    /// <list type="bullet">
    ///   <item><description><c>COMPLETE</c> - The transfer was completed.</description></item>
    ///   <item><description><c>INCOMPLETE</c> - The transfer could not be completed. For help, see <see href="https://plaid.com/docs/transfer/using-transfer-ui/#troubleshooting-transfer-ui">Troubleshooting transfers</see>.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer_status")]
    public LinkSessionSuccessMetadataTransferStatus? TransferStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
