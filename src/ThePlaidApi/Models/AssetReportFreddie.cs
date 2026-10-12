using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing an Asset Report with Freddie Mac schema.
/// </summary>
public record AssetReportFreddie
{
    /// <summary>
    /// A collection of loans that are part of a single deal.
    /// </summary>
    [JsonPropertyName("LOANS")]
    public required Loans Loans { get; init; }

    /// <summary>
    /// A collection of objects that define specific parties to a deal. This includes the direct participating parties, such as borrower and seller and the indirect parties such as the credit report provider.
    /// </summary>
    [JsonPropertyName("PARTIES")]
    public required Parties Parties { get; init; }

    /// <summary>
    /// A collection of objects that describe requests and responses for services.
    /// </summary>
    [JsonPropertyName("SERVICES")]
    public required Services Services { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
