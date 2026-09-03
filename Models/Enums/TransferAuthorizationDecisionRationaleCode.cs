using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<TransferAuthorizationDecisionRationaleCode>))]
public sealed record TransferAuthorizationDecisionRationaleCode : StringEnum<TransferAuthorizationDecisionRationaleCode>
{
    private TransferAuthorizationDecisionRationaleCode(string value) : base(value)
    {
    }

    public static readonly TransferAuthorizationDecisionRationaleCode Nsf = new("NSF");

    public static readonly TransferAuthorizationDecisionRationaleCode Risk = new("RISK");

    public static readonly TransferAuthorizationDecisionRationaleCode TransferLimitReached = new("TRANSFER_LIMIT_REACHED");

    public static readonly TransferAuthorizationDecisionRationaleCode ManuallyVerifiedItem = new("MANUALLY_VERIFIED_ITEM");

    public static readonly TransferAuthorizationDecisionRationaleCode ItemLoginRequired = new("ITEM_LOGIN_REQUIRED");

    public static readonly TransferAuthorizationDecisionRationaleCode PaymentProfileLoginRequired = new("PAYMENT_PROFILE_LOGIN_REQUIRED");

    public static readonly TransferAuthorizationDecisionRationaleCode Error = new("ERROR");

    public static readonly TransferAuthorizationDecisionRationaleCode MigratedAccountItem = new("MIGRATED_ACCOUNT_ITEM");

    public static readonly TransferAuthorizationDecisionRationaleCode Admin = new("ADMIN");

    public static readonly TransferAuthorizationDecisionRationaleCode Fraud = new("FRAUD");

    public static TransferAuthorizationDecisionRationaleCode FromValue(string value) => FromValueCore(value);
}
