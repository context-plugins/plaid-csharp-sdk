using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object used to restrict the accounts used for payments. If provided, the end user will be able to send payments only from the specified bank account.
/// </summary>
public record PaymentInitiationOptionalRestrictionBacs
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
