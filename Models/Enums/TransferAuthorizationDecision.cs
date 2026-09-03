using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<TransferAuthorizationDecision>))]
public sealed record TransferAuthorizationDecision : StringEnum<TransferAuthorizationDecision>
{
    private TransferAuthorizationDecision(string value) : base(value)
    {
    }

    public static readonly TransferAuthorizationDecision Approved = new("approved");

    public static readonly TransferAuthorizationDecision Declined = new("declined");

    public static readonly TransferAuthorizationDecision UserActionRequired = new("user_action_required");

    public static TransferAuthorizationDecision FromValue(string value) => FromValueCore(value);
}
