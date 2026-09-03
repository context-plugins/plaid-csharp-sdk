using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Status of a document for risk signal analysis
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskSignalDocumentStatus>))]
public sealed record RiskSignalDocumentStatus : StringEnum<RiskSignalDocumentStatus>
{
    private RiskSignalDocumentStatus(string value) : base(value)
    {
    }

    public static readonly RiskSignalDocumentStatus Processing = new("PROCESSING");

    public static readonly RiskSignalDocumentStatus ProcessingComplete = new("PROCESSING_COMPLETE");

    public static readonly RiskSignalDocumentStatus ProcessingError = new("PROCESSING_ERROR");

    public static readonly RiskSignalDocumentStatus PasswordProtected = new("PASSWORD_PROTECTED");

    public static readonly RiskSignalDocumentStatus VirusDetected = new("VIRUS_DETECTED");

    public static RiskSignalDocumentStatus FromValue(string value) => FromValueCore(value);
}
