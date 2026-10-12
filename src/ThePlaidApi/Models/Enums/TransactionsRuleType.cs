using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Transaction rule's match type. For <c>TRANSACTION_ID</c> field, <c>EXACT_MATCH</c> is available.
/// Matches are case sensitive.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionsRuleType>))]
public sealed record TransactionsRuleType : OpenStringEnum<TransactionsRuleType>
{
    private TransactionsRuleType(string value) : base(value)
    {
    }

    public static readonly TransactionsRuleType ExactMatch = new("EXACT_MATCH");

    public static readonly TransactionsRuleType SubstringMatch = new("SUBSTRING_MATCH");

    public TResult Match<TResult>(Func<TResult> onExactMatch,
        Func<TResult> onSubstringMatch,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ExactMatch => onExactMatch(),
            _ when this == SubstringMatch => onSubstringMatch(),
            _ => otherwise(Value)
        };

    public void Match(Action onExactMatch, Action onSubstringMatch, Action<string> otherwise)
    {
        if (this == ExactMatch) onExactMatch();
        else if (this == SubstringMatch) onSubstringMatch();
        else otherwise(Value);
    }
}
