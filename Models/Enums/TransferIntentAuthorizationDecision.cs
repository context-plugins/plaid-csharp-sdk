using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A decision regarding the proposed transfer.
/// <para>
/// <c>APPROVED</c> - The proposed transfer has received the end user's consent and has been approved for processing by Plaid. The <c>decision_rationale</c> field is set if Plaid was unable to fetch the account information. You may proceed with the transfer, but further review is recommended (i.e., use Link in update mode to re-authenticate your user when <c>decision_rationale.code</c> is <c>ITEM_LOGIN_REQUIRED</c>). Refer to the <c>code</c> field in the <c>decision_rationale</c> object for details.
/// </para>
/// <para>
/// <c>DECLINED</c> - Plaid reviewed the proposed transfer and declined processing. Refer to the <c>code</c> field in the <c>decision_rationale</c> object for details.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferIntentAuthorizationDecision>))]
public sealed record TransferIntentAuthorizationDecision : StringEnum<TransferIntentAuthorizationDecision>
{
    private TransferIntentAuthorizationDecision(string value) : base(value)
    {
    }

    public static readonly TransferIntentAuthorizationDecision Approved = new("APPROVED");

    public static readonly TransferIntentAuthorizationDecision Declined = new("DECLINED");

    public static TransferIntentAuthorizationDecision FromValue(string value) => FromValueCore(value);
}
