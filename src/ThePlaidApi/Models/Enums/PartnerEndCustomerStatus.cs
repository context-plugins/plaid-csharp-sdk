using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the given end customer.
/// <para>
/// <c>UNDER_REVIEW</c>: The end customer has been created and enabled in the Sandbox environment. The end customer must be manually reviewed by the Plaid team before it can be enabled in Production, at which point its status will automatically transition to <c>PENDING_ENABLEMENT</c> or <c>DENIED</c>.
/// </para>
/// <para>
/// <c>PENDING_ENABLEMENT</c>: The end customer is ready to be fully enabled in the Production environment. Call the <c>/partner/customer/enable</c> endpoint to enable the end customer in full Production.
/// </para>
/// <para>
/// <c>ACTIVE</c>: The end customer has been fully enabled in all environments.
/// </para>
/// <para>
/// <c>DENIED</c>: The end customer has been created and enabled in the Sandbox environment, but it did not pass review by the Plaid team and therefore cannot be enabled for Production access. Talk to your account manager for more information.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerStatus>))]
public sealed record PartnerEndCustomerStatus : OpenStringEnum<PartnerEndCustomerStatus>
{
    private PartnerEndCustomerStatus(string value) : base(value)
    {
    }

    public static readonly PartnerEndCustomerStatus UnderReview = new("UNDER_REVIEW");

    public static readonly PartnerEndCustomerStatus PendingEnablement = new("PENDING_ENABLEMENT");

    public static readonly PartnerEndCustomerStatus Active = new("ACTIVE");

    public static readonly PartnerEndCustomerStatus Denied = new("DENIED");

    public static readonly PartnerEndCustomerStatus MoreInformationNeeded = new("MORE_INFORMATION_NEEDED");

    public TResult Match<TResult>(Func<TResult> onUnderReview,
        Func<TResult> onPendingEnablement,
        Func<TResult> onActive,
        Func<TResult> onDenied,
        Func<TResult> onMoreInformationNeeded,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UnderReview => onUnderReview(),
            _ when this == PendingEnablement => onPendingEnablement(),
            _ when this == Active => onActive(),
            _ when this == Denied => onDenied(),
            _ when this == MoreInformationNeeded => onMoreInformationNeeded(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnderReview,
        Action onPendingEnablement,
        Action onActive,
        Action onDenied,
        Action onMoreInformationNeeded,
        Action<string> otherwise)
    {
        if (this == UnderReview) onUnderReview();
        else if (this == PendingEnablement) onPendingEnablement();
        else if (this == Active) onActive();
        else if (this == Denied) onDenied();
        else if (this == MoreInformationNeeded) onMoreInformationNeeded();
        else otherwise(Value);
    }
}
