using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies option for initializing Link for use with the Identity Verification product.
/// </summary>
public record LinkTokenCreateRequestIdentityVerification
{
    [JsonPropertyName("template_id")]
    public required string TemplateId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consent")]
    public bool? Consent { get; init; }

    /// <summary>
    /// A flag specifying whether the end user has already agreed to a privacy policy specifying that their data will be shared with Plaid for verification purposes.
    /// <para>
    /// If <c>gave_consent</c> is set to <c>true</c>, the <c>accept_tos</c> step will be marked as <c>skipped</c> and the end user's session will start at the next step requirement.
    /// </para>
    /// </summary>
    [JsonPropertyName("gave_consent")]
    public bool? GaveConsent { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
