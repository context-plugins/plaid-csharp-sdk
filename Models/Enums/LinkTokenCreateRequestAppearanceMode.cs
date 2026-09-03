using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Enum representing the desired appearance mode for Link, used to force light or dark modes or set Link to change depending on user system settings. Currently in closed beta.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkTokenCreateRequestAppearanceMode>))]
public sealed record LinkTokenCreateRequestAppearanceMode : StringEnum<LinkTokenCreateRequestAppearanceMode>
{
    private LinkTokenCreateRequestAppearanceMode(string value) : base(value)
    {
    }

    public static readonly LinkTokenCreateRequestAppearanceMode Light = new("LIGHT");

    public static readonly LinkTokenCreateRequestAppearanceMode Dark = new("DARK");

    public static readonly LinkTokenCreateRequestAppearanceMode System = new("SYSTEM");

    public static LinkTokenCreateRequestAppearanceMode FromValue(string value) => FromValueCore(value);
}
