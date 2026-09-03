using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Fired when Plaid is unable to originate a new ACH transaction of the recurring transfer on the planned date.
/// </summary>
public record RecurringTransferSkippedWebhook
{
    /// <summary>
    /// <c>TRANSFER</c>
    /// </summary>
    [JsonPropertyName("webhook_type")]
    public required string WebhookType { get; init; }

    /// <summary>
    /// <c>RECURRING_TRANSFER_SKIPPED</c>
    /// </summary>
    [JsonPropertyName("webhook_code")]
    public required string WebhookCode { get; init; }

    /// <summary>
    /// Plaid's unique identifier for a recurring transfer.
    /// </summary>
    [JsonPropertyName("recurring_transfer_id")]
    public required string RecurringTransferId { get; init; }

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
    [JsonPropertyName("authorization_decision")]
    public required TransferAuthorizationDecision AuthorizationDecision { get; init; }

    /// <summary>
    /// A code representing the rationale for approving or declining the proposed transfer.
    /// <para>
    /// If the <c>rationale_code</c> is <c>null</c>, the transfer passed the authorization check.
    /// </para>
    /// <para>
    /// Any non-<c>null</c> value for an <c>approved</c> transfer indicates that the authorization check could not be run and that you should perform your own risk assessment on the transfer. The code will indicate why the check could not be run. Possible values for an <c>approved</c> transfer are:
    /// </para>
    /// <para>
    /// <c>MANUALLY_VERIFIED_ITEM</c> - Item created via a manual entry flow (i.e. Same-Day Micro-deposit, Instant Micro-deposit, or database-based verification), limited information available.
    /// </para>
    /// <para>
    /// <c>ITEM_LOGIN_REQUIRED</c> - Unable to collect the account information due to Item staleness. Can be resolved by using Link and setting <see href="https://plaid.com/docs/api/link/#link-token-create-request-transfer-authorization-id"><c>transfer.authorization_id</c></see> in the request to <c>/link/token/create</c>.
    /// </para>
    /// <para>
    /// <c>PAYMENT_PROFILE_LOGIN_REQUIRED</c> - The Payment Profile associated with the call to <c>/transfer/authorization/create</c> is in a state that requires the end user to re-authenticate. Can be resolved by using Link to refresh the Payment Profile.
    /// </para>
    /// <para>
    /// <c>MIGRATED_ACCOUNT_ITEM</c> - Item created via <c>/transfer/migrate_account</c> endpoint, limited information available.
    /// </para>
    /// <para>
    /// <c>ERROR</c> - Unable to collect the account information due to an unspecified error.
    /// </para>
    /// <para>
    /// The following codes indicate that the authorization decision was <c>declined</c>:
    /// </para>
    /// <para>
    /// <c>NSF</c> - Transaction has an elevated probability of resulting in a return due to insufficient funds.
    /// </para>
    /// <para>
    /// <c>RISK</c> - Transaction is high-risk.
    /// </para>
    /// <para>
    /// <c>TRANSFER_LIMIT_REACHED</c> - One or several transfer limits are reached, e.g. monthly transfer limit. Check the accompanying <c>description</c> field to understand which limit has been reached.
    /// </para>
    /// <para>
    /// <c>ADMIN</c> - Transaction has an elevated probability of resulting in an administrative return (for example a closed, invalid, or unauthorized account).
    /// </para>
    /// <para>
    /// <c>FRAUD</c> - Transaction has an elevated probability of being fraudulent.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorization_decision_rationale_code")]
    public TransferAuthorizationDecisionRationaleCode? AuthorizationDecisionRationaleCode { get; init; }

    /// <summary>
    /// The planned date on which Plaid is unable to originate a new ACH transaction of the recurring transfer. This will be of the form YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("skipped_origination_date")]
    public required DateTimeOffset SkippedOriginationDate { get; init; }

    /// <summary>
    /// The Plaid environment the webhook was sent from
    /// </summary>
    [JsonPropertyName("environment")]
    public required WebhookEnvironmentValues Environment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
