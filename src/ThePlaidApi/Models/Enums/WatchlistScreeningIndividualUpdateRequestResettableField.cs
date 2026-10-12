using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The name of a field that can be reset back to null
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WatchlistScreeningIndividualUpdateRequestResettableField>))]
public sealed record WatchlistScreeningIndividualUpdateRequestResettableField : OpenStringEnum<WatchlistScreeningIndividualUpdateRequestResettableField>
{
    private WatchlistScreeningIndividualUpdateRequestResettableField(string value) : base(value)
    {
    }

    public static readonly WatchlistScreeningIndividualUpdateRequestResettableField Assignee = new("assignee");

    public TResult Match<TResult>(Func<TResult> onAssignee, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Assignee => onAssignee(),
            _ => otherwise(Value)
        };

    public void Match(Action onAssignee, Action<string> otherwise)
    {
        if (this == Assignee) onAssignee();
        else otherwise(Value);
    }
}
