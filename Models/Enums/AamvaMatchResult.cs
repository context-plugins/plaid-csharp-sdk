using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome of checking the particular field against state databases.
/// <para>
///
/// <c>match</c> - The field is an exact match with the state database.
/// </para>
/// <para>
/// <c>no_match</c> - The field is not an exact match with the state database.
/// </para>
/// <para>
/// <c>no_data</c> - The field was unable to be checked against state databases.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AamvaMatchResult>))]
public sealed record AamvaMatchResult : StringEnum<AamvaMatchResult>
{
    private AamvaMatchResult(string value) : base(value)
    {
    }

    public static readonly AamvaMatchResult Match = new("match");

    public static readonly AamvaMatchResult NoMatch = new("no_match");

    public static readonly AamvaMatchResult NoData = new("no_data");

    public static AamvaMatchResult FromValue(string value) => FromValueCore(value);
}
