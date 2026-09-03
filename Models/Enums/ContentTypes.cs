using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Types of document formats. (Suggested values)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ContentTypes>))]
public sealed record ContentTypes : StringEnum<ContentTypes>
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

    public static ContentTypes FromValue(string value) => FromValueCore(value);
}
