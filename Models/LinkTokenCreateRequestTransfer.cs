using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Transfer product.
/// </summary>
public record LinkTokenCreateRequestTransfer
{
    /// <summary>
    /// The <c>id</c> returned by the <c>/transfer/intent/create</c> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("intent_id")]
    public string? IntentId { get; init; }

    /// <summary>
    /// The <c>id</c> returned by the <c>/transfer/authorization/create</c> endpoint. Used to indicate Link session to complete required user action in order to make a decision for the authorization. If set, <c>access_token</c> can be omitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorization_id")]
    public string? AuthorizationId { get; init; }

    /// <summary>
    /// The <c>payment_profile_token</c> returned by the <c>/payment_profile/create</c> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_profile_token")]
    public string? PaymentProfileToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
