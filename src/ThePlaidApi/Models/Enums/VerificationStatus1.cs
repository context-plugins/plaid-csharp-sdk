using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The verification status to set the account to.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationStatus1>))]
public sealed record VerificationStatus1 : OpenStringEnum<VerificationStatus1>
{
    private VerificationStatus1(string value) : base(value)
    {
    }

    public static readonly VerificationStatus1 AutomaticallyVerified = new("automatically_verified");

    public static readonly VerificationStatus1 VerificationExpired = new("verification_expired");

    public TResult Match<TResult>(Func<TResult> onAutomaticallyVerified,
        Func<TResult> onVerificationExpired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AutomaticallyVerified => onAutomaticallyVerified(),
            _ when this == VerificationExpired => onVerificationExpired(),
            _ => otherwise(Value)
        };

    public void Match(Action onAutomaticallyVerified, Action onVerificationExpired, Action<string> otherwise)
    {
        if (this == AutomaticallyVerified) onAutomaticallyVerified();
        else if (this == VerificationExpired) onVerificationExpired();
        else otherwise(Value);
    }
}
