using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The valid name matching sensitivity configurations for a screening program. Note that while certain matching techniques may be more prevalent on less strict settings, all matching algorithms are enabled for every sensitivity.
/// <para>
/// <c>coarse</c> - See more potential matches. This sensitivity will see more broad phonetic matches across alphabets that make missing a potential hit very unlikely. This setting is noisier and will require more manual review.
/// </para>
/// <para>
/// <c>balanced</c> - A good default for most companies. This sensitivity is balanced to show high quality hits with reduced noise.
/// </para>
/// <para>
/// <c>strict</c> - Aggressive false positive reduction. This sensitivity will require names to be more similar than <c>coarse</c> and <c>balanced</c> settings, relying less on phonetics, while still accounting for character transpositions, missing tokens, and other common permutations.
/// </para>
/// <para>
/// <c>exact</c> - Matches must be nearly exact. This sensitivity will only show hits with exact or nearly exact name matches with only basic correction such as extraneous symbols and capitalization. This setting is generally not recommended unless you have a very specific use case.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProgramNameSensitivity>))]
public sealed record ProgramNameSensitivity : StringEnum<ProgramNameSensitivity>
{
    private ProgramNameSensitivity(string value) : base(value)
    {
    }

    public static readonly ProgramNameSensitivity Coarse = new("coarse");

    public static readonly ProgramNameSensitivity Balanced = new("balanced");

    public static readonly ProgramNameSensitivity Strict = new("strict");

    public static readonly ProgramNameSensitivity Exact = new("exact");

    public static ProgramNameSensitivity FromValue(string value) => FromValueCore(value);
}
