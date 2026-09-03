using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The rationale for Plaid's decision regarding a proposed transfer. It is always set for <c>declined</c> decisions, and may or may not be null for <c>approved</c> decisions.
/// </summary>
public record TransferAuthorizationDecisionRationale
{
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
    [JsonPropertyName("code")]
    public required TransferAuthorizationDecisionRationaleCode? Code { get; init; }

    /// <summary>
    /// A human-readable description of the code associated with a transfer approval or transfer decline.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
