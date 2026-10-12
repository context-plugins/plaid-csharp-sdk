using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/migrate_account</c>
/// </summary>
public record TransferMigrateAccountRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The user's account number.
    /// </summary>
    [JsonPropertyName("account_number")]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The user's routing number.
    /// </summary>
    [JsonPropertyName("routing_number")]
    public required string RoutingNumber { get; init; }

    /// <summary>
    /// The user's wire transfer routing number. This is the ABA number; for some institutions, this may differ from the ACH number used in <c>routing_number</c>. This field must be set for the created item to be eligible for wire transfers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wire_routing_number")]
    public string? WireRoutingNumber { get; init; }

    /// <summary>
    /// The type of the bank account (<c>checking</c> or <c>savings</c>).
    /// </summary>
    [JsonPropertyName("account_type")]
    public required string AccountType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
