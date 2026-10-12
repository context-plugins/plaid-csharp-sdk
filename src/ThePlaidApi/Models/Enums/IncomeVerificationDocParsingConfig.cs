using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Analysis options to enable for document parsing
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncomeVerificationDocParsingConfig>))]
public sealed record IncomeVerificationDocParsingConfig : OpenStringEnum<IncomeVerificationDocParsingConfig>
{
    private IncomeVerificationDocParsingConfig(string value) : base(value)
    {
    }

    public static readonly IncomeVerificationDocParsingConfig Ocr = new("ocr");

    public static readonly IncomeVerificationDocParsingConfig RiskSignals = new("risk_signals");

    public TResult Match<TResult>(Func<TResult> onOcr, Func<TResult> onRiskSignals, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ocr => onOcr(),
            _ when this == RiskSignals => onRiskSignals(),
            _ => otherwise(Value)
        };

    public void Match(Action onOcr, Action onRiskSignals, Action<string> otherwise)
    {
        if (this == Ocr) onOcr();
        else if (this == RiskSignals) onRiskSignals();
        else otherwise(Value);
    }
}
