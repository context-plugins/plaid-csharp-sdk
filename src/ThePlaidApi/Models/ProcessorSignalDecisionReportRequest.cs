using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// ProcessorSignalDecisionReportRequest defines the request schema for <c>/processor/signal/decision/report</c>
/// </summary>
public record ProcessorSignalDecisionReportRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c>
    /// </summary>
    [JsonPropertyName("processor_token")]
    public required string ProcessorToken { get; init; }

    /// <summary>
    /// Must be the same as the <c>client_transaction_id</c> supplied when calling <c>/processor/signal/evaluate</c>
    /// </summary>
    [JsonPropertyName("client_transaction_id")]
    [StringLength(36, MinimumLength = 1)]
    public required string ClientTransactionId { get; init; }

    /// <summary>
    /// <c>true</c> if the ACH transaction was initiated, <c>false</c> otherwise.
    /// <para>
    /// This field must be returned as a boolean. If formatted incorrectly, this will result in an <see href="https://plaid.com/docs/errors/invalid-request/#invalid_field"><c>INVALID_FIELD</c></see> error.
    /// </para>
    /// </summary>
    [JsonPropertyName("initiated")]
    public required bool Initiated { get; init; }

    /// <summary>
    /// The actual number of days (hold time) since the ACH debit transaction that you wait before making funds available to your customers. The holding time could affect the ACH return rate.
    /// <para>
    /// For example, use 0 if you make funds available to your customers instantly or the same day following the debit transaction, or 1 if you make funds available the next day following the debit initialization.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_funds_on_hold")]
    [Minimum(0)]
    public int? DaysFundsOnHold { get; init; }

    /// <summary>
    /// The payment decision from the risk assessment.
    /// <para>
    /// <c>APPROVE</c>: approve the transaction without requiring further actions from your customers. For example, use this field if you are placing a standard hold for all the approved transactions before making funds available to your customers. You should also use this field if you decide to accelerate the fund availability for your customers.
    /// </para>
    /// <para>
    /// <c>REVIEW</c>: the transaction requires manual review
    /// </para>
    /// <para>
    /// <c>REJECT</c>: reject the transaction
    /// </para>
    /// <para>
    /// <c>TAKE_OTHER_RISK_MEASURES</c>: for example, placing a longer hold on funds than those approved transactions or introducing customer frictions such as step-up verification/authentication
    /// </para>
    /// <para>
    /// <c>NOT_EVALUATED</c>: if only logging the results without using them
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decision_outcome")]
    public SignalDecisionOutcome? DecisionOutcome { get; init; }

    /// <summary>
    /// The payment method to complete the transaction after the risk assessment. It may be different from the default payment method.
    /// <para>
    /// <c>SAME_DAY_ACH</c>: Same Day ACH by Nacha. The debit transaction is processed and settled on the same day.
    /// </para>
    /// <para>
    /// <c>STANDARD_ACH</c>: Standard ACH by Nacha.
    /// </para>
    /// <para>
    /// <c>MULTIPLE_PAYMENT_METHODS</c>: if there is no default debit rail or there are multiple payment methods.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_method")]
    public SignalPaymentMethod? PaymentMethod { get; init; }

    /// <summary>
    /// The amount (in USD) made available to your customers instantly following the debit transaction. It could be a partial amount of the requested transaction (example: 102.05).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount_instantly_available")]
    public double? AmountInstantlyAvailable { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
