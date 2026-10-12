using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A value from a MISMO prescribed list that specifies the type of loan identifier.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoanIdentifierType>))]
public sealed record LoanIdentifierType : OpenStringEnum<LoanIdentifierType>
{
    private LoanIdentifierType(string value) : base(value)
    {
    }

    public static readonly LoanIdentifierType LenderLoan = new("LenderLoan");

    public static readonly LoanIdentifierType UniversalLoan = new("UniversalLoan");

    public TResult Match<TResult>(Func<TResult> onLenderLoan,
        Func<TResult> onUniversalLoan,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LenderLoan => onLenderLoan(),
            _ when this == UniversalLoan => onUniversalLoan(),
            _ => otherwise(Value)
        };

    public void Match(Action onLenderLoan, Action onUniversalLoan, Action<string> otherwise)
    {
        if (this == LenderLoan) onLenderLoan();
        else if (this == UniversalLoan) onUniversalLoan();
        else otherwise(Value);
    }
}
