using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The name of a field that can be reset back to null
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WatchlistScreeningEntityUpdateRequestResettableField>))]
public sealed record WatchlistScreeningEntityUpdateRequestResettableField : StringEnum<WatchlistScreeningEntityUpdateRequestResettableField>
{
    private WatchlistScreeningEntityUpdateRequestResettableField(string value) : base(value)
    {
    }

    public static readonly WatchlistScreeningEntityUpdateRequestResettableField Assignee = new("assignee");

    public static WatchlistScreeningEntityUpdateRequestResettableField FromValue(string value) =>
        FromValueCore(value);
}
