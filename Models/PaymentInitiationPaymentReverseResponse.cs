using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// PaymentInitiationPaymentReverseResponse defines the response schema for <c>/payment_initiation/payment/reverse</c>
/// </summary>
public record PaymentInitiationPaymentReverseResponse
{
    /// <summary>
    /// A unique ID identifying the refund
    /// </summary>
    [JsonPropertyName("refund_id")]
    public required string RefundId { get; init; }

    /// <summary>
    /// The status of the transaction.
    /// <para>
    /// <c>AUTHORISING</c>: The transaction is being processed for validation and compliance.
    /// </para>
    /// <para>
    /// <c>INITIATED</c>: The transaction has been initiated and is currently being processed.
    /// </para>
    /// <para>
    /// <c>EXECUTED</c>: The transaction has been successfully executed and is considered complete. This is only applicable for debit transactions.
    /// </para>
    /// <para>
    /// <c>SETTLED</c>: The transaction has settled and funds are available for use. This is only applicable for credit transactions. A transaction will typically settle within seconds to several days, depending on which payment rail is used.
    /// </para>
    /// <para>
    /// <c>FAILED</c>: The transaction failed to process successfully. This is a terminal status.
    /// </para>
    /// <para>
    /// <c>BLOCKED</c>: The transaction has been blocked for violating compliance rules. This is a terminal status.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required WalletTransactionStatus Status { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
