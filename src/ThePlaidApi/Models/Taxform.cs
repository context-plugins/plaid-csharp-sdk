using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Data about an official document used to report the user's income to the IRS.
/// </summary>
public record Taxform
{
    /// <summary>
    /// An identifier of the document referenced by the document metadata.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("doc_id")]
    public string? DocId { get; init; }

    /// <summary>
    /// The type of tax document. Currently, the only supported value is <c>w2</c>.
    /// </summary>
    [JsonPropertyName("document_type")]
    public required string DocumentType { get; init; }

    /// <summary>
    /// W2 is an object that represents income data taken from a W2 tax document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("w2")]
    public W2? W2 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
