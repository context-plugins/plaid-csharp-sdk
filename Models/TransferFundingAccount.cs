using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The originator's funding account, linked with Plaid Link or <c>/transfer/migrate_account</c>.
/// </summary>
public record TransferFundingAccount
{
    /// <summary>
    /// The access token associated with the Item for which data is being requested.
    /// </summary>
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

    /// <summary>
    /// The Plaid <c>account_id</c> for the newly created Item.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
