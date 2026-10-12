using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A high level description of the quality of the image the user submitted.
/// <para>
/// For example, an image that is blurry, distorted by glare from a nearby light source, or improperly framed might be marked as low or medium quality. Poor quality images are more likely to fail OCR and/or template conformity checks.
/// </para>
/// <para>
/// Note: By default, Plaid will let a user recapture document images twice before failing the entire session if we attribute the failure to low image quality.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ImageQuality>))]
public sealed record ImageQuality : OpenStringEnum<ImageQuality>
{
    private ImageQuality(string value) : base(value)
    {
    }

    public static readonly ImageQuality High = new("high");

    public static readonly ImageQuality Medium = new("medium");

    public static readonly ImageQuality Low = new("low");

    public TResult Match<TResult>(Func<TResult> onHigh,
        Func<TResult> onMedium,
        Func<TResult> onLow,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == High => onHigh(),
            _ when this == Medium => onMedium(),
            _ when this == Low => onLow(),
            _ => otherwise(Value)
        };

    public void Match(Action onHigh, Action onMedium, Action onLow, Action<string> otherwise)
    {
        if (this == High) onHigh();
        else if (this == Medium) onMedium();
        else if (this == Low) onLow();
        else otherwise(Value);
    }
}
