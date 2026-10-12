using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Defines the response schema for <c>/transfer/recurring/create</c>
/// </summary>
public record TransferRecurringCreateResponse
{
    /// <summary>
    /// Represents a recurring transfer within the Transfers API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring_transfer")]
    public RecurringTransferNullable? RecurringTransfer { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decision_rationale")]
    public TransferAuthorizationDecisionRationale? DecisionRationale { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
