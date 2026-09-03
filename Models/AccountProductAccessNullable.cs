using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Allow the application to access specific products on this account
/// </summary>
public record AccountProductAccessNullable
{
    /// <summary>
    /// Allow the application to access account data. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.
    /// </summary>
    [JsonPropertyName("account_data")]
    public bool? AccountData { get; init; } = true;

    /// <summary>
    /// Allow the application to access bank statements. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.
    /// </summary>
    [JsonPropertyName("statements")]
    public bool? Statements { get; init; } = true;

    /// <summary>
    /// Allow the application to access tax documents. Only used by certain partners. If relevant to the partner and unset, defaults to <c>true</c>.
    /// </summary>
    [JsonPropertyName("tax_documents")]
    public bool? TaxDocuments { get; init; } = true;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
