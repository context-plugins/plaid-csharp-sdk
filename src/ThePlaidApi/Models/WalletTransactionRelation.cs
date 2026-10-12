using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Transactions are related when they have a logical connection.
/// <para>
/// For example, a <c>PAYOUT</c> transaction can be returned by the sender, creating a <c>RETURN</c> transaction. Each <c>PAYOUT</c> transaction can have at most one corresponding <c>RETURN</c> transaction in case of reversal.
/// </para>
/// <para>
/// These relationships are bi-directional, meaning that both entities have references to each other. For instance, when a transaction of type RETURN occurs, it is linked to the original transaction being returned. Likewise, the original transaction has a reference back to the RETURN transaction that represents the return.
/// </para>
/// <para>
/// This field is only populated for transactions of type <c>RETURN</c>, <c>FUNDS_SWEEP</c>, <c>REFUND</c> and <c>PAYOUT</c>.
/// </para>
/// <para>
/// The relationship between a <c>PIS_PAY_IN</c> payment and its corresponding <c>REFUND</c> transactions is only available through the <c>refund_ids</c> property in the payment object. See <see href="https://plaid.com/docs/api/products/payment-initiation/#payment_initiation-payment-get-response-refund-ids"><c>/payment_initiation/payment/get</c></see>.
/// </para>
/// </summary>
public record WalletTransactionRelation
{
    /// <summary>
    /// The ID of the related transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The type of the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type4? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
