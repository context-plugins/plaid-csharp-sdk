using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// WalletGetResponse defines the response schema for <c>/wallet/get</c>
/// </summary>
public record WalletGetResponse
{
    /// <summary>
    /// A unique ID identifying the e-wallet
    /// </summary>
    [JsonPropertyName("wallet_id")]
    public required string WalletId { get; init; }

    /// <summary>
    /// An object representing the e-wallet balance
    /// </summary>
    [JsonPropertyName("balance")]
    public required WalletBalance Balance { get; init; }

    /// <summary>
    /// An object representing the e-wallet account numbers
    /// </summary>
    [JsonPropertyName("numbers")]
    public required WalletNumbers Numbers { get; init; }

    /// <summary>
    /// The ID of the recipient that corresponds to the e-wallet account numbers
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recipient_id")]
    public string? RecipientId { get; init; }

    /// <summary>
    /// The status of the wallet.
    /// <para>
    /// <c>UNKNOWN</c>: The wallet status is unknown.
    /// </para>
    /// <para>
    /// <c>ACTIVE</c>: The wallet is active and ready to send money to and receive money from.
    /// </para>
    /// <para>
    /// <c>CLOSED</c>: The wallet is closed. Any transactions made to or from this wallet will error.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required WalletStatus Status { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
