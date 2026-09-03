using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The account number and sort code of the counterparty's account
/// </summary>
public record WalletTransactionCounterpartyBacs
{
    /// <summary>
    /// The account number of the account. Maximum of 10 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    [StringLength(10, MinimumLength = 1)]
    public string? Account { get; init; }

    /// <summary>
    /// The 6-character sort code of the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_code")]
    [StringLength(6, MinimumLength = 6)]
    public string? SortCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
