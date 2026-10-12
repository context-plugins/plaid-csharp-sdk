using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorAuthGetResponse defines the response schema for <c>/processor/auth/get</c>
/// </summary>
public record ProcessorAuthGetResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// An object containing identifying numbers used for making electronic transfers to and from the <c>account</c>. The identifying number type (ACH, EFT, IBAN, or Bacs) used will depend on the country of the account. An account may have more than one number type. If a particular identifying number type is not used by the <c>account</c> for which auth data has been requested, a null value will be returned.
    /// </summary>
    [JsonPropertyName("numbers")]
    public required ProcessorNumber Numbers { get; init; }

    /// <summary>
    /// A single account at a financial institution.
    /// </summary>
    [JsonPropertyName("account")]
    public required Account Account { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
