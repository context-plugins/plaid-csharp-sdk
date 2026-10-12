using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Plaid and FDX-defined recipient metadata fields
/// </summary>
public record ExtendedRecipientMetadata
{
    /// <summary>
    /// The recipient identifier
    /// </summary>
    [JsonPropertyName("recipient_id")]
    [MaxLength(256)]
    public required string RecipientId { get; init; }

    /// <summary>
    /// The recipient name displayed by the Data Provider during the consent flow
    /// </summary>
    [JsonPropertyName("client_name")]
    [MaxLength(256)]
    public required string ClientName { get; init; }

    /// <summary>
    /// Data Recipient Logo URL location
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo_uri")]
    public string? LogoUri { get; init; }

    /// <summary>
    /// The legal name of the recipient
    /// </summary>
    [JsonPropertyName("third_party_legal_name")]
    [MaxLength(256)]
    public required string ThirdPartyLegalName { get; init; }

    /// <summary>
    /// The category that the recipient falls under
    /// </summary>
    [JsonPropertyName("category")]
    public required string Category { get; init; }

    /// <summary>
    /// The date at which the recipient gained production access to Plaid
    /// </summary>
    [JsonPropertyName("joined_date")]
    public required DateTimeOffset JoinedDate { get; init; }

    /// <summary>
    /// The number of consumers connected to the recipient through this Data Partner
    /// </summary>
    [JsonPropertyName("connection_count")]
    public required int ConnectionCount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
