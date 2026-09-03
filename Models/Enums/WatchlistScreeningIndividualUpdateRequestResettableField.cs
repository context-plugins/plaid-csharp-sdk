using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The name of a field that can be reset back to null
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WatchlistScreeningIndividualUpdateRequestResettableField>))]
public sealed record WatchlistScreeningIndividualUpdateRequestResettableField : StringEnum<WatchlistScreeningIndividualUpdateRequestResettableField>
{
    private WatchlistScreeningIndividualUpdateRequestResettableField(string value) : base(value)
    {
    }

    public static readonly WatchlistScreeningIndividualUpdateRequestResettableField Assignee = new("assignee");

    public static WatchlistScreeningIndividualUpdateRequestResettableField FromValue(string value) =>
        FromValueCore(value);
}
