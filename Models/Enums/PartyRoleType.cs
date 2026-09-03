using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A value from a MISMO defined list that identifies the role that the party plays in the transaction. Parties may be either a person or legal entity. A party may play multiple roles in a transaction.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartyRoleType>))]
public sealed record PartyRoleType : StringEnum<PartyRoleType>
{
    private PartyRoleType(string value) : base(value)
    {
    }

    public static readonly PartyRoleType Borrower = new("Borrower");

    public static PartyRoleType FromValue(string value) => FromValueCore(value);
}
