using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information specific to wire transfers.
/// </summary>
public record TransferWireDetails
{
    /// <summary>
    /// Additional information from the wire originator to the beneficiary. Max 140 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message_to_beneficiary")]
    public string? MessageToBeneficiary { get; init; }

    /// <summary>
    /// The fee amount deducted from the original transfer during a wire return, if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wire_return_fee")]
    public string? WireReturnFee { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
