using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// A statement's metadata associated with an account
/// </summary>
public record StatementsStatement
{
    /// <summary>
    /// Plaid's unique identifier for the statement.
    /// </summary>
    [JsonPropertyName("statement_id")]
    public required string StatementId { get; init; }

    /// <summary>
    /// Date when the statement was posted by the FI, if known
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_posted")]
    public DateTimeOffset? DatePosted { get; init; }

    /// <summary>
    /// Month of the year. Possible values: 1 through 12 (January through December).
    /// </summary>
    [JsonPropertyName("month")]
    public required int Month { get; init; }

    /// <summary>
    /// The year of the statement, e.g. 2024.
    /// </summary>
    [JsonPropertyName("year")]
    [Minimum(2010)]
    public required int Year { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
