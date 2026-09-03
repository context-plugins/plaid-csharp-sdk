using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome of checking the associated hit against state databases.
/// <para>
///
/// <c>match</c> - The field is an exact match with the state database.
/// </para>
/// <para>
/// <c>partial_match</c> - The field is a partial match with the state database.
/// </para>
/// <para>
/// <c>no_match</c> - The field is not an exact match with the state database.
/// </para>
/// <para>
/// <c>no_data</c> - The field was unable to be checked against state databases.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AamvaDetailedMatchResult>))]
public sealed record AamvaDetailedMatchResult : StringEnum<AamvaDetailedMatchResult>
{
    private AamvaDetailedMatchResult(string value) : base(value)
    {
    }

    public static readonly AamvaDetailedMatchResult Match = new("match");

    public static readonly AamvaDetailedMatchResult PartialMatch = new("partial_match");

    public static readonly AamvaDetailedMatchResult NoMatch = new("no_match");

    public static readonly AamvaDetailedMatchResult NoData = new("no_data");

    public static AamvaDetailedMatchResult FromValue(string value) => FromValueCore(value);
}
