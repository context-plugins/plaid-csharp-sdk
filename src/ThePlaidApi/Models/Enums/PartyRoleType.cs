using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A value from a MISMO defined list that identifies the role that the party plays in the transaction. Parties may be either a person or legal entity. A party may play multiple roles in a transaction.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartyRoleType>))]
public sealed record PartyRoleType : OpenStringEnum<PartyRoleType>
{
    private PartyRoleType(string value) : base(value)
    {
    }

    public static readonly PartyRoleType Borrower = new("Borrower");

    public TResult Match<TResult>(Func<TResult> onBorrower, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Borrower => onBorrower(),
            _ => otherwise(Value)
        };

    public void Match(Action onBorrower, Action<string> otherwise)
    {
        if (this == Borrower) onBorrower();
        else otherwise(Value);
    }
}
