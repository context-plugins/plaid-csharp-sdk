using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// AuthGetResponse defines the response schema for <c>/auth/get</c>
/// </summary>
public record AuthGetResponse
{
    /// <summary>
    /// The <c>accounts</c> for which numbers are being retrieved.
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<Account> Accounts { get; init; }

    /// <summary>
    /// An object containing identifying numbers used for making electronic transfers to and from the <c>accounts</c>. The identifying number type (ACH, EFT, IBAN, or Bacs) used will depend on the country of the account. An account may have more than one number type. If a particular identifying number type is not used by any <c>accounts</c> for which data has been requested, the array for that type will be empty.
    /// </summary>
    [JsonPropertyName("numbers")]
    public required AuthGetNumbers Numbers { get; init; }

    /// <summary>
    /// Metadata about the Item.
    /// </summary>
    [JsonPropertyName("item")]
    public required Item Item { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
