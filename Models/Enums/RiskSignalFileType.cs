using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The file type for risk signal analysis
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskSignalFileType>))]
public sealed record RiskSignalFileType : StringEnum<RiskSignalFileType>
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

    public static RiskSignalFileType FromValue(string value) => FromValueCore(value);
}
