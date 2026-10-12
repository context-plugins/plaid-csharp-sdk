using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to configure <c>/item/import</c> request.
/// </summary>
public record ItemImportRequestOptions
{
    /// <summary>
    /// Specifies a webhook URL to associate with an Item. Plaid fires a webhook if credentials fail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook")]
    public string? Webhook { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
