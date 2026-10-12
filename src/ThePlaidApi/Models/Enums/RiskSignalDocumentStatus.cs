using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Status of a document for risk signal analysis
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskSignalDocumentStatus>))]
public sealed record RiskSignalDocumentStatus : OpenStringEnum<RiskSignalDocumentStatus>
{
    private RiskSignalDocumentStatus(string value) : base(value)
    {
    }

    public static readonly RiskSignalDocumentStatus Processing = new("PROCESSING");

    public static readonly RiskSignalDocumentStatus ProcessingComplete = new("PROCESSING_COMPLETE");

    public static readonly RiskSignalDocumentStatus ProcessingError = new("PROCESSING_ERROR");

    public static readonly RiskSignalDocumentStatus PasswordProtected = new("PASSWORD_PROTECTED");

    public static readonly RiskSignalDocumentStatus VirusDetected = new("VIRUS_DETECTED");

    public TResult Match<TResult>(Func<TResult> onProcessing,
        Func<TResult> onProcessingComplete,
        Func<TResult> onProcessingError,
        Func<TResult> onPasswordProtected,
        Func<TResult> onVirusDetected,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Processing => onProcessing(),
            _ when this == ProcessingComplete => onProcessingComplete(),
            _ when this == ProcessingError => onProcessingError(),
            _ when this == PasswordProtected => onPasswordProtected(),
            _ when this == VirusDetected => onVirusDetected(),
            _ => otherwise(Value)
        };

    public void Match(Action onProcessing,
        Action onProcessingComplete,
        Action onProcessingError,
        Action onPasswordProtected,
        Action onVirusDetected,
        Action<string> otherwise)
    {
        if (this == Processing) onProcessing();
        else if (this == ProcessingComplete) onProcessingComplete();
        else if (this == ProcessingError) onProcessingError();
        else if (this == PasswordProtected) onPasswordProtected();
        else if (this == VirusDetected) onVirusDetected();
        else otherwise(Value);
    }
}
