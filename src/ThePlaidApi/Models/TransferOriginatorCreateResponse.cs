using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/transfer/originator/create</c>
/// </summary>
public record TransferOriginatorCreateResponse
{
    /// <summary>
    /// Client ID of the originator. This identifier will be used when creating transfers and should be stored associated with end user information.
    /// </summary>
    [JsonPropertyName("originator_client_id")]
    public required string OriginatorClientId { get; init; }

    /// <summary>
    /// The company name of the end customer.
    /// </summary>
    [JsonPropertyName("company_name")]
    public required string CompanyName { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
