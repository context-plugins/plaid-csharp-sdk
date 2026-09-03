using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Analysis options to enable for document parsing
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncomeVerificationDocParsingConfig>))]
public sealed record IncomeVerificationDocParsingConfig : StringEnum<IncomeVerificationDocParsingConfig>
{
    private IncomeVerificationDocParsingConfig(string value) : base(value)
    {
    }

    public static readonly IncomeVerificationDocParsingConfig Ocr = new("ocr");

    public static readonly IncomeVerificationDocParsingConfig RiskSignals = new("risk_signals");

    public static IncomeVerificationDocParsingConfig FromValue(string value) => FromValueCore(value);
}
