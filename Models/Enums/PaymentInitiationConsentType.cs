using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Payment consent type. Defines possible use case for payments made with the given consent.
/// <para>
/// <c>SWEEPING</c>: Allows moving money between accounts owned by the same user.
/// </para>
/// <para>
/// <c>COMMERCIAL</c>: Allows initiating payments from the user's account to third parties.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentInitiationConsentType>))]
public sealed record PaymentInitiationConsentType : StringEnum<PaymentInitiationConsentType>
{
    private PaymentInitiationConsentType(string value) : base(value)
    {
    }

    public static readonly PaymentInitiationConsentType Sweeping = new("SWEEPING");

    public static readonly PaymentInitiationConsentType Commercial = new("COMMERCIAL");

    public static PaymentInitiationConsentType FromValue(string value) => FromValueCore(value);
}
