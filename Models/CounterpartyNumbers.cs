using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Account numbers associated with the counterparty, when available.
/// This field is currently only filled in for select financial institutions in Europe.
/// </summary>
public record CounterpartyNumbers
{
    /// <summary>
    /// Identifying information for a UK bank account via Bacs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bacs")]
    public CounterpartyNumbersBacs? Bacs { get; init; }

    /// <summary>
    /// Account numbers using the International Bank Account Number and BIC/SWIFT code format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("international")]
    public CounterpartyNumbersInternational? International { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
