using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A description of the source of data for a given product/data type.
/// <para>
/// <c>INSTITUTION</c>: The institution supports this product, and the data was provided by the institution.
/// <c>INSTITUTION_MASK</c>: The user manually provided the full account number, which was matched to the account mask provided by the institution. Only applicable to the <c>numbers</c> data type.
/// <c>USER</c>: The institution does not support this product, and the data was manually provided by the user.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DataSources>))]
public sealed record DataSources : OpenStringEnum<DataSources>
{
    private DataSources(string value) : base(value)
    {
    }

    public static readonly DataSources Institution = new("INSTITUTION");

    public static readonly DataSources InstitutionMask = new("INSTITUTION_MASK");

    public static readonly DataSources User = new("USER");

    public TResult Match<TResult>(Func<TResult> onInstitution,
        Func<TResult> onInstitutionMask,
        Func<TResult> onUser,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Institution => onInstitution(),
            _ when this == InstitutionMask => onInstitutionMask(),
            _ when this == User => onUser(),
            _ => otherwise(Value)
        };

    public void Match(Action onInstitution, Action onInstitutionMask, Action onUser, Action<string> otherwise)
    {
        if (this == Institution) onInstitution();
        else if (this == InstitutionMask) onInstitutionMask();
        else if (this == User) onUser();
        else otherwise(Value);
    }
}
