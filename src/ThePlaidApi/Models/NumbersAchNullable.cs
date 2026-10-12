using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Identifying information for transferring money to or from a US account via ACH or wire transfer.
/// </summary>
public record NumbersAchNullable
{
    /// <summary>
    /// The Plaid account ID associated with the account numbers
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The ACH account number for the account.
    /// <para>
    /// At certain institutions, including Chase, PNC, and US Bank, you will receive a "tokenized" account number, which is not the user's actual account number. For important details on how this may impact your integration and on how to avoid fraud, user confusion, and ACH returns, see <see href="https://plaid.com/docs/auth/#tokenized-account-numbers">Tokenized account numbers</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("account")]
    public required string Account { get; init; }

    /// <summary>
    /// Indicates whether the account number is tokenized by the institution. For important details on how tokenized account numbers may impact your integration, see <see href="https://plaid.com/docs/auth/#tokenized-account-numbers">Tokenized account numbers</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_tokenized_account_number")]
    public bool? IsTokenizedAccountNumber { get; init; }

    /// <summary>
    /// The ACH routing number for the account. For more information, see <see href="https://plaid.com/docs/auth/#tokenized-account-numbers">Tokenized account numbers</see>.
    /// </summary>
    [JsonPropertyName("routing")]
    public required string Routing { get; init; }

    /// <summary>
    /// The wire transfer routing number for the account. This field is only populated if the institution is known to use a separate wire transfer routing number. Many institutions do not have a separate wire routing number and use the ACH routing number for wires instead. It is recommended to have the end user manually confirm their wire routing number before sending any wires to their account, especially if this field is <c>null</c>.
    /// </summary>
    [JsonPropertyName("wire_routing")]
    public required string? WireRouting { get; init; }

    /// <summary>
    /// Whether the account supports ACH transfers into the account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_transfer_in")]
    public bool? CanTransferIn { get; init; }

    /// <summary>
    /// Whether the account supports ACH transfers out of the account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_transfer_out")]
    public bool? CanTransferOut { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
