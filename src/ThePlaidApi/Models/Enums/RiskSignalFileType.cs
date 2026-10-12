using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The file type for risk signal analysis
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskSignalFileType>))]
public sealed record RiskSignalFileType : OpenStringEnum<RiskSignalFileType>
{
    private RiskSignalFileType(string value) : base(value)
    {
    }

    public static readonly RiskSignalFileType Unknown = new("UNKNOWN");

    public static readonly RiskSignalFileType ImagePdf = new("IMAGE_PDF");

    public static readonly RiskSignalFileType ScanOcr = new("SCAN_OCR");

    public static readonly RiskSignalFileType TruePdf = new("TRUE_PDF");

    public static readonly RiskSignalFileType Image = new("IMAGE");

    public static readonly RiskSignalFileType MixedPagePdf = new("MIXED_PAGE_PDF");

    public static readonly RiskSignalFileType EmptyPdf = new("EMPTY_PDF");

    public static readonly RiskSignalFileType FlattenedPdf = new("FLATTENED_PDF");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onImagePdf,
        Func<TResult> onScanOcr,
        Func<TResult> onTruePdf,
        Func<TResult> onImage,
        Func<TResult> onMixedPagePdf,
        Func<TResult> onEmptyPdf,
        Func<TResult> onFlattenedPdf,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == ImagePdf => onImagePdf(),
            _ when this == ScanOcr => onScanOcr(),
            _ when this == TruePdf => onTruePdf(),
            _ when this == Image => onImage(),
            _ when this == MixedPagePdf => onMixedPagePdf(),
            _ when this == EmptyPdf => onEmptyPdf(),
            _ when this == FlattenedPdf => onFlattenedPdf(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown,
        Action onImagePdf,
        Action onScanOcr,
        Action onTruePdf,
        Action onImage,
        Action onMixedPagePdf,
        Action onEmptyPdf,
        Action onFlattenedPdf,
        Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == ImagePdf) onImagePdf();
        else if (this == ScanOcr) onScanOcr();
        else if (this == TruePdf) onTruePdf();
        else if (this == Image) onImage();
        else if (this == MixedPagePdf) onMixedPagePdf();
        else if (this == EmptyPdf) onEmptyPdf();
        else if (this == FlattenedPdf) onFlattenedPdf();
        else otherwise(Value);
    }
}
