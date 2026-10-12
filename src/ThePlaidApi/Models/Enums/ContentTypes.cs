using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Types of document formats. (Suggested values)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ContentTypes>))]
public sealed record ContentTypes : OpenStringEnum<ContentTypes>
{
    private ContentTypes(string value) : base(value)
    {
    }

    public static readonly ContentTypes ApplicationPdf = new("application/pdf");

    public static readonly ContentTypes ImageGif = new("image/gif");

    public static readonly ContentTypes ImageJpeg = new("image/jpeg");

    public static readonly ContentTypes ImageTiff = new("image/tiff");

    public static readonly ContentTypes ImagePng = new("image/png");

    public static readonly ContentTypes ApplicationJson = new("application/json");

    public TResult Match<TResult>(Func<TResult> onApplicationPdf,
        Func<TResult> onImageGif,
        Func<TResult> onImageJpeg,
        Func<TResult> onImageTiff,
        Func<TResult> onImagePng,
        Func<TResult> onApplicationJson,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ApplicationPdf => onApplicationPdf(),
            _ when this == ImageGif => onImageGif(),
            _ when this == ImageJpeg => onImageJpeg(),
            _ when this == ImageTiff => onImageTiff(),
            _ when this == ImagePng => onImagePng(),
            _ when this == ApplicationJson => onApplicationJson(),
            _ => otherwise(Value)
        };

    public void Match(Action onApplicationPdf,
        Action onImageGif,
        Action onImageJpeg,
        Action onImageTiff,
        Action onImagePng,
        Action onApplicationJson,
        Action<string> otherwise)
    {
        if (this == ApplicationPdf) onApplicationPdf();
        else if (this == ImageGif) onImageGif();
        else if (this == ImageJpeg) onImageJpeg();
        else if (this == ImageTiff) onImageTiff();
        else if (this == ImagePng) onImagePng();
        else if (this == ApplicationJson) onApplicationJson();
        else otherwise(Value);
    }
}
