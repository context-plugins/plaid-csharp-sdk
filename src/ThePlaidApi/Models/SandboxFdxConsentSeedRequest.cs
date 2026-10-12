using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Request to seed an FDX consent grant, and its backing item, for the given end user and recipient application so the FDX Consent API can be exercised in Sandbox.
/// </summary>
public record SandboxFdxConsentSeedRequest
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
    /// The data provider's identifier for the end user to associate the seeded consent grant with.
    /// </summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>
    /// This field will map to the application ID that is returned from <c>/item/application/list</c>, or provided to the institution in an oauth redirect.
    /// </summary>
    [JsonPropertyName("application_id")]
    public required string ApplicationId { get; init; }

    /// <summary>
    /// Optional UUIDv4 identifier for the seeded consent grant. If omitted, one is generated. Seeding fails if a grant with this identifier already exists.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consent_id")]
    public string? ConsentId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
