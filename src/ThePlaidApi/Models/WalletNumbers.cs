using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the e-wallet account numbers
/// </summary>
public record WalletNumbers
{
    /// <summary>
    /// An object containing a Bacs account number and sort code. If an IBAN is not provided or if you need to accept domestic GBP-denominated payments, Bacs data is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bacs")]
    public RecipientBacs? Bacs { get; init; }

    /// <summary>
    /// Account numbers using the International Bank Account Number and BIC/SWIFT code format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("international")]
    public NumbersInternationalIban? International { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
