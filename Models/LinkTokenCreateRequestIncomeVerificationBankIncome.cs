using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with Bank Income. This field is required if <c>income_verification</c> is included in the <c>products</c> array and <c>bank</c> is specified in <c>income_source_types</c>.
/// </summary>
public record LinkTokenCreateRequestIncomeVerificationBankIncome
{
    /// <summary>
    /// The number of days of data to request for the Bank Income product
    /// </summary>
    [JsonPropertyName("days_requested")]
    [Minimum(1)]
    [Maximum(731)]
    public required int DaysRequested { get; init; }

    /// <summary>
    /// Whether to enable multiple Items to be added in the Link session. This setting is deprecated and has been replaced by the more general <c>enable_multi_item_link</c> setting, which supports all products.
    /// </summary>
    [JsonPropertyName("enable_multiple_items")]
    public bool? EnableMultipleItems { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
