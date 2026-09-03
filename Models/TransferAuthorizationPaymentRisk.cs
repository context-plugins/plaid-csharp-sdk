using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// This object includes the scores and risk level. This response is offered as an add-on to <c>/transfer/authorization/create</c>. To request access to these fields, please contact your Plaid account manager.
/// </summary>
public record TransferAuthorizationPaymentRisk
{
    /// <summary>
    /// A score from 1-99 that indicates the transaction return risk: a higher risk score suggests a higher return likelihood.
    /// <para>
    /// The score evaluates the transaction return risk because an account is overdrawn or because an ineligible account is used and covers return codes: "R01", "R02", "R03", "R04", "R06", "R08",  "R09", "R13",
    /// "R16", "R17", "R20", "R23". These returns have a turnaround time of 2 banking days.
    /// </para>
    /// </summary>
    [JsonPropertyName("bank_initiated_return_score")]
    [Minimum(1)]
    [Maximum(99)]
    public required int? BankInitiatedReturnScore { get; init; }

    /// <summary>
    /// A score from 1-99 that indicates the transaction return risk: a higher risk score suggests a higher return likelihood.
    /// <para>
    /// The score evaluates the transaction return risk of an unauthorized debit and covers return codes: "R05", "R07", "R10", "R11", "R29".
    /// These returns typically have a return time frame of up to 60 calendar days. During this period, customers of financial institutions can dispute a transaction as unauthorized.
    /// </para>
    /// </summary>
    [JsonPropertyName("customer_initiated_return_score")]
    [Minimum(1)]
    [Maximum(99)]
    public required int? CustomerInitiatedReturnScore { get; init; }

    /// <summary>
    /// Comprises five risk categories (high risk, medium-high risk, medium risk, medium-low risk, low risk) based on the probability of return
    /// </summary>
    [JsonPropertyName("risk_level")]
    public required TransferAuthorizationRiskLevel? RiskLevel { get; init; }

    /// <summary>
    /// If bank information was not available to be used, this array contains warnings describing why bank data is missing. If you want to receive an API error instead of scores in the case of missing bank data, file a support ticket or contact your Plaid account manager.
    /// </summary>
    [JsonPropertyName("warnings")]
    public required IReadOnlyList<SignalWarning> Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
