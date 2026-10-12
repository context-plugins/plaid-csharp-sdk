using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Codes describing the object of a consent event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConsentEventCode>))]
public sealed record ConsentEventCode : OpenStringEnum<ConsentEventCode>
{
    private ConsentEventCode(string value) : base(value)
    {
    }

    public static readonly ConsentEventCode UserAgreement = new("USER_AGREEMENT");

    public static readonly ConsentEventCode UseCases = new("USE_CASES");

    public static readonly ConsentEventCode DataScopes = new("DATA_SCOPES");

    public static readonly ConsentEventCode AccountScopes = new("ACCOUNT_SCOPES");

    public static readonly ConsentEventCode Revocation = new("REVOCATION");

    public TResult Match<TResult>(Func<TResult> onUserAgreement,
        Func<TResult> onUseCases,
        Func<TResult> onDataScopes,
        Func<TResult> onAccountScopes,
        Func<TResult> onRevocation,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UserAgreement => onUserAgreement(),
            _ when this == UseCases => onUseCases(),
            _ when this == DataScopes => onDataScopes(),
            _ when this == AccountScopes => onAccountScopes(),
            _ when this == Revocation => onRevocation(),
            _ => otherwise(Value)
        };

    public void Match(Action onUserAgreement,
        Action onUseCases,
        Action onDataScopes,
        Action onAccountScopes,
        Action onRevocation,
        Action<string> otherwise)
    {
        if (this == UserAgreement) onUserAgreement();
        else if (this == UseCases) onUseCases();
        else if (this == DataScopes) onDataScopes();
        else if (this == AccountScopes) onAccountScopes();
        else if (this == Revocation) onRevocation();
        else otherwise(Value);
    }
}
