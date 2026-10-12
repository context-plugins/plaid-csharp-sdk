using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The reason for removing the Item
/// <para>
/// <c>FRAUD_FIRST_PARTY</c>: The end user who owns the connected bank account committed fraud
/// <c>FRAUD_FALSE_IDENTITY</c>: The end user created the connection using false identity information or stolen credentials
/// <c>FRAUD_ABUSE</c>: The end user is abusing the client's service or platform through their connected account
/// <c>FRAUD_OTHER</c>: Other fraud-related reasons involving the end user not covered by the specific fraud categories
/// <c>CONNECTION_IS_NON_FUNCTIONAL</c>: The connection to the end user's financial institution is broken and cannot be restored
/// <c>OTHER</c>: Any other reason for removing the connection not covered by the above categories
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ItemRemoveReasonCode>))]
public sealed record ItemRemoveReasonCode : OpenStringEnum<ItemRemoveReasonCode>
{
    private ItemRemoveReasonCode(string value) : base(value)
    {
    }

    public static readonly ItemRemoveReasonCode FraudFirstParty = new("FRAUD_FIRST_PARTY");

    public static readonly ItemRemoveReasonCode FraudFalseIdentity = new("FRAUD_FALSE_IDENTITY");

    public static readonly ItemRemoveReasonCode FraudAbuse = new("FRAUD_ABUSE");

    public static readonly ItemRemoveReasonCode FraudOther = new("FRAUD_OTHER");

    public static readonly ItemRemoveReasonCode ConnectionIsNonFunctional = new("CONNECTION_IS_NON_FUNCTIONAL");

    public static readonly ItemRemoveReasonCode Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onFraudFirstParty,
        Func<TResult> onFraudFalseIdentity,
        Func<TResult> onFraudAbuse,
        Func<TResult> onFraudOther,
        Func<TResult> onConnectionIsNonFunctional,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FraudFirstParty => onFraudFirstParty(),
            _ when this == FraudFalseIdentity => onFraudFalseIdentity(),
            _ when this == FraudAbuse => onFraudAbuse(),
            _ when this == FraudOther => onFraudOther(),
            _ when this == ConnectionIsNonFunctional => onConnectionIsNonFunctional(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onFraudFirstParty,
        Action onFraudFalseIdentity,
        Action onFraudAbuse,
        Action onFraudOther,
        Action onConnectionIsNonFunctional,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == FraudFirstParty) onFraudFirstParty();
        else if (this == FraudFalseIdentity) onFraudFalseIdentity();
        else if (this == FraudAbuse) onFraudAbuse();
        else if (this == FraudOther) onFraudOther();
        else if (this == ConnectionIsNonFunctional) onConnectionIsNonFunctional();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
