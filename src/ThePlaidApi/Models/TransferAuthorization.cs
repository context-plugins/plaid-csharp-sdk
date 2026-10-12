using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains the authorization decision for a proposed transfer.
/// </summary>
public record TransferAuthorization
{
    /// <summary>
    /// Plaid's unique identifier for a transfer authorization.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The datetime representing when the authorization was created, in the format <c>2006-01-02T15:04:05Z</c>.
    /// </summary>
    [JsonPropertyName("created")]
    public required DateTimeOffset Created { get; init; }

    /// <summary>
    /// A decision regarding the proposed transfer.
    /// <para>
    /// <c>approved</c> - The proposed transfer has received the end user's consent and has been approved for processing by Plaid. The <c>decision_rationale</c> field is set if Plaid was unable to fetch the account information. You may proceed with the transfer, but further review is recommended. Refer to the <c>code</c> field in the <c>decision_rationale</c> object for details.
    /// </para>
    /// <para>
    /// <c>declined</c> - Plaid reviewed the proposed transfer and declined processing. Refer to the <c>code</c> field in the <c>decision_rationale</c> object for details.
    /// </para>
    /// <para>
    /// <c>user_action_required</c> - An action is required before Plaid can assess the transfer risk and make a decision. The most common scenario is to update authentication for an Item. To complete the required action, initialize Link by setting <c>transfer.authorization_id</c> in the request of <c>/link/token/create</c>. After Link flow is completed, you may re-attempt the authorization request.
    /// </para>
    /// <para>
    /// For <c>guarantee</c> requests, <c>approved</c> indicates the transfer is eligible for Plaid's guarantee, and <c>declined</c> indicates Plaid will not provide guarantee coverage for the transfer. <c>user_action_required</c> indicates you should follow the above guidance before re-attempting.
    /// </para>
    /// </summary>
    [JsonPropertyName("decision")]
    public required TransferAuthorizationDecision Decision { get; init; }

    /// <summary>
    /// The rationale for Plaid's decision regarding a proposed transfer. It is always set for <c>declined</c> decisions, and may or may not be null for <c>approved</c> decisions.
    /// </summary>
    [JsonPropertyName("decision_rationale")]
    public required TransferAuthorizationDecisionRationale? DecisionRationale { get; init; }

    [JsonPropertyName("guarantee_decision")]
    public required TransferAuthorizationGuaranteeDecision? GuaranteeDecision { get; init; }

    /// <summary>
    /// The rationale for Plaid's decision to not guarantee a transfer. Will be <c>null</c> unless <c>guarantee_decision</c> is <c>NOT_GUARANTEED</c>.
    /// </summary>
    [JsonPropertyName("guarantee_decision_rationale")]
    public required TransferAuthorizationGuaranteeDecisionRationale? GuaranteeDecisionRationale { get; init; }

    /// <summary>
    /// Adaptive guarantee details for a transfer authorization, including the guarantee outcome and settlement schedule. Omitted when no guarantee was attempted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("guarantee_details")]
    public AuthorizationGuaranteeDetails? GuaranteeDetails { get; init; }

    /// <summary>
    /// This object includes the scores and risk level. This response is offered as an add-on to <c>/transfer/authorization/create</c>. To request access to these fields, please contact your Plaid account manager.
    /// </summary>
    [JsonPropertyName("payment_risk")]
    public required TransferAuthorizationPaymentRisk? PaymentRisk { get; init; }

    /// <summary>
    /// Details regarding the proposed transfer.
    /// </summary>
    [JsonPropertyName("proposed_transfer")]
    public required TransferAuthorizationProposedTransfer ProposedTransfer { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
