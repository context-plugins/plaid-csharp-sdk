using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A collection of information about a single party to a transaction. Includes direct participants like the borrower and seller as well as indirect participants such as the flood certificate provider.
/// </summary>
public record Party
{
    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("INDIVIDUAL")]
    public required Individual Individual { get; init; }

    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("ROLES")]
    public required Roles Roles { get; init; }

    /// <summary>
    /// The collection of <c>TAXPAYER_IDENTIFICATION</c> elements
    /// </summary>
    [JsonPropertyName("TAXPAYER_IDENTIFIERS")]
    public required TaxpayerIdentifiers TaxpayerIdentifiers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
