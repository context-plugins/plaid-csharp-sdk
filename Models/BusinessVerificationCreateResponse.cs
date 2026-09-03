using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A business verification represents a check of a business's identity and risk profile, including information collected about the business and results from third-party data providers.
/// </summary>
public record BusinessVerificationCreateResponse
{
    /// <summary>
    /// ID of the associated business verification.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// A unique ID that identifies the end user in your system. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonPropertyName("client_user_id")]
    public required string ClientUserId { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("completed_at")]
    public required DateTimeOffset? CompletedAt { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("redacted_at")]
    public required DateTimeOffset? RedactedAt { get; init; }

    /// <summary>
    /// Status of the overall business verification
    /// </summary>
    [JsonPropertyName("status")]
    public required BusinessVerificationStatusOverall Status { get; init; }

    /// <summary>
    /// The business information that was used to perform the verification search
    /// </summary>
    [JsonPropertyName("search_terms")]
    public required BusinessSearchTerms SearchTerms { get; init; }

    /// <summary>
    /// Results from the KYB (Know Your Business) identity verification check
    /// </summary>
    [JsonPropertyName("kyb_check")]
    public required BusinessKybCheck? KybCheck { get; init; }

    /// <summary>
    /// Results from the business risk assessment check
    /// </summary>
    [JsonPropertyName("risk_check")]
    public required BusinessRiskCheck? RiskCheck { get; init; }

    /// <summary>
    /// Results from the digital presence check.
    /// </summary>
    [JsonPropertyName("digital_presence_check")]
    public required BusinessDigitalPresenceCheck? DigitalPresenceCheck { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// A shareable URL that can be sent directly to the user to complete verification
    /// </summary>
    [JsonPropertyName("shareable_url")]
    public required string? ShareableUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
