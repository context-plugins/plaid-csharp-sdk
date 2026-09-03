using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// (Deprecated) Specifies options for initializing Link for use with the Deposit Switch (beta) product. This field is required if <c>deposit_switch</c> is included in the <c>products</c> array.
/// </summary>
public record LinkTokenCreateRequestDepositSwitch
{
    /// <summary>
    /// The <c>deposit_switch_id</c> provided by the <c>/deposit_switch/create</c> endpoint.
    /// </summary>
    [JsonPropertyName("deposit_switch_id")]
    public required string DepositSwitchId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
