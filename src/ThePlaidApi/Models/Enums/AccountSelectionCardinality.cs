using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The application requires that accounts be limited to a specific cardinality.
/// <c>MULTI_SELECT</c>: indicates that the user should be allowed to pick multiple accounts.
/// <c>SINGLE_SELECT</c>: indicates that the user should be allowed to pick only a single account.
/// <c>ALL</c>: indicates that the user must share all of their accounts and should not be given the opportunity to de-select
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountSelectionCardinality>))]
public sealed record AccountSelectionCardinality : OpenStringEnum<AccountSelectionCardinality>
{
    private AccountSelectionCardinality(string value) : base(value)
    {
    }

    public static readonly AccountSelectionCardinality SingleSelect = new("SINGLE_SELECT");

    public static readonly AccountSelectionCardinality MultiSelect = new("MULTI_SELECT");

    public static readonly AccountSelectionCardinality All = new("ALL");

    public TResult Match<TResult>(Func<TResult> onSingleSelect,
        Func<TResult> onMultiSelect,
        Func<TResult> onAll,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SingleSelect => onSingleSelect(),
            _ when this == MultiSelect => onMultiSelect(),
            _ when this == All => onAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onSingleSelect, Action onMultiSelect, Action onAll, Action<string> otherwise)
    {
        if (this == SingleSelect) onSingleSelect();
        else if (this == MultiSelect) onMultiSelect();
        else if (this == All) onAll();
        else otherwise(Value);
    }
}
