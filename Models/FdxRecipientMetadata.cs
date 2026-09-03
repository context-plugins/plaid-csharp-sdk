using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Recipient metadata fields that are defined by FDX.
/// </summary>
public record FdxRecipientMetadata
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
