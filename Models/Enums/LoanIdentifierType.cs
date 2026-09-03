using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A value from a MISMO prescribed list that specifies the type of loan identifier.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoanIdentifierType>))]
public sealed record LoanIdentifierType : StringEnum<LoanIdentifierType>
{
    private LoanIdentifierType(string value) : base(value)
    {
    }

    public static readonly LoanIdentifierType LenderLoan = new("LenderLoan");

    public static readonly LoanIdentifierType UniversalLoan = new("UniversalLoan");

    public static LoanIdentifierType FromValue(string value) => FromValueCore(value);
}
