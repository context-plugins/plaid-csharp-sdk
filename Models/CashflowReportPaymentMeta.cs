using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Transaction information specific to inter-bank transfers. If the transaction was not an inter-bank transfer, all fields will be <c>null</c>.
/// </summary>
public record CashflowReportPaymentMeta
{
    /// <summary>
    /// The transaction reference number supplied by the financial institution.
    /// </summary>
    [JsonPropertyName("reference_number")]
    public required string? ReferenceNumber { get; init; }

    /// <summary>
    /// The ACH PPD ID for the payer.
    /// </summary>
    [JsonPropertyName("ppd_id")]
    public required string? PpdId { get; init; }

    /// <summary>
    /// For transfers, the party that is receiving the transaction.
    /// </summary>
    [JsonPropertyName("payee")]
    public required string? Payee { get; init; }

    /// <summary>
    /// The party initiating a wire transfer. Will be <c>null</c> if the transaction is not a wire transfer.
    /// </summary>
    [JsonPropertyName("by_order_of")]
    public required string? ByOrderOf { get; init; }

    /// <summary>
    /// For transfers, the party that is paying the transaction.
    /// </summary>
    [JsonPropertyName("payer")]
    public required string? Payer { get; init; }

    /// <summary>
    /// The type of transfer, e.g. 'ACH'
    /// </summary>
    [JsonPropertyName("payment_method")]
    public required string? PaymentMethod { get; init; }

    /// <summary>
    /// The name of the payment processor
    /// </summary>
    [JsonPropertyName("payment_processor")]
    public required string? PaymentProcessor { get; init; }

    /// <summary>
    /// The payer-supplied description of the transfer.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string? Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
