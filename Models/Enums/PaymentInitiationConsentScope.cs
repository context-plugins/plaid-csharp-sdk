using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// This field is deprecated in favor of the consent <c>type</c> field. Consents are required to have a single type.
/// <para>
/// Payment consent scope. Defines possible directions for payments made with the given consent.
/// </para>
/// <para>
/// <c>ME_TO_ME</c>: Allows moving money between accounts owned by the same user.
/// </para>
/// <para>
/// <c>EXTERNAL</c>: Allows initiating payments from the user's account to third parties.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentInitiationConsentScope>))]
public sealed record PaymentInitiationConsentScope : StringEnum<PaymentInitiationConsentScope>
{
    private PaymentInitiationConsentScope(string value) : base(value)
    {
    }

    public static readonly PaymentInitiationConsentScope MeToMe = new("ME_TO_ME");

    public static readonly PaymentInitiationConsentScope External = new("EXTERNAL");

    public static PaymentInitiationConsentScope FromValue(string value) => FromValueCore(value);
}
