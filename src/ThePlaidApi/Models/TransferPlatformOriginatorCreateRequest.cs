using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the request schema for <c>/transfer/platform/originator/create</c>
/// </summary>
public record TransferPlatformOriginatorCreateRequest
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
    /// The client ID of the originator
    /// </summary>
    [JsonPropertyName("originator_client_id")]
    public required string OriginatorClientId { get; init; }

    /// <summary>
    /// Metadata related to the acceptance of Terms of Service
    /// </summary>
    [JsonPropertyName("tos_acceptance_metadata")]
    public required TosAcceptanceMetadata TosAcceptanceMetadata { get; init; }

    /// <summary>
    /// ISO8601 timestamp indicating the most recent time the platform collected onboarding data from the originator
    /// </summary>
    [JsonPropertyName("originator_reviewed_at")]
    public required DateTimeOffset OriginatorReviewedAt { get; init; }

    /// <summary>
    /// The webhook URL to which a <c>PLATFORM_ONBOARDING_UPDATE</c> webhook should be sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook")]
    public string? Webhook { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
