using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing an <see href="https://plaid.com/docs/link/web/#onsuccess">onSuccess</see> callback from Link. This field is returned only for legacy integrations and is deprecated in favor of <see href="https://plaid.com/docs/api/link/#link-token-get-response-link-sessions-results-item-add-results"><c>results.item_add_results</c></see> which can support multiple public tokens in a single Link session, for flows such as multi-Item Link. If you are receiving <c>on_success</c>, contact your account manager to migrate to <c>results.item_add_results</c> instead.
/// </summary>
public record LinkSessionSuccess
{
    /// <summary>
    /// Displayed once a user has successfully linked their Item.
    /// </summary>
    [JsonPropertyName("public_token")]
    public required string PublicToken { get; init; }

    /// <summary>
    /// Displayed once a user has successfully linked their Item.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required LinkSessionSuccessMetadata? Metadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
