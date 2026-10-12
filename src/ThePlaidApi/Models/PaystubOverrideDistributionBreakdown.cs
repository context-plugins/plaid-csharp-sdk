using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the accounts that the payment was distributed to.
/// </summary>
public record PaystubOverrideDistributionBreakdown
{
    /// <summary>
    /// Name of the account for the given distribution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_name")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The name of the bank that the payment is being deposited to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_name")]
    public string? BankName { get; init; }

    /// <summary>
    /// The amount distributed to this account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current_amount")]
    public double? CurrentAmount { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the net pay. Always <c>null</c> if <c>unofficial_currency_code</c> is non-null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>
    /// The last 2-4 alphanumeric characters of an account's official account number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mask")]
    public string? Mask { get; init; }

    /// <summary>
    /// Type of the account that the paystub was sent to (e.g. 'checking').
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
