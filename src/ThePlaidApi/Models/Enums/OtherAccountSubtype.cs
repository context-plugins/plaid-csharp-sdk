using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Valid account subtypes for other accounts. For a list containing descriptions of each subtype, see <see href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-other">Account schemas</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OtherAccountSubtype>))]
public sealed record OtherAccountSubtype : OpenStringEnum<OtherAccountSubtype>
{
    private OtherAccountSubtype(string value) : base(value)
    {
    }

    public static readonly OtherAccountSubtype Other = new("other");

    public static readonly OtherAccountSubtype All = new("all");

    public TResult Match<TResult>(Func<TResult> onOther, Func<TResult> onAll, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Other => onOther(),
            _ when this == All => onAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onOther, Action onAll, Action<string> otherwise)
    {
        if (this == Other) onOther();
        else if (this == All) onAll();
        else otherwise(Value);
    }
}
