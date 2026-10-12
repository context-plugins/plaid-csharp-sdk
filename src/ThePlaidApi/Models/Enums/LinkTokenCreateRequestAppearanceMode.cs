using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Enum representing the desired appearance mode for Link, used to force light or dark modes or set Link to change depending on user system settings. Currently in closed beta.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkTokenCreateRequestAppearanceMode>))]
public sealed record LinkTokenCreateRequestAppearanceMode : OpenStringEnum<LinkTokenCreateRequestAppearanceMode>
{
    private LinkTokenCreateRequestAppearanceMode(string value) : base(value)
    {
    }

    public static readonly LinkTokenCreateRequestAppearanceMode Light = new("LIGHT");

    public static readonly LinkTokenCreateRequestAppearanceMode Dark = new("DARK");

    public static readonly LinkTokenCreateRequestAppearanceMode System = new("SYSTEM");

    public TResult Match<TResult>(Func<TResult> onLight,
        Func<TResult> onDark,
        Func<TResult> onSystem,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Light => onLight(),
            _ when this == Dark => onDark(),
            _ when this == System => onSystem(),
            _ => otherwise(Value)
        };

    public void Match(Action onLight, Action onDark, Action onSystem, Action<string> otherwise)
    {
        if (this == Light) onLight();
        else if (this == Dark) onDark();
        else if (this == System) onSystem();
        else otherwise(Value);
    }
}
