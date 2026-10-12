using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the given Payment Profile.
/// <para>
/// <c>READY</c>: This Payment Profile is ready to be used to create transfers using <c>/transfer/authorization/create</c> and <c>/transfer/create</c>.
/// </para>
/// <para>
/// <c>PENDING</c>: This Payment Profile is not ready to be used. You'll need to call <c>/link/token/create</c> and provide the <c>payment_profile_token</c> in the <c>transfer.payment_profile_token</c> field to initiate the account linking experience.
/// </para>
/// <para>
/// <c>REMOVED</c>: This Payment Profile has been removed.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentProfileStatus>))]
public sealed record PaymentProfileStatus : OpenStringEnum<PaymentProfileStatus>
{
    private PaymentProfileStatus(string value) : base(value)
    {
    }

    public static readonly PaymentProfileStatus Pending = new("PENDING");

    public static readonly PaymentProfileStatus Ready = new("READY");

    public static readonly PaymentProfileStatus Removed = new("REMOVED");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onReady,
        Func<TResult> onRemoved,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Ready => onReady(),
            _ when this == Removed => onRemoved(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onReady, Action onRemoved, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Ready) onReady();
        else if (this == Removed) onRemoved();
        else otherwise(Value);
    }
}
